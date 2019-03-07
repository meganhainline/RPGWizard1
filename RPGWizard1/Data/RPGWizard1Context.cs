using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace RPGWizard1.Models
{
    public class RPGWizard1Context : DbContext
    {
        public RPGWizard1Context (DbContextOptions<RPGWizard1Context> options)
            : base(options)
        {
        }

        public DbSet<RPGWizard1.Models.Race> Race { get; set; }
    }
}
