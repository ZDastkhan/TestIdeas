using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestIdeas.Models
{
    public class GasPropertiesModel
    {
        public string Title { get; set; }
        public double GasSG { get; set; }
        public double GasH2S { get; set; }
        public double GasCO2 { get; set; }
        public double GasN2 { get; set; }
        public string GasZFactor { get; set; }
        public double Pressure { get; set; }
        public double Temperature { get; set; }

        public string Message { get; set; }
        public string IsSuccessful { get; set; }

        public GasPropertiesModel()
        {
            GasSG = 0.7;
            Message = string.Empty;
            Pressure = 2500;
            Temperature = 180;
        }
    }
}