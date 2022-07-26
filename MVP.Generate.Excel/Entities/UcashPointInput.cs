using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVP.Generate.Excel.Entities
{
    public class UcashPointInput
    {
        [JsonProperty("date_range")]
        public string DateRange { set; get; }
        [JsonProperty("datas")]
        public List<UcashPoint> UcashPoints { set; get; }
    }
    public class UcashPoint
    {
        public string Date { set; get; }
        public float TotalAvailableUcashPoints { set; get; }
        public float DebitOrderumber { set; get; }
        public string Status { set; get; }
        public float TotalOrderValue { set; get; }
        public float UcashOrderValue { set; get; }
        public float NonUcashOrderValue { set; get; }
        public float PendingEarning { set; get; }
        public float CancelledEarning { set; get; }
        public float ToBeRealizedEarning { set; get; }
        public float RealizedEarning { set; get; }
        public float UcashCharge { set; get; }
        public string UcashChargeReason { set; get; }
    }
}
