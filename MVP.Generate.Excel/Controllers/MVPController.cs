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
        public async Task<IActionResult> ExportSaleTracking(SaleTrackingInput input, [FromQuery] bool returnBytes = false)
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
                var bytes = System.IO.File.ReadAllBytes(AppDomain.CurrentDomain.BaseDirectory + result);
                System.IO.File.Delete(AppDomain.CurrentDomain.BaseDirectory + result);
                if (returnBytes)
                {
                    return File(bytes, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet");
                }
                var base64 = Convert.ToBase64String(bytes);
                return Ok(new
                {
                    data = base64
                });
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
        public async Task<IActionResult> ExportCorporateWallet(CorporateWalletInput input, [FromQuery] bool returnBytes = false)
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
                var bytes = System.IO.File.ReadAllBytes(AppDomain.CurrentDomain.BaseDirectory + result);
                System.IO.File.Delete(AppDomain.CurrentDomain.BaseDirectory + result);
                if (returnBytes)
                {
                    return File(bytes, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet");
                }
                var base64 = Convert.ToBase64String(bytes);
                return Ok(new
                {
                    data = base64
                });
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
        [HttpPost]
        [HttpOptions]
        public async Task<IActionResult> ExportUCashPoints(UcashPointInput input, [FromQuery] bool returnBytes = false)
        {
            try
            {
                var result = await Task.FromResult(_exportFile.ExportUcashPoints(input));
                if (string.IsNullOrWhiteSpace(result))
                {
                    return Ok(new ResponseModel
                    {
                        ErrorMessage = "Export UCash Points Fail !"
                    });
                }
                var bytes = System.IO.File.ReadAllBytes(AppDomain.CurrentDomain.BaseDirectory + result);
                System.IO.File.Delete(AppDomain.CurrentDomain.BaseDirectory + result);
                if (returnBytes)
                {
                    return File(bytes, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet");
                }
                var base64 = Convert.ToBase64String(bytes);
                return Ok(new
                {
                    data = base64
                });
            }
            catch (Exception ex)
            {
                _logService.Error("Exception when calling ExportUCashPoints", ex);
                return Ok(new ResponseModel
                {
                    ErrorMessage = $"Exception when calling ExportUCashPoints: {ex.Message}"
                });
            }
        }
        [HttpPost]
        [HttpOptions]
        public async Task<IActionResult> ExportSubcriptionTracking(SubcriptionTrackingInput input, [FromQuery] bool returnBytes = false)
        {
            try
            {
                var result = await Task.FromResult(_exportFile.ExportSubcriptionTracking(input));
                if (string.IsNullOrWhiteSpace(result))
                {
                    return Ok(new ResponseModel
                    {
                        ErrorMessage = "Export Subcription Tracking Fail !"
                    });
                }
                var bytes = System.IO.File.ReadAllBytes(AppDomain.CurrentDomain.BaseDirectory + result);
                System.IO.File.Delete(AppDomain.CurrentDomain.BaseDirectory + result);
                if (returnBytes)
                {
                    return File(bytes, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet");
                }
                var base64 = Convert.ToBase64String(bytes);
                return Ok(new
                {
                    data = base64
                });
            }
            catch (Exception ex)
            {
                _logService.Error("Exception when calling ExportSubcriptionTracking", ex);
                return Ok(new ResponseModel
                {
                    ErrorMessage = $"Exception when calling ExportSubcriptionTracking: {ex.Message}"
                });
            }
        }
        [HttpPost]
        [HttpOptions]
        public async Task<IActionResult> ExportProcessingFeeTracking(ProcessingFeeTrackingInput input, [FromQuery] bool returnBytes = false)
        {
            try
            {
                var result = await Task.FromResult(_exportFile.ExportProcessingFeeTracking(input));
                if (string.IsNullOrWhiteSpace(result))
                {
                    return Ok(new ResponseModel
                    {
                        ErrorMessage = "Export Processing Fee Tracking Fail !"
                    });
                }
                var bytes = System.IO.File.ReadAllBytes(AppDomain.CurrentDomain.BaseDirectory + result);
                System.IO.File.Delete(AppDomain.CurrentDomain.BaseDirectory + result);
                if (returnBytes)
                {
                    return File(bytes, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet");
                }
                var base64 = Convert.ToBase64String(bytes);
                return Ok(new
                {
                    data = base64
                });
            }
            catch (Exception ex)
            {
                _logService.Error("Exception when calling ExportProcessingFeeTracking", ex);
                return Ok(new ResponseModel
                {
                    ErrorMessage = $"Exception when calling ExportProcessingFeeTracking: {ex.Message}"
                });
            }
        }

    }
}
