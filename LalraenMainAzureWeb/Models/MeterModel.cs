using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LalraenMainAzureWeb.Models
{
    public class MeterModel
    {
        public MeterModel(int lastMeters, int currentMeters, int sumToPay)
        {
            LastMeters = lastMeters;
            CurrentMeters = currentMeters;
            SumToPay = sumToPay;
        }

        private int LastMeters { get; set; }
        private int CurrentMeters { get; set; }
        private int SumToPay { get; set; }
    }
}