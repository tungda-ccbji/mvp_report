using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVP.Generate.Excel.Entities
{
    public class CorporateWalletInput
    {
        public string DateRange { set; get; }
        public string StartDate { set; get; }
        public string EndDate { set; get; }
        public List<CorporateWallet> CorporateWallets { set; get; }
    }
    public class CorporateWallet
    {
        public string Date { set; get; }
        public string HorecaA { set; get; }
        public float MaximumCredit { set; get; }
        public float AvailableCredit { set; get; }
        public string DebitOrderNumber { set; get; }
        public string Status { set; get; }
        public float TotalOrderValue { set; get; }
        public float WalletOrderValue { set; get; }
        public float NonWalletOrderValue { set; get; }
        public float RefundValue { set; get; }
        public string RefundReason { set; get; }
        public float CreditCharge { set; get; }
        public string ChargeBackReason { set; get; }
    }
}
