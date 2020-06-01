using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestIdeas.Models
{
    public class Quantity
    {
        public string Name { get; set; }
        public Unit InternalUnit { get; set; }
        public Unit DisplayUnit { get; set; }
        public double InternalMin { get; set; }
        public double InternalMax { get; set; }

        public double Value { get; set; }

        public Quantity()
        {
            Value = 1.5;
        }
    }
}