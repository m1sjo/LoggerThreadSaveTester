using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggerThreadSaveTester
{


    public  class SomeLoggingClass
    {
        private ILogger<SomeLoggingClass> _logger;

        public SomeLoggingClass(ILogger<SomeLoggingClass> logger)
        {
            _logger = logger;
        }

        public async Task LogOtherStuffFiveTimes()
        {
            for (int i = 0; i < 5; i++)
            {
                _logger.LogError($"some stuff {i}");
                await Task.Delay(5);
            }
        }
    }
}
