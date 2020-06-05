using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;
using TestIdeas.Helpers;
using TestIdeas.Models;

namespace TestIdeas.Controllers
{
    public class GasPropertiesController : Controller
    {
        [HttpGet]
        public ActionResult GasProperties()
        {
            var model = new GasPropertiesModel();
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CalculateGasProperties(FormCollection fc)
        {
            var modelData = new GasPropertiesModel();

            var temp = ControllerHelpers.PrintVariables(fc);

            modelData.IsSuccessful = true;
            modelData.Message = "";
            var outputJson = JsonConvert.SerializeObject(modelData);
            return Content(outputJson);
        }
    }
}