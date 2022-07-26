using ClosedXML.Report;
using MVP.Generate.Excel.Abstraction;
using MVP.Generate.Excel.Entities;
using System;

namespace MVP.Generate.Excel.Implementation
{
    public class ExportFile : IExportFile
    {
        public ILogService _logService;
        public ExportFile(ILogService logService)
        {
            _logService = logService;
        }
        public string ExportSaleTracking(SaleTrackingInput input)
        {
            try
            {
                var template = new XLTemplate(AppDomain.CurrentDomain.BaseDirectory + "Template/Sale_Tracking.xlsx");
                template.AddVariable(input);
                template.Generate();
                template.SaveAs(AppDomain.CurrentDomain.BaseDirectory + $"SaleTrackingData_{DateTime.UtcNow.ToString("MMddyyyy")}.xlsx");
                return $"SaleTrackingData_{DateTime.UtcNow.ToString("MMddyyyy")}.xlsx";
            }
            catch (Exception ex)
            {
                _logService.Error($"Exception when calling ProcessFile {ex.Message}", ex);
            }
            return string.Empty;
        }
    }
}
