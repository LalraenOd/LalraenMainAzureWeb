namespace MonobankInstallment
{
    public class MonobankInstallmentMain
    {
        public static double installPercent = 1.9 / 100;
        public static double installSumPerMonth;
        public static double installFinalSum;
        public static double installOverPayment;

        public static void InstallmentCount(int installSum, int installDuration)
        {
            installSumPerMonth = (installSum / installDuration) + (installSum * installPercent);
            installFinalSum = installSumPerMonth * installDuration;
            installOverPayment = installFinalSum - installSum;
        }
    }
}