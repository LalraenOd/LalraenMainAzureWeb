namespace LalraenMainAzureWeb.Models
{
    public class InstallmentModel
    {
        public InstallmentModel(float installmentSum, float installmentDuration, float installmentPercent,
            float installSumPerMonth, float installFinalSum, float installOverPayment)
        {
            InstallmentSum = installmentSum;
            InstallmentDuration = installmentDuration;
            InstallmentPercent = installmentPercent;
            InstallSumPerMonth = installSumPerMonth;
            InstallFinalSum = installFinalSum;
            InstallOverPayment = installOverPayment;
        }

        private float InstallmentSum { get; set; }
        private float InstallmentDuration { get; set; }
        private float InstallmentPercent { get; set; }
        private float InstallSumPerMonth { get; set; }
        private float InstallFinalSum { get; set; }
        private float InstallOverPayment { get; set; }
    }
}