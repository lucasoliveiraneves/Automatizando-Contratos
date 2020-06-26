

namespace Services
{
    class PaypalService:IOnlinePaymentServices
    {
        private const double FeePercentage = 0.02;
        private const double MonthlyInterestest = 0.01;

        public double Interest(double amount, int months)
        {
            return amount * MonthlyInterestest * months;
        }
        public double  PaymentFee(double amount)
        {
            return amount * FeePercentage;
        }
    }
}
