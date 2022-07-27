using ClosedXML.Report;
using MVP.Generate.Excel.Abstraction;
using MVP.Generate.Excel.Entities;
using System;
using System.Globalization;

namespace MVP.Generate.Excel.Implementation
{
    public class ExportFile : IExportFile
    {
        public ILogService _logService;
        public ExportFile(ILogService logService)
        {
            _logService = logService;
        }

        public string ExportCorporateWallet(CorporateWalletInput input)
        {
            try
            {
                var template = new XLTemplate(AppDomain.CurrentDomain.BaseDirectory + "Template/Corporate_Wallet.xlsx");
                template.AddVariable(input);
                template.Generate();
                var fileName = $"CorporateWalletData_{DateTime.UtcNow:yyyyMMddHHmmss}.xlsx";
                template.SaveAs(AppDomain.CurrentDomain.BaseDirectory + fileName);
                return fileName;
            }
            catch (Exception ex)
            {
                _logService.Error($"Exception when calling ExportCorporateWallet {ex.Message}", ex);
            }
            return string.Empty;
        }

        public string ExportProcessingFeeTracking(ProcessingFeeTrackingInput input)
        {
            try
            {
                var template = new XLTemplate(AppDomain.CurrentDomain.BaseDirectory + "Template/Processing_Fee_Tracking.xlsx");
                template.AddVariable(input);
                template.Generate();
                var fileName = $"ProcessingFeeTrackingData_{DateTime.UtcNow:yyyyMMddHHmmss}.xlsx";
                template.SaveAs(AppDomain.CurrentDomain.BaseDirectory + fileName);
                return fileName;
            }
            catch (Exception ex)
            {
                _logService.Error($"Exception when calling ExportSubcriptionTracking {ex.Message}", ex);
            }
            return string.Empty;
        }

        public string ExportSaleTracking(SaleTrackingInput input)
        {
            try
            {
                var template = new XLTemplate(AppDomain.CurrentDomain.BaseDirectory + "Template/Sale_Tracking.xlsx");
                template.AddVariable(input);
                template.Generate();
                var fileName = $"SaleTrackingData_{DateTime.UtcNow:yyyyMMddHHmmss}.xlsx";
                template.SaveAs(AppDomain.CurrentDomain.BaseDirectory + fileName);
                return fileName;
            }
            catch (Exception ex)
            {
                _logService.Error($"Exception when calling ExportSaleTracking {ex.Message}", ex);
            }
            return string.Empty;
        }

        public string ExportSubcriptionTracking(SubcriptionTrackingInput input)
        {
            try
            {
                var template = new XLTemplate(AppDomain.CurrentDomain.BaseDirectory + "Template/Subcription_Tracking.xlsx");
                template.AddVariable(input);
                template.Generate();
                var fileName = $"SubcriptionTrackingData_{DateTime.UtcNow:yyyyMMddHHmmss}.xlsx";
                template.SaveAs(AppDomain.CurrentDomain.BaseDirectory + fileName);
                return fileName;
            }
            catch (Exception ex)
            {
                _logService.Error($"Exception when calling ExportSubcriptionTracking {ex.Message}", ex);
            }
            return string.Empty;
        }

        public string ExportUcashPoints(UcashPointInput input)
        {
            try
            {
                var template = new XLTemplate(AppDomain.CurrentDomain.BaseDirectory + "Template/UCash_Point.xlsx");
                template.AddVariable(input);
                template.Generate();
                var fileName = $"UcashPointsData_{DateTime.UtcNow:yyyyMMddHHmmss}.xlsx";
                template.SaveAs(AppDomain.CurrentDomain.BaseDirectory + fileName);
                return fileName;
            }
            catch (Exception ex)
            {
                _logService.Error($"Exception when calling ExportUcashPoints {ex.Message}", ex);
            }
            return string.Empty;
        }
    }
}
