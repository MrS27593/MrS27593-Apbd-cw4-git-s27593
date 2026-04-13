using System;

namespace LegacyRenewalApp;

public class PaymentByTransfer : IPaymentType
{
    public decimal CalculateAmount(decimal amount)
    {
        Console.WriteLine("Paying method by Transfer " + amount);
        throw new System.NotImplementedException();
    }
}