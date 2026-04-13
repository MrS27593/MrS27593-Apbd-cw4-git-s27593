using System;

namespace LegacyRenewalApp;

public class PaymentByCash : IPaymentType
{
    public decimal CalculateAmount(decimal amount)
    {
        Console.WriteLine("Paying method by Cash "+amount);
        throw new System.NotImplementedException();
    }
}