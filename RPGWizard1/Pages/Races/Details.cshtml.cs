﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RPGWizard1.Models;

namespace RPGWizard1.Pages.Races
{
    public class DetailsModel : PageModel
    {
        private readonly RPGWizard1.Models.RPGWizard1Context _context;

        public DetailsModel(RPGWizard1.Models.RPGWizard1Context context)
        {
            _context = context;
        }

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
    }
}
