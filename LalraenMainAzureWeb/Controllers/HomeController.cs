using System;
using System.Web;
using System.Web.Mvc;

namespace LalraenMainAzureWeb.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Main()
        {
            var cookie = new HttpCookie("testCookie", DateTime.Now.ToString("dd.MM.yyyy"));
            Response.SetCookie(cookie);
            return View();
        }

        public RedirectResult RedirectDonate()
        {
            return Redirect("https://send.monobank.ua/45CJRjVgEC");
        }

        public RedirectResult RedirectGitHub()
        {
            return Redirect("https://github.com/lalraenod");
        }
    }
}