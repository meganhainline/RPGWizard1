﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RPGWizard1.Data;
using RPGWizard1.Models;

namespace RPGWizard1.Pages.Races
{
    public class DetailsModel : PageModel
    {
        private readonly RPGWizardContext _context;

        public DetailsModel(RPGWizardContext context)
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

            Race = await _context.Races.FirstOrDefaultAsync(m => m.ID == id);

            if (Race == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
