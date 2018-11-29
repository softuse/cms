using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mvc_cms_first.Models
{
    public class LoggerUser
    {
        private readonly Logger _logger;

        public LoggerUser(IOptions<Logger> option)
        {
            _logger = option.Value;
        }
    }
}
