using System;

namespace LegacyRenewalApp;

public class PaymentByPayPal : IPaymentType
{
    public decimal CalculateAmount(decimal amount)
    {
        Console.WriteLine("Paying method by PayPal"+amount);
        throw new System.NotImplementedException();
    }
}