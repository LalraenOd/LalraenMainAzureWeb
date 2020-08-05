using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectricityPayment
{
    public class MainElectricityPayment
    {
        public static double ElecSum(int meter_LastReadings, int meter_CurrentReading)
        {
            double summary;
            int meter_ReadingsDifferrence = meter_CurrentReading - meter_LastReadings;
            double Rate_Less100 = 0.9;
            double Rate_More100 = 1.68;
            if (meter_ReadingsDifferrence <= 100)
            {
                summary = (meter_ReadingsDifferrence * Rate_Less100);

            }
            else
            {
                double summary1 = (100 * Rate_Less100);
                double summary2 = ((meter_ReadingsDifferrence - 100) * Rate_More100);
                summary = summary1 + summary2;
            }
            return summary;
        }
    }
}
