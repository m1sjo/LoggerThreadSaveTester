using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggerThreadSaveTester
{
    public class OtherLoggingClass
    {
        private ILogger<OtherLoggingClass> _logger;

        public OtherLoggingClass(ILogger<OtherLoggingClass> logger)
        {
            _logger = logger;
        }

        public async Task LogOtherStuffFiveTimes()
        {
            for (int i = 0; i < 5; i++)
            {
                _logger.LogInformation($"other stuff {i}");
                await Task.Delay(5);
            }
        }
    }
}
