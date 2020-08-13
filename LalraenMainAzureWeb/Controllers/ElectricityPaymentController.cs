using System.Web.Mvc;

namespace LalraenMainAzureWeb.Controllers
{
    public class ElectricityPaymentController : Controller
    {
        // GET: ElectricityPayment
        public ActionResult ElectricityMain()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Calculate()
        {
            return ViewBag();
        }
    }
}