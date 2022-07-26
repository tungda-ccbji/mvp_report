using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVP.Generate.Excel.Abstraction
{
    public interface ILogService
    {
        /// <summary>
        /// Log Warning
        /// </summary>
        /// <param name="message"></param>
        /// <param name="ex"></param>
        public void Warning(string message, Exception ex = null);
        /// <summary>
        /// Log Error
        /// </summary>
        /// <param name="message"></param>
        /// <param name="ex"></param>
        public void Error(string message, Exception ex = null);
        /// <summary>
        /// Log Info
        /// </summary>
        /// <param name="message"></param>
        /// <param name="ex"></param>
        public void Info(string message, Exception ex = null);
        /// <summary>
        /// Log exception that may cause the whole system down
        /// </summary>
        /// <param name="message"></param>
        /// <param name="ex"></param>
        public void Fatal(string message, Exception ex = null);
    }
}
