using System;

namespace LegacyRenewalApp;

public class CustomerValidator
{
    public static DiscountAndNotes customerValidate(Customer customer, SubscriptionPlan plan,decimal baseAmount)
    {
        decimal discountAmount = 0m;
        string notes = "";
        
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
             return new DiscountAndNotes
             {
                 discountAmount = discountAmount,
                 notes = notes
             };
             
    }
}