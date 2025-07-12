using StrategyPattern.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.ConcreteStrategies
{
    public class CreditCardPayment : IPaymentStrategy
    {
        public void Pay(double amount)
        {
            Console.WriteLine($"Paid {amount:C} with Credit Card.");
        }
    }
}
