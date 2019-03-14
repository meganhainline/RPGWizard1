using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RPGWizard1.Data;
using RPGWizard1.Models;

namespace RPGWizard1.Pages.Wizard
{
    public class IndexModel : PageModel
    {
        private readonly RPGWizardContext _context;

        public IndexModel(RPGWizardContext context)
        {
            _context = context;
        }

        public async Task OnGetAsync()
        {
            
        }

    }
}
