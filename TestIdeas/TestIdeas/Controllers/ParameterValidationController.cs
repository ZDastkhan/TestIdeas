using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using TestIdeas.Models;

namespace TestIdeas.Controllers
{
    public class ParameterValidationController : Controller
    {
        // GET: ParameterValidation
        public ActionResult ParameterValidationTest()
        {
            var internalUnit = UnitBuilder.GetUnit("m");
            var displayUnit = UnitBuilder.GetUnit("cm");

            var model = new Quantity
            {
                Name = "Length",
                InternalUnit = internalUnit,
                DisplayUnit = displayUnit,
                InternalMin = 5,
                InternalMax = 10
            };

            return View(model);
        }
    }
}