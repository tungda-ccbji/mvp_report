using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVP.Generate.Excel.Entities
{
    public class SubcriptionTrackingInput
    {
        public string DateRange { set; get; }
        public List<SubcriptionTracking> SubcriptionTrackings { set; get; }
    }
    public class SubcriptionTracking
    {
        public SubcriptionTracking()
        {
            Volume = new Volume();
            NSR = new NSR();
            Promotions = new Promotions();
            Vendor = new Vendor();
            UcashPointsEarning = new UcashPointsEarning();
        }
        public string OrderNumber { set; get; }
        public string OrderDate { set; get; }
        public string TypeOrder { set; get; }
        public string FirstDeliveryDate { set; get; }
        public string LastDeliveryDate { set; get; }
        public string Frequency { set; get; }
        public int RemainingDeliveries { set; get; }
        public string Status { set; get; }
        public int CancelledAtDelivery { set; get; }
        public string CancellationDate { set; get; }
        public float CancellationFee { set; get; }
        public string ProductName { set; get; }
        public string ProductSKUID { set; get; }
        public string Category { set; get; }
        public string SubCategory { set; get; }
        public string CustomerID { set; get; }
        public Volume Volume { set; get; }
        public NSR NSR { set; get; }
        public Promotions Promotions { set; get; }
        public Vendor Vendor { set; get; }
        public UcashPointsEarning UcashPointsEarning { set; get; }
    }
}
