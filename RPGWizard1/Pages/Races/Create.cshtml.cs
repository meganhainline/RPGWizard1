using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using RPGWizard1.Models;

namespace RPGWizard1.Pages.Races
{
    public class CreateModel : PageModel
    {
        private readonly RPGWizard1.Models.RPGWizard1Context _context;

        public CreateModel(RPGWizard1.Models.RPGWizard1Context context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Race Race { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Race.Add(Race);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}