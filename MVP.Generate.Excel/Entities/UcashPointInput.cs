using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVP.Generate.Excel.Entities
{
    public class UcashPointInput : DateRangeInput
    {
        [JsonProperty("data")]
        public List<UcashPoint> UcashPoints { set; get; }
    }
    public class UcashPoint
    {
        [JsonProperty("date")]
        public string Date { set; get; }
        [JsonProperty("horeca")]
        public string HorecaA { set; get; }
        [JsonProperty("total_ucash_points")]
        public string TotalAvailableUcashPoints { set; get; }
        [JsonProperty("order_number")]
        public string DebitOrderumber { set; get; }
        [JsonProperty("status")]
        public string Status { set; get; }
        [JsonProperty("total_order_value")]
        public string TotalOrderValue { set; get; }
        [JsonProperty("ucash_order_value")]
        public string UcashOrderValue { set; get; }
        [JsonProperty("non_ucash_order_value")]
        public string NonUcashOrderValue { set; get; }
        [JsonProperty("pending_earning")]
        public string PendingEarning { set; get; }
        [JsonProperty("cancelled_earning")]
        public string CancelledEarning { set; get; }
        [JsonProperty("to_be_realized_earning")]
        public string ToBeRealizedEarning { set; get; }
        [JsonProperty("realized_earning")]
        public string RealizedEarning { set; get; }
        [JsonProperty("ucash_charge")]
        public string UcashCharge { set; get; }
        [JsonProperty("ucash_charge_reason")]
        public string UcashChargeReason { set; get; }
    }
}
