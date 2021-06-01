using System;
using Microsoft.Extensions.Logging;
namespace logginglib
{
    public class Logger
    {

        private readonly ILogger<Logger> _logger;
public Logger(ILogger<Logger> logger = null)
{
            _logger = logger;
        }

        public void DebugLog(string message){
            _logger?.LogDebug(message);
        }
        public void InfoLog(string message)
        {
            _logger?.LogInformation(message);
        }
        public void WarnLog(string message)
        {
            _logger?.LogWarning(message);
        }
        public void ErrorLog(string message)
        {
            _logger?.LogError(message);
        }
        public void CriticalLog(string message)
        {
            _logger?.LogCritical(message);
        }
        public void TraceLog(string message)
        {
            _logger?.LogTrace(message);
        }
    }
}
