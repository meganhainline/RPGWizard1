using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RPGWizard1.Models;

namespace RPGWizard1.Pages.Races
{
    public class EditModel : PageModel
    {
        private readonly RPGWizard1.Models.RPGWizard1Context _context;

        public EditModel(RPGWizard1.Models.RPGWizard1Context context)
        {
            _context = context;
        }

        [BindProperty]
        public Race Race { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Race = await _context.Race.FirstOrDefaultAsync(m => m.ID == id);

            if (Race == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Race).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RaceExists(Race.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool RaceExists(int id)
        {
            return _context.Race.Any(e => e.ID == id);
        }
    }
}
