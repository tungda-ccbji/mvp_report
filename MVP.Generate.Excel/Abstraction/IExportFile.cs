using MVP.Generate.Excel.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVP.Generate.Excel.Abstraction
{
    public interface IExportFile
    {
        string ExportSaleTracking(SaleTrackingInput input);
        string ExportCorporateWallet(CorporateWalletInput input);
    }
}
