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
                var culture = new CultureInfo("ja-JP", false);
                DateTime.TryParseExact(input.StartDate, "yyyy/MM/dd", culture, DateTimeStyles.None, out DateTime startDate);
                DateTime.TryParseExact(input.EndDate, "yyyy/MM/dd", culture, DateTimeStyles.None, out DateTime endDate);
                input.DateRange = $"{startDate.ToString("dd日 MMMM", culture)} {(startDate.Year != endDate.Year ? startDate.Year.ToString() : string.Empty)} - {endDate.ToString("dd日 MMMM", culture)} {endDate.Year}";
                template.AddVariable(input);
                template.Generate();
                template.SaveAs(AppDomain.CurrentDomain.BaseDirectory + $"CorporateWalletData_{DateTime.UtcNow.ToString("MMddyyyy")}.xlsx");
                return $"CorporateWalletData_{DateTime.UtcNow.ToString("MMddyyyy")}.xlsx";
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
                var culture = new CultureInfo("ja-JP", false);
                DateTime.TryParseExact(input.StartDate, "yyyy/MM/dd", culture, DateTimeStyles.None, out DateTime startDate);
                DateTime.TryParseExact(input.EndDate, "yyyy/MM/dd", culture, DateTimeStyles.None, out DateTime endDate);
                input.DateRange = $"{startDate.ToString("dd日 MMMM", culture)} {(startDate.Year != endDate.Year ? startDate.Year.ToString() : string.Empty)} - {endDate.ToString("dd日 MMMM", culture)} {endDate.Year}";
                var template = new XLTemplate(AppDomain.CurrentDomain.BaseDirectory + "Template/Processing_Fee_Tracking.xlsx");
                template.AddVariable(input);
                template.Generate();
                template.SaveAs(AppDomain.CurrentDomain.BaseDirectory + $"ProcessingFeeTrackingData_{DateTime.UtcNow.ToString("MMddyyyy")}.xlsx");
                return $"ProcessingFeeTrackingData_{DateTime.UtcNow.ToString("MMddyyyy")}.xlsx";
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
                var culture = new CultureInfo("ja-JP", false);
                DateTime.TryParseExact(input.StartDate, "yyyy/MM/dd", culture, DateTimeStyles.None, out DateTime startDate);
                DateTime.TryParseExact(input.EndDate, "yyyy/MM/dd", culture, DateTimeStyles.None, out DateTime endDate);
                input.DateRange = $"{startDate.ToString("dd日 MMMM", culture)} {(startDate.Year != endDate.Year ? startDate.Year.ToString() : string.Empty)} - {endDate.ToString("dd日 MMMM", culture)} {endDate.Year}";
                template.AddVariable(input);
                template.Generate();
                template.SaveAs(AppDomain.CurrentDomain.BaseDirectory + $"SaleTrackingData_{DateTime.UtcNow.ToString("MMddyyyy")}.xlsx");
                return $"SaleTrackingData_{DateTime.UtcNow.ToString("MMddyyyy")}.xlsx";
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
                var culture = new CultureInfo("ja-JP", false);
                DateTime.TryParseExact(input.StartDate, "yyyy/MM/dd", culture, DateTimeStyles.None, out DateTime startDate);
                DateTime.TryParseExact(input.EndDate, "yyyy/MM/dd", culture, DateTimeStyles.None, out DateTime endDate);
                input.DateRange = $"{startDate.ToString("dd日 MMMM", culture)} {(startDate.Year != endDate.Year ? startDate.Year.ToString() : string.Empty)} - {endDate.ToString("dd日 MMMM", culture)} {endDate.Year}";
                template.AddVariable(input);
                template.Generate();
                template.SaveAs(AppDomain.CurrentDomain.BaseDirectory + $"SubcriptionTrackingData_{DateTime.UtcNow.ToString("MMddyyyy")}.xlsx");
                return $"SubcriptionTrackingData_{DateTime.UtcNow.ToString("MMddyyyy")}.xlsx";
            }
            catch (Exception ex)
            {
                _logService.Error($"Exception when calling ExportSubcriptionTracking {ex.Message}", ex);
            }
            return string.Empty;
        }

        public string ExportUcashPointst(UcashPointInput input)
        {
            try
            {
                var template = new XLTemplate(AppDomain.CurrentDomain.BaseDirectory + "Template/UCash_Point.xlsx");
                var culture = new CultureInfo("ja-JP", false);
                DateTime.TryParseExact(input.StartDate, "yyyy/MM/dd", culture, DateTimeStyles.None, out DateTime startDate);
                DateTime.TryParseExact(input.EndDate, "yyyy/MM/dd", culture, DateTimeStyles.None, out DateTime endDate);
                input.DateRange = $"{startDate.ToString("dd日 MMMM", culture)} {(startDate.Year != endDate.Year ? startDate.Year.ToString() : string.Empty)} - {endDate.ToString("dd日 MMMM", culture)} {endDate.Year}";
                template.AddVariable(input);
                template.Generate();
                template.SaveAs(AppDomain.CurrentDomain.BaseDirectory + $"UcashPointsData_{DateTime.UtcNow.ToString("MMddyyyy")}.xlsx");
                return $"UcashPointsData_{DateTime.UtcNow.ToString("MMddyyyy")}.xlsx";
            }
            catch (Exception ex)
            {
                _logService.Error($"Exception when calling ExportUcashPointst {ex.Message}", ex);
            }
            return string.Empty;
        }
    }
}
