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

        public int LastMeters { get; set; }
        public int CurrentMeters { get; set; }
        public double SumToPay { get; set; }
    }
}