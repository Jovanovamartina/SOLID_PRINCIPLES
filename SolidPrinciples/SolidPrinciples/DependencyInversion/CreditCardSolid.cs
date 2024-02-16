
namespace SolidPrinciples.DependencyInversion
{
    public interface IPaymentMethod
    {
        void ProcessPayment(decimal amount);
    }

    public class CreditCardSolid : IPaymentMethod
    {
        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine($"Processing credit card payment of {amount}");
        }
    }

    public class PayPal : IPaymentMethod
    {
        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine($"Processing PayPal payment of {amount}");
        }
    }

    public class PaymentProcessorSolid
    {
        private readonly IPaymentMethod _paymentMethod;

        public PaymentProcessorSolid(IPaymentMethod paymentMethod)
        {
            _paymentMethod = paymentMethod;
        }

        public void ExecutePayment(decimal amount)
        {
            _paymentMethod.ProcessPayment(amount);
        }
    }
}
