﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVP.Generate.Excel.Entities
{
    public class ProcessingFeeTrackingInput
    {
        [JsonProperty("date_range")]
        public string DateRange { set; get; }
        [JsonProperty("datas")]
        public List<ProcessingFeeTracking> ProcessingFeeTracking { set; get; }
    }
    public class ProcessingFeeTracking
    {
        public string OrderNumber { set; get; }
        public string OrderDate { set; get; }
        public string CustomerID { set; get; }
        public string TypeofOrder { set; get; }
        public string Status { set; get; }
        public string StripeCard { set; get; }
        public string CorporateWallet { set; get; }
        public float Redemption { set; get; }
        public float Total { set; get; }
        public string VendorName { set; get; }
    }
}