using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RPGWizard1.Data;
using RPGWizard1.Data.Models;

namespace RPGWizard1.Pages
{
    public class SubRacesModel : PageModel
    {
        private readonly RPGWizard1.Data.RPGWizardContext _context;

        public SubRacesModel(RPGWizard1.Data.RPGWizardContext context)
        {
            _context = context;
        }

        public IList<SubRace> SubRaces { get;set; }

        public async Task OnGetAsync(int race)
        {
            SubRaces = await _context.SubRaces.Where(x=> x.Race_ID==race).ToListAsync(); //This is the changed line that passes in Race_ID information and fixed the link from Race to correct subrace page
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            return null;
        }
    }
}
