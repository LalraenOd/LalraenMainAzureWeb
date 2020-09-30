using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ElectricityPayment;
using LalraenMainAzureWeb.Models;

namespace LalraenMainAzureWeb.Controllers
{
    public class ElectricityController : Controller
    {
        // GET: Electricity
        public ActionResult Electricity()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Calculate(int LastMeters, int CurrentMeters)
        {            
            double SumToPay = ElectricityPayment.ElectricityPayment.ElecSum(LastMeters, CurrentMeters);            
            return View();
        }
    }
}