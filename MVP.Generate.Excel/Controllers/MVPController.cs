using Microsoft.AspNetCore.Mvc;
using MVP.Generate.Excel.Abstraction;
using MVP.Generate.Excel.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace MVP.Generate.Excel.Controllers
{
    [Route("api/mvp/{action=Index}")]
    [ApiController]
    public class MVPController : ControllerBase
    {
        public ILogService _logService;
        private IExportFile _exportFile;
        public MVPController(ILogService logService, IExportFile exportFile)
        {
            _logService = logService;
            _exportFile = exportFile;
        }
        [HttpPost]
        [HttpOptions]
        public async Task<IActionResult> ExportSaleTracking(SaleTrackingInput input)
        {
            try
            {
                var result = await Task.FromResult(_exportFile.ExportSaleTracking(input));
                if (string.IsNullOrWhiteSpace(result))
                {
                    return Ok(new ResponseModel
                    {
                        ErrorMessage = "Export SaleTracking Fail !"
                    });
                }
                var stream = new FileStream(AppDomain.CurrentDomain.BaseDirectory + result, FileMode.Open, FileAccess.Read, FileShare.None, 5000, FileOptions.DeleteOnClose);
                Response.Headers.Add("Content-Disposition", $"inline; filename={result}");
                return File(stream, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet");
            }
            catch (Exception ex)
            {
                _logService.Error("Exception when calling ExportSaleTracking", ex);
                return Ok(new ResponseModel
                {
                    ErrorMessage = $"Exception when calling ExportSaleTracking: {ex.Message}"
                });
            }
        }
        [HttpPost]
        [HttpOptions]
        public async Task<IActionResult> ExportCorporateWallet(CorporateWalletInput input)
        {
            try
            {
                var result = await Task.FromResult(_exportFile.ExportCorporateWallet(input));
                if (string.IsNullOrWhiteSpace(result))
                {
                    return Ok(new ResponseModel
                    {
                        ErrorMessage = "Export Corporate Wallet Fail !"
                    });
                }
                var stream = new FileStream(AppDomain.CurrentDomain.BaseDirectory + result, FileMode.Open, FileAccess.Read, FileShare.None, 5000, FileOptions.DeleteOnClose);
                Response.Headers.Add("Content-Disposition", $"inline; filename={result}");
                return File(stream, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet");
            }
            catch (Exception ex)
            {
                _logService.Error("Exception when calling ExportCorporateWallet", ex);
                return Ok(new ResponseModel
                {
                    ErrorMessage = $"Exception when calling ExportCorporateWallet: {ex.Message}"
                });
            }
        }

    }
}
