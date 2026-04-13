using System;

namespace LegacyRenewalApp;

public class PaymentByCard : IPaymentType
{
    public decimal CalculateAmount(decimal amount)
    {
        Console.Write("Paying method By Card");
        throw new System.NotImplementedException();
    }
}