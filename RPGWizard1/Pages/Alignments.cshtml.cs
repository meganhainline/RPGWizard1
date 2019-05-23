using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RPGWizard1.Data;
using RPGWizard1.Models;

namespace RPGWizard1.Pages
{
    public class AlignmentsModel : PageModel
    {
        private readonly RPGWizard1.Data.RPGWizardContext _context;

        public AlignmentsModel(RPGWizard1.Data.RPGWizardContext context)
        {
            _context = context;
        }

        public IList<Alignment> Alignment { get;set; }

        public async Task OnGetAsync()
        {
            Alignment = await _context.bAlignments.ToListAsync();
        }
    }
}
