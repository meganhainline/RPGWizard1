using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace RPGWizard1.Data
{
    public class RPGWizardContext : IdentityDbContext
    {
        public RPGWizardContext (DbContextOptions<RPGWizardContext> options)
            : base(options)
        {
        }

        public DbSet<RPGWizard1.Models.Class> Classes { get; set; }
        public DbSet<RPGWizard1.Models.Race> Races { get; set; }
    }
}
