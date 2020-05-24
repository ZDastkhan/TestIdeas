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
        public string CalculationType { get; set; }
        public double Pressure { get; set; }
        public double Temperature { get; set; }
        public double TemperatureMultipleP { get; set; }
        public double MinPressure { get; set; }
        public double MaxPressure { get; set; }
        public int PressureIncCount { get; set; }
        public double PressureMultipleT { get; set; }
        public double MinTemperature { get; set; }
        public double MaxTemperature { get; set; }
        public int TemperatureIncCount { get; set; }
        public string GasH2SUnit { get; set; }
        public string GasCO2Unit { get; set; }
        public string GasN2Unit { get; set; }
        public string PressureUnit { get; set; }
        public string TemperatureUnit { get; set; }
        public string MinPressureUnit { get; set; }
        public string MaxPressureUnit { get; set; }
        public string MinTemperatureUnit { get; set; }
        public string MaxTemperatureUnit { get; set; }
        public double TemperatureMultiplePUnit { get; set; }
        public double PressureMultipleTUnit { get; set; }
        public string Message { get; set; }
        public bool IsSuccessful { get; set; }

        public GasPropertiesModel()
        {
            GasSG = 0.7;
            Message = string.Empty;
            Pressure = 2500;
            Temperature = 180;
            MinPressure = 1000;
            MaxPressure = 5000;
            PressureIncCount = 10;
            MinTemperature = 70;
            MaxTemperature = 250;
            TemperatureIncCount = 10;
        }
    }
}