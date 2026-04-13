using System;

namespace LegacyRenewalApp;

    public class RenewalInvoiceBuilder
    {
        private RenewalInvoice _renewalInvoice = new RenewalInvoice();

        public RenewalInvoice Build()
        {
            return _renewalInvoice;
        }

        public RenewalInvoiceBuilder SetIncoiveNumber(string consumerID)
        {
            _renewalInvoice.InvoiceNumber = consumerID;

            return this;
        }
        public RenewalInvoiceBuilder SetCustomerName(string customerName)
        {
            _renewalInvoice.CustomerName = customerName;
            return this;

        }
        public RenewalInvoiceBuilder SetPlanCode(string planCode)
        {
            _renewalInvoice.PlanCode = planCode;
            return this;

        }

        public RenewalInvoiceBuilder SetPaymentMethod(string paymentMethod)
        {
            _renewalInvoice.PaymentMethod = paymentMethod;
            return this;
        }

        public RenewalInvoiceBuilder SetSeatCount(int seatCount)
        {
            _renewalInvoice.SeatCount = seatCount;
            return this;
        }

        public RenewalInvoiceBuilder SetBaseAmount(decimal baseAmount)
        {
            _renewalInvoice.BaseAmount = baseAmount;
            return this;
        }

        public RenewalInvoiceBuilder SetDiscountAmount(decimal discountAmount)
        {
            _renewalInvoice.DiscountAmount = discountAmount;
            return this;
        }
        public RenewalInvoiceBuilder SetSupportFee(decimal supportFee)
        {
        _renewalInvoice.SupportFee = supportFee;
        return this;
        }
        public RenewalInvoiceBuilder SetPaymentFee(decimal paymentFee)
        {
            _renewalInvoice.PaymentFee = paymentFee;
            return this;
        }
        public RenewalInvoiceBuilder SetTaxAmount(decimal taxAmount)
        {
            _renewalInvoice.TaxAmount = taxAmount;
            return this;
        }
        public RenewalInvoiceBuilder SetFinalAmount(decimal finalAmount)
        {
            _renewalInvoice.FinalAmount = finalAmount;
            return this;
        }
        public RenewalInvoiceBuilder SetNotes(string notes)
        {
            _renewalInvoice.Notes = notes;
            return this;
        }
        public RenewalInvoiceBuilder SetGeneratedAt(DateTime dateGenerated)
        {
            _renewalInvoice.GeneratedAt = dateGenerated;
            return this;
        }
        //GETERS    
        public string getInvoiceNumber()
        {
            return _renewalInvoice.InvoiceNumber;
        }
        
    }

    // using System;
    // using LegacyRenewalApp;
    //
    // namespace LegacyRenewalAppConsumer
    // {
    //     internal class Program
    //     {
    //         private static void Main(string[] args)
    //         {
    //             /*
    //              * DO NOT CHANGE THIS FILE AT ALL
    //              */
    //
    //             var renewalService = new SubscriptionRenewalService();
    //
    //             var invoice = renewalService.CreateRenewalInvoice(
    //                 customerId: 3,
    //                 planCode: "PRO",
    //                 seatCount: 18,
    //                 paymentMethod: "CARD",
    //                 includePremiumSupport: true,
    //                 useLoyaltyPoints: true);
    //
    //             Console.WriteLine("Invoice created successfully");
    //             Console.WriteLine(invoice);
    //             Console.WriteLine($"Final amount: {invoice.FinalAmount:F2}");
    //         }
    //     }
    // }