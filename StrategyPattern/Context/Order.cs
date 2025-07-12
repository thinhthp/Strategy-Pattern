using StrategyPattern.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Context
{
    public class Order
    {
        private double totalAmount;
        private IPaymentStrategy? paymentStrategy;

        public Order(double totalAmount)
        {
            this.totalAmount = totalAmount;
        }

        public void SetPaymentStrategy(IPaymentStrategy paymentStrategy)
        {
            this.paymentStrategy = paymentStrategy;
        }

        public void ProcessPayment()
        {
            if (paymentStrategy == null)
            {
                throw new InvalidOperationException("Payment strategy not set.");
            }
            paymentStrategy.Pay(totalAmount);
        }
    }
}
