using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TestIdeas.Helpers
{
    public static class ControllerHelpers
    {
        public static string PrintVariables(FormCollection fc)
        {
            var str = string.Empty;
            foreach (var ctrl in fc)
            {
                var name = ctrl.ToString();
                var value = fc[name];

                if (value != null)
                {
                    str += name + "\t" + value + "\n";
                }
            }

            return str;
        }
    }
}