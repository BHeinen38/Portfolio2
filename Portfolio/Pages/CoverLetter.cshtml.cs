using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Portfolio.Pages
{
	public class CoverLetterModel : PageModel
    {
        private readonly ILogger<CoverLetterModel> _logger;


        public CoverLetterModel(ILogger<CoverLetterModel> logger)
        {
            _logger = logger;
        }
        public void OnGet()
        {
        }
    }
}
