using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Meetup.Pages
{
    public class DocumentationModel : PageModel
    {
        private readonly ILogger<DocumentationModel> _logger;

        public DocumentationModel(ILogger<DocumentationModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}
