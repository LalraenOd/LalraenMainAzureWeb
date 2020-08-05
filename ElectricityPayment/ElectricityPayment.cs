namespace ElectricityPayment
{
    public class ElectricityPayment
    {
        /// <summary>
        /// Calculates price for energy
        /// </summary>
        /// <param name="meterLastReadings">Last readings</param>
        /// <param name="meterCurrentReading">Current readings</param>
        /// <returns>Sum to pay</returns>
        public static double ElecSum(int meterLastReadings, int meterCurrentReading)
        {
            double summary;
            int meterReadingsDifferrence = meterCurrentReading - meterLastReadings;
            double rateLess100 = 0.9;
            double rateMore100 = 1.68;
            if (meterReadingsDifferrence <= 100)
            {
                summary = (meterReadingsDifferrence * rateLess100);
            }
            else
            {
                double summary1 = (100 * rateLess100);
                double summary2 = ((meterReadingsDifferrence - 100) * rateMore100);
                summary = summary1 + summary2;
            }
            return summary;
        }
    }
}