﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Portfolio.Pages
{
	public class ResumeModel : PageModel
    {
        private readonly ILogger<ResumeModel> _logger;


        public ResumeModel(ILogger<ResumeModel> logger)
        {
            _logger = logger;
        }
        public void OnGet()
        {
        }
    }
}
