using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace MVP.Generate.Excel.Entities
{
    public class SubcriptionTrackingInput : DateRangeInput
    {
        [JsonProperty("data")]
        public List<SubcriptionTracking> SubcriptionTrackings { set; get; }
    }
    public class SubcriptionTracking
    {
        public SubcriptionTracking()
        {
            Volume = new Volume();
            NSR = new NSR();
            Promotions = new Promotions();
            Purchase = new Purchase();
            UcashPointsEarning = new UcashPointsEarning();
        }
        [JsonProperty("order_number")]
        public string OrderNumber { set; get; }
        [JsonProperty("order_date")]
        public string OrderDate { set; get; }
        [JsonProperty("type_of_order")]
        public string TypeOrder { set; get; }
        [JsonProperty("first_delivery")]
        public string FirstDeliveryDate { set; get; }
        [JsonProperty("last_delivery")]
        public string LastDeliveryDate { set; get; }
        [JsonProperty("frequency")]
        public string Frequency { set; get; }
        [JsonProperty("remaining_deliveries")]
        public string RemainingDeliveries { set; get; }
        [JsonProperty("status")]
        public string Status { set; get; }
        [JsonProperty("cancelled_at_delivery")]
        public string CancelledAtDelivery { set; get; }
        [JsonProperty("cancellation_date")]
        public string CancellationDate { set; get; }
        [JsonProperty("cancellation_fee")]
        public string CancellationFee { set; get; }
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
        [JsonProperty("ucash_points_earning")]
        public UcashPointsEarning UcashPointsEarning { set; get; }
    }
}
