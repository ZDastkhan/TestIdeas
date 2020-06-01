using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestIdeas.Models
{
    public class Unit
    {
        public double Scale { get; set; }
        public string Name { get; set; }
        public string DisplaySymbol { get; set; }

        public Unit(string name, string displaySymbol, double scale)
        {
            Name = name;
            DisplaySymbol = displaySymbol;
            Scale = scale;
        }
    }
}