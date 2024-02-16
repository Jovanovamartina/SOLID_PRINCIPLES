﻿
namespace SolidPrinciples.DependencyInversion
{
    
        public class CreditCard
        {
            public void ProcessPayment(decimal amount)
            {
                Console.WriteLine($"Processing credit card payment of {amount}");
            }
        }

        public class PaymentProcessor
        {
            public void ExecutePayment(decimal amount)
            {
                var creditCard = new CreditCard();
                creditCard.ProcessPayment(amount);
            }
        }
    }

