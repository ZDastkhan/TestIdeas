using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
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

    }
}