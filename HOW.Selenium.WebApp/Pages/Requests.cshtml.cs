using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Authorization;

namespace HOW.Selenium.WebApp.Pages
{
    [Authorize]
    public class RequestModel : PageModel
    {
        public string Title { get; set; }
        public string Body { get; set; }

        public void OnGet()
        {

        }
    }
}