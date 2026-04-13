using System;

namespace LegacyRenewalApp;

public class PaymentByOtherMethods : IPaymentType
{
    public decimal CalculateAmount(decimal amount)
    {
        Console.WriteLine("Other Methods");
        throw new System.NotImplementedException();
    }
}