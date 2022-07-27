using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace MVP.Generate.Excel.Entities
{
    public class ProcessingFeeTrackingInput : DateRangeInput
    {
        [JsonProperty("data")]
        public List<ProcessingFeeTracking> ProcessingFeeTrackings { set; get; }
    }
    public class ProcessingFeeTracking
    {
        [JsonProperty("order_number")]
        public string OrderNumber { set; get; }
        [JsonProperty("order_date")]
        public string OrderDate { set; get; }
        [JsonProperty("customer_id")]
        public string CustomerID { set; get; }
        [JsonProperty("type_of_order")]
        public string TypeOrder { set; get; }
        [JsonProperty("status")]
        public string Status { set; get; }
        [JsonProperty("stripe_card")]
        public string StripeCard { set; get; }
        [JsonProperty("corporate_wallet")]
        public string CorporateWallet { set; get; }
        [JsonProperty("redemption")]
        public float Redemption { set; get; }
        [JsonProperty("total")]
        public float Total { set; get; }
        [JsonProperty("vendor_name")]
        public string VendorName { set; get; }
    }
}
