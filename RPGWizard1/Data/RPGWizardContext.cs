using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace RPGWizard1.Data
{
    public class RPGWizardContext : DbContext
    {
        public RPGWizardContext (DbContextOptions<RPGWizardContext> options)
            : base(options)
        {
        }

        public DbSet<RPGWizard1.Models.Class> Classes { get; set; }
        public DbSet<RPGWizard1.Models.Race> Races { get; set; }
    }
}
