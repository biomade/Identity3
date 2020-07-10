using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Identity3.Pages.Special
{
    [Authorize(Roles = "Administrator")]
    public class IndexModel : PageModel
    {
        
        
        public IndexModel()
        {
            //var inRole = User.IsInRole("Administrator");
            //This is null because the Principle user has not been created
        }
        public void OnGet()
        {
            
        }
    }
}