﻿using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.metalitec.project.Services.Logger
{
    public class LoggerManager : ILoggerManager
    {
        private static readonly NLog.ILogger _logger = LogManager.GetCurrentClassLogger();

        public LoggerManager() { }

        public void LogDebug(string message)
        {
            _logger.Debug(message);
        }

        public void LogError(string message)
        {
            _logger.Error(message);
        }

        public void LogInfo(string message)
        {
            _logger.Info(message);
        }

        public void LogWarn(string message)
        {
            _logger.Warn(message);
        }
    }
}
