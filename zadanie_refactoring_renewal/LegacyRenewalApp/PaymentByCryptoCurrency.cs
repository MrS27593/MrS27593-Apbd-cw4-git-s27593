using System;

namespace LegacyRenewalApp;

public class PaymentByCryptoCurrency : IPaymentType
{
    public decimal CalculateAmount(decimal amount)
    {
        Console.Write("Paying method by Crypto"+amount);
        throw new System.NotImplementedException();
    }
}