using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RPGWizard1.Data;
using RPGWizard1.Models;

namespace RPGWizard1.Pages.Classes
{
    public class IndexModel : PageModel
    {
        private readonly RPGWizardContext _context;

        public IndexModel(RPGWizardContext context)
        {
            _context = context;
        }

        public IList<Class> Classes { get; set; }
        [BindProperty(SupportsGet = true)]
        public int myRace { get; set; }
        [BindProperty(SupportsGet = true)]
        public int myClass { get; set; }

        private void Page_Load(object sender, EventArgs e)
        {

        }

        public async Task OnGetAsync()
        {
            Classes = await _context.Classes.ToListAsync();
            //ViewData["Race"] = Request.Form["Race"];    this is wrong and breaks things
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
