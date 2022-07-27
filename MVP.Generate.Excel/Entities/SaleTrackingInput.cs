using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace MVP.Generate.Excel.Entities
{
    public class SaleTrackingInput : DateRangeInput
    {
        public SaleTrackingInput()
        {
            SaleTrackings = new List<SaleTracking>();
        }
        [JsonProperty("data")]
        public List<SaleTracking> SaleTrackings { set; get; }
    }
    public class SaleTracking
    {
        public SaleTracking()
        {
            Volume = new Volume();
            NSR = new NSR();
            Promotions = new Promotions();
            Purchase = new Purchase();
            Payment = new Payment();
            UcashPointsEarning = new UcashPointsEarning();
        }
        [JsonProperty("order_number")]
        public string OrderNumber { set; get; }
        [JsonProperty("order_date")]
        public string OrderDate { set; get; }
        [JsonProperty("type_of_order")]
        public string TypeOrder { set; get; }
        [JsonProperty("status")]
        public string Status { set; get; }
        [JsonProperty("remaining")]
        public int Remaining { set; get; }
        [JsonProperty("product_name")]
        public string ProductName { set; get; }
        [JsonProperty("product_sku")]
        public string ProductSKUID { set; get; }
        [JsonProperty("category")]
        public string Category { set; get; }
        [JsonProperty("sub_category")]
        public string SubCategory { set; get; }
        [JsonProperty("customer_id")]
        public string CustomerID { set; get; }
        [JsonProperty("volume")]
        public Volume Volume { set; get; }
        [JsonProperty("nsr")]
        public NSR NSR { set; get; }
        [JsonProperty("promotions")]
        public Promotions Promotions { set; get; }
        [JsonProperty("purchase")]
        public Purchase Purchase { set; get; }
        [JsonProperty("nsr_redemtions")]
        public string NSRRedemptions { set; get; }
        [JsonProperty("payment")]
        public Payment Payment { set; get; }
        [JsonProperty("refund")]
        public Refunds Refunds { set; get; }
        [JsonProperty("ucash_points_earning")]
        public UcashPointsEarning UcashPointsEarning { set; get; }
    }
    public class Volume
    {
        [JsonProperty("units")]
        public string Units { set; get; }
        [JsonProperty("litres")]
        public string Litres { set; get; }
    }
    public class NSR
    {
        [JsonProperty("base_price")]
        public string BasePrice { set; get; }
        [JsonProperty("percent")]
        public string TaxPercent { set; get; }
        [JsonProperty("value")]
        public string TaxValue { set; get; }
    }
    public class Purchase
    {
        [JsonProperty("vendor_name")]
        public string Name { set; get; }
        [JsonProperty("base_price")]
        public string BasePrice { set; get; }
        [JsonProperty("tax")]
        public string Tax { set; get; }
        [JsonProperty("value")]
        public string Value { set; get; }
    }
    public class Promotions
    {
        [JsonProperty("percent")]
        public string DiscountPercent { set; get; }
        [JsonProperty("value")]
        public string Value { set; get; }
        [JsonProperty("point_usage")]
        public string PointsUsage { set; get; }
        [JsonProperty("coupon_code")]
        public string CouponCode { set; get; }
        [JsonProperty("coupon_value")]
        public string CouponValue { set; get; }
        [JsonProperty("total_redemption")]
        public string TotalRedemption { set; get; }
    }
    public class Payment
    {
        [JsonProperty("stripe_card")]
        public string StripeCard { set; get; }
        [JsonProperty("corporate_wallet")]
        public string CorporateWallet { set; get; }
        [JsonProperty("redemption")]
        public string Redemption { set; get; }
        [JsonProperty("total")]
        public string Total { set; get; }
    }
    public class Refunds
    {
        [JsonProperty("stripe_card")]
        public string StripeCard { set; get; }
        [JsonProperty("corporate_wallet")]
        public string CorporateWallet { set; get; }
        [JsonProperty("redemption")]
        public string Redemption { set; get; }
        [JsonProperty("reason")]
        public string Reason { set; get; }
        [JsonProperty("total")]
        public string Total { set; get; }
    }
    public class UcashPointsEarning
    {
        [JsonProperty("cashback_percent")]
        public string CashBackPercent { set; get; }
        [JsonProperty("cashback_value")]
        public string CashBackValue { set; get; }
        [JsonProperty("pending_earning")]
        public string PendingEarning { set; get; }
        [JsonProperty("cancelled_earning")]
        public string CancelledEarning { set; get; }
        [JsonProperty("realized_earning")]
        public string RealizedEarning { set; get; }
        [JsonProperty("total")]
        public string Total { set; get; }
    }
}
