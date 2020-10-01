using LalraenMainAzureWeb.Models;
using System.Web.Mvc;

namespace LalraenMainAzureWeb.Controllers
{
    public class ElectricityController : Controller
    {
        // GET: Electricity
        [HttpGet]
        public ActionResult Electricity()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Electricity(MeterModel meterModel)
        {
            meterModel.MetersDifference = meterModel.CurrentMeters - meterModel.LastMeters;
            if (meterModel.MetersDifference <= 100)
            {
                meterModel.SumToPay = (meterModel.MetersDifference * meterModel.RateLess100);
            }
            else
            {
                double summary1 = (100 * meterModel.RateLess100);
                double summary2 = ((meterModel.MetersDifference - 100) * meterModel.RateMore100);
                meterModel.SumToPay = summary1 + summary2;
            }
            return View(meterModel);
        }
    }
}