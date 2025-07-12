using StrategyPattern.ConcreteStrategies;
using StrategyPattern.Context;

public class Program
{
    public static void Main()
    {
        Order order = new Order(100.0);

        order.SetPaymentStrategy(new CreditCardPayment());
        order.ProcessPayment();

        order.SetPaymentStrategy(new PayPalPayment());
        order.ProcessPayment();

        Console.ReadLine();
    }
}