using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RPGWizard1.Models;

namespace RPGWizard1.Pages.Races
{
    public class IndexModel : PageModel
    {
        private readonly RPGWizard1.Models.RPGWizard1Context _context;

        public IndexModel(RPGWizard1.Models.RPGWizard1Context context)
        {
            _context = context;
        }

        public IList<Race> Race { get;set; }

        public async Task OnGetAsync()
        {
            Race = await _context.Race.ToListAsync();
        }
    }
}
