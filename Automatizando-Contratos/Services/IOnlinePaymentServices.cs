

namespace Services
{
    interface IOnlinePaymentServices

    {
        double PaymentFee(double amount);
        double Interest(double amount, int month);

    }
}
