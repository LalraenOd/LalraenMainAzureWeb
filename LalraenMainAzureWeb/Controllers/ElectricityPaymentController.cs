using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
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

        [HttpGet]
        public ActionResult Calculate(int meterLastReadings, int meterCurrentReading)
        {
            double sumToPay = ElectricityPayment.ElectricityPayment.ElecSum(meterLastReadings, meterCurrentReading);

            return ViewBag(sumToPay);
        }
    }
}
