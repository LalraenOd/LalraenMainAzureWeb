using LalraenMainAzureWeb.Models;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Web.Mvc;
using AngleSharp;
using AngleSharp.Html;
using AngleSharp.Html.Parser;

namespace LalraenMainAzureWeb.Controllers
{
    public class EdrpouParserController : Controller
    {
        // GET: EdrpouParser
        [HttpGet]
        public ActionResult EdrpouParser()
        {            
            return View();
        }

        [HttpPost]
        public ActionResult EdrpouParser(OrganisationModel organisationModel)
        {
            OrganisationModel organisationModelData = Parser(organisationModel, organisationModel.EdrpouCode);
            return View(organisationModelData);
        }

        /// <summary>
        /// Gives OrganisationModel info
        /// </summary>
        /// <param name="edrpou"></param>
        /// <returns></returns>
        public static OrganisationModel Parser(OrganisationModel organisationModel, string edrpou)
        {
            if (edrpou.Length == 8)
                return EdrpouDetailParser(organisationModel);
            else if (edrpou.Length == 10)
                return FopDataParser(organisationModel);
            else
                return null;
        }

        /// <summary>
        /// Gets data from open API edr.data-gov-ua.org/api
        /// </summary>
        /// <param name="edrpou">Input EDRPOU code to get info about</param>
        /// <returns>String with basic info like: FullName, Occupation and Status.</returns>
        private static OrganisationModel EdrpouDetailParser(OrganisationModel organisationModel)
        {
            var edrpou = organisationModel.EdrpouCode;
            using (WebClient client = new WebClient())
            {
                client.Encoding = Encoding.UTF8;
                string linkEdrpou = "http://edr.data-gov-ua.org/api/companies?where={\"edrpou\":{\"contains\":\"" + edrpou + "\"}}";
                string pageEdrpou = client.DownloadString(linkEdrpou);

                Regex regexOrgInfo = new Regex(
                @"officialName"":(?<ofName>.+)"",""address""
                | address"":(?<address>.+)"",""mainPerson""
                | mainPerson"":(?<mainPerson>.+)"",""occupation""
                | occupation"":(?<occupation>.+)"",""status""
                | status"":(?<status>.+)"",""id""
                ");
                Match matchInfo = regexOrgInfo.Match(pageEdrpou);
                organisationModel.OfficialName = matchInfo.Groups["ofName"].Value.ToString();
                organisationModel.Address = matchInfo.Groups["address"].Value.ToString();
                organisationModel.MainPerson = matchInfo.Groups["mainPerson"].Value.ToString();
                organisationModel.Occupation = matchInfo.Groups["occupation"].Value.ToString();
                organisationModel.Status = matchInfo.Groups["status"].Value.ToString();
            }
            return organisationModel;
        }

        /// <summary>
        /// Gets data about FOP from youcontrol. Be carefull. NOT SO FAST. DO SLEEP
        /// </summary>
        /// <param name="inn">INN code</param>
        /// <returns>OrganisationModel</returns>
        private static OrganisationModel FopDataParser(OrganisationModel organisationModel)
        {
            var inn = organisationModel.EdrpouCode;
            string link = "https://youcontrol.com.ua/search/?country=1&q=" + inn;
            using (WebClient client = new WebClient())
            {
                client.Encoding = Encoding.UTF8;
                string page = client.DownloadString(link);
                //Regex regex = new Regex(" <meta name=\"description\" content=\" (?<result>.+) Повне досьє на");
                Regex regex = new Regex("Повне досьє на (?<result>.+) ,");
                Match match = regex.Match(page);
                organisationModel.MainPerson = match.Groups["result"].Value.ToString();
            }
            return organisationModel;
        }
    
        private static OrganisationModel EdrpouDetailParser2(OrganisationModel organisationModel)
        {

            var edrpou = organisationModel.EdrpouCode;
            string linkEdrpou = "http://edr.data-gov-ua.org/api/companies?where={\"edrpou\":{\"contains\":\"" + edrpou + "\"}}";
            var parser = new HtmlParser();
            var doc = parser.ParseDocument(linkEdrpou);
            
            return organisationModel;
        }
    }
}