namespace LegacyRenewalApp;

public class SeatCountValidator
{
    public static DiscountAndNotes seatCountValidate(int seatCount)
    {
        decimal baseAmount = 0m;
        decimal discountAmount = 0m;
        string notes = "";
        
        if (seatCount >= 50)
             {
                 discountAmount += baseAmount * 0.12m;
                 notes += "large team discount; ";
             }
             else if (seatCount >= 20)
             {
                 discountAmount += baseAmount * 0.08m;
                 notes += "medium team discount; ";
             }
             else if (seatCount >= 10)
             {
                 discountAmount += baseAmount * 0.04m;
                 notes += "small team discount; ";
             }

        return new DiscountAndNotes
        {
            discountAmount = discountAmount,
            notes = notes
        };
    }
}