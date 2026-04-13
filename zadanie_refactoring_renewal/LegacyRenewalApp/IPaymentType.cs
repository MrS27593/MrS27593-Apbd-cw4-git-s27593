namespace LegacyRenewalApp;

public interface IPaymentType
{
    decimal CalculateAmount(decimal amount);
}