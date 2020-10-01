namespace LalraenMainAzureWeb.Models
{
    public class InstallmentModel
    {
        public double Sum { get; set; }
        public double Duration { get; set; }
        public double Percent { get; set; } //= 1.9;
        public double SumPerMonth { get; set; }
        public double FinalSum { get; set; }
        public double OverPayment { get; set; }
    }
}