namespace LegacyRenewalApp;

public class LoyalitiesValidator
{
    public static LoyalFeatures LoyalFeaturesdValidate(bool includePremiumSupport, Customer customer ,bool useLoyaltyPoints, string normalizedPlanCode)
    {
        string notes = "";
        decimal supportFee=0m;
        decimal discountAmount = 0;
        if (useLoyaltyPoints && customer.LoyaltyPoints > 0)
        {
        int pointsToUse = customer.LoyaltyPoints > 200 ? 200 : customer.LoyaltyPoints;
        discountAmount += pointsToUse;
        notes += $"loyalty points used: {pointsToUse}; ";
        }
        
        if (includePremiumSupport)
        {
        if (normalizedPlanCode == "START")
        {
        supportFee = 250m;
        }
        else if (normalizedPlanCode == "PRO")
        {
        supportFee = 400m;
        }
        else if (normalizedPlanCode == "ENTERPRISE")
        {
        supportFee = 700m;
        }

        notes += "premium support included; ";
        }

        return new LoyalFeatures
        {
            supportFee = supportFee,
            notes = notes,
            discountAmount = discountAmount
        };
    }
}