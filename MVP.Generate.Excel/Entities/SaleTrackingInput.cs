using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVP.Generate.Excel.Entities
{
    public class SaleTrackingInput
    {
        public SaleTrackingInput()
        {
            SaleTrackings = new List<SaleTracking>();
        }
        public string DateRange { set; get; }
        public List<SaleTracking> SaleTrackings { set; get; }
    }
    public class SaleTracking
    {
        public SaleTracking()
        {
            Volume = new Volume();
            NSR = new NSR();
            Promotions = new Promotions();
            Vendor = new Vendor();
            Payment = new Payment();
            UcashPointsEarning = new UcashPointsEarning();
        }
        public string OrderNumber { set; get; }
        public string OrderDate { set; get; }
        public string TypefOrder { set; get; }
        public string Status { set; get; }
        public int Remaining { set; get; }
        public string ProductName { set; get; }
        public string ProductSKUID { set; get; }
        public string Category { set; get; }
        public string SubCategory { set; get; }
        public string CustomerID { set; get; }
        public Volume Volume { set; get; }
        public NSR NSR { set; get; }
        public Promotions Promotions { set; get; }
        public Vendor Vendor { set; get; }
        public string NSRRedemptions { set; get; }
        public Payment Payment { set; get; }
        public Refunds Refunds { set; get; }
        public UcashPointsEarning UcashPointsEarning { set; get; }
    }
    public class Volume
    {
        public string Units { set; get; }
        public string Litres { set; get; }
    }
    public class NSR
    {
        public float BasePrice { set; get; }
        public float TaxPercent { set; get; }
        public float TaxValue { set; get; }
    }
    public class Vendor
    {
        public string Name { set; get; }
        public float BasePrice { set; get; }
        public float Tax { set; get; }
        public float Value { set; get; }
    }
    public class Promotions
    {
        public float DiscountPercent { set; get; }
        public float Value { set; get; }
        public float PointsUsage { set; get; }
        public string CouponCode { set; get; }
        public float CouponValue { set; get; }
        public float TotalRedemption { set; get; }
    }
    public class Payment
    {
        public string StripeCard { set; get; }
        public string CorporateWallet { set; get; }
        public float Redemption { set; get; }
        public float Total { set; get; }
    }
    public class Refunds
    {
        public string StripeCard { set; get; }
        public string CorporateWallet { set; get; }
        public float Redemption { set; get; }
        public string Reason { set; get; }
        public float Total { set; get; }
    }
    public class UcashPointsEarning
    {
        public float CashBackPercent { set; get; }
        public float CashBackValue { set; get; }
        public float PendingEarning { set; get; }
        public float CancelledEarning { set; get; }
        public float RealizedEarning { set; get; }
        public float Total { set; get; }
    }
}
