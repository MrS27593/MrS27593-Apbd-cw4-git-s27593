using System;

namespace LegacyRenewalApp;

public class CustomerValidator
{
    public static DiscountAndNotesAndTaxRate customerValidate(Customer customer, SubscriptionPlan plan,decimal baseAmount)
    {
        decimal discountAmount = 0m;
        string notes = "";
        decimal taxRate = 0m;
        
            if (!customer.IsActive)
             {
                 throw new InvalidOperationException("Inactive customers cannot renew subscriptions");
             }
            if (customer.Segment == "Silver")
             {
                 discountAmount += baseAmount * 0.05m;
                 notes += "silver discount; ";
             }
             else if (customer.Segment == "Gold")
             {
                 discountAmount += baseAmount * 0.10m;
                 notes += "gold discount; ";
             }
             else if (customer.Segment == "Platinum")
             {
                 discountAmount += baseAmount * 0.15m;
                 notes += "platinum discount; ";
             }
             else if (customer.Segment == "Education" && plan.IsEducationEligible)
             {
                 discountAmount += baseAmount * 0.20m;
                 notes += "education discount; ";
             }

             if (customer.YearsWithCompany >= 5)
             {
                 discountAmount += baseAmount * 0.07m;
                 notes += "long-term loyalty discount; ";
             }
             else if (customer.YearsWithCompany >= 2)
             {
                 discountAmount += baseAmount * 0.03m;
                 notes += "basic loyalty discount; ";
             }
             
            if (customer.Country == "Poland")
             {
                 taxRate = 0.23m;
             }
             else if (customer.Country == "Germany")
             {
                 taxRate = 0.19m;
             }
             else if (customer.Country == "Czech Republic")
             {
                 taxRate = 0.21m;
             }
             else if (customer.Country == "Norway")
             {
                 taxRate = 0.25m;
             }
             
             return new DiscountAndNotesAndTaxRate
             {
                 discountAmount = discountAmount,
                 notes = notes,
                 taxRate = taxRate
             };
             
    }
}