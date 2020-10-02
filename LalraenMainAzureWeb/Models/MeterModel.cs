namespace LalraenMainAzureWeb.Models
{
    public class MeterModel
    {
        public int LastMeters { get; set; }
        public int CurrentMeters { get; set; }
        public int MetersDifference { get; set; }
        public double RateLess100 { get; set; }//= 0.9;
        public double RateMore100 { get; set; }//= 1.68;
        public double SumToPay { get; set; }
    }
}