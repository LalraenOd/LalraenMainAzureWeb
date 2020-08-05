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
            return View();
        }

        public ViewResult LoginForm()
        {
            return View();
        }

        public ViewResult SignupForm()
        {
            return View();
        }
    }
}