using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace MVP.Generate.Excel.Entities
{
    public class CorporateWalletInput : DateRangeInput
    {
        [JsonProperty("data")]
        public List<CorporateWallet> CorporateWallets { set; get; }
    }
    public class CorporateWallet
    {
        [JsonProperty("date")]
        public string Date { set; get; }
        [JsonProperty("horeca")]
        public string HorecaA { set; get; }
        [JsonProperty("max_credit")]
        public string MaximumCredit { set; get; }
        [JsonProperty("available_credit")]
        public string AvailableCredit { set; get; }
        [JsonProperty("order_number")]
        public string DebitOrderNumber { set; get; }
        [JsonProperty("status")]
        public string Status { set; get; }
        [JsonProperty("total_order_value")]
        public string TotalOrderValue { set; get; }
        [JsonProperty("wallet_order_value")]
        public string WalletOrderValue { set; get; }
        [JsonProperty("non_wallet_order_value")]
        public string NonWalletOrderValue { set; get; }
        [JsonProperty("refund_value")]
        public string RefundValue { set; get; }
        [JsonProperty("refund_reason")]
        public string RefundReason { set; get; }
        [JsonProperty("credit_charge")]
        public string CreditCharge { set; get; }
        [JsonProperty("charge_back_reason")]
        public string ChargeBackReason { set; get; }
    }
}
