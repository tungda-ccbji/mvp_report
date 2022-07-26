using log4net;
using Microsoft.Extensions.Logging;
using MVP.Generate.Excel.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVP.Generate.Excel.Implementation
{
    public class DefaultLogService : ILogService
    {
        private ILog _log;
        private readonly ILogger<DefaultLogService> _logger;

        public DefaultLogService(ILogger<DefaultLogService> logger)
        {
            _log = LogManager.GetLogger(typeof(DefaultLogService));
            _logger = logger;
        }

        public void Error(string message, Exception ex = null)
        {
            message = PrepareMessage(message, ex);
            _log.Error(message, ex);
            _logger.LogError(message, ex);
        }

        public void Fatal(string message, Exception ex = null)
        {
            message = PrepareMessage(message, ex);
            _log.Fatal(message, ex);
            _logger.LogCritical(message, ex);
        }

        public void Info(string message, Exception ex = null)
        {
            message = PrepareMessage(message, ex);
            _log.Info(message, ex);
            _logger.LogInformation(message, ex);
        }

        public void Warning(string message, Exception ex = null)
        {
            message = PrepareMessage(message, ex);
            _log.Warn(message, ex);
            _logger.LogWarning(message, ex);
        }

        private string PrepareMessage(string message, Exception ex = null)
        {
            if (ex == null)
            {
                return message;
            }

            message += $"{ex.Message}\n{ex.StackTrace}";
            while (ex.InnerException != null)
            {
                ex = ex.InnerException;
                message += $"{ex.Message}\n{ex.StackTrace}";
            }

            return message;
        }
    }

}
