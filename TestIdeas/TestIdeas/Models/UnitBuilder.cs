using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestIdeas.Models
{
    public static class UnitBuilder
    {
        private static List<Unit> units;

        static UnitBuilder()
        {
            units = new List<Unit>
            {
                new Unit("meter", "m", 1),
                new Unit("cm", "cm", 0.01),
                new Unit("foot", "ft", 0.3048)
            };
        }

        public static Unit GetUnit(string displaySymbol)
        {
            if (units == null || units.Count == 0)
                return null;

            return units.FirstOrDefault(x => x.DisplaySymbol == displaySymbol);
        }
    }
}