using LalraenMainAzureWeb.Models;
using System;
using System.Web.Mvc;

namespace LalraenMainAzureWeb.Controllers
{
    public class MonobankController : Controller
    {
        // GET: Monobank
        [HttpGet]
        public ActionResult Monobank()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Monobank(InstallmentModel installmentModel)
        {
            installmentModel.SumPerMonth = Math.Round((installmentModel.Sum / installmentModel.Duration)
                + (installmentModel.Sum * (installmentModel.Percent / 100)));
            installmentModel.FinalSum = installmentModel.SumPerMonth * installmentModel.Duration;
            installmentModel.OverPayment = installmentModel.FinalSum - installmentModel.Sum;
            return View(installmentModel);
        }
    }
}