using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Logging.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            /*Logging levels
             * 
            _logger.LogTrace("This is Trace Log");// used for heavy debugging. Really detailed view on whats going on. may have application secrets
            _logger.LogDebug("This is debug log"); // Still used for debugging. heavy information. may provide details on values for variables ect.
            _logger.LogInformation("This is our first log message"); // Keep in logs. Flow of application being used. This step to this step ect.
            _logger.LogWarning("This is warning log");// Have issue. throw exception that you caught. 
            _logger.LogError("this is debug log");// Exception that may crash part of application. Unhandled and unexpected. Ex. database not available temporarily. 
            _logger.LogCritical("this is critical Log");//Application is crashing. Loosing data, server out of disk space ect. 

            // The two most used are Loginformation and log warning. 
            */
            _logger.LogError("Server went down temporarily at {time}", DateTime.UtcNow);
        }
    }
}
