using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using RPGWizard1.Data.Models;
using RPGWizard1.Models;

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
        public DbSet<RPGWizard1.Data.Models.SubRace> SubRaces { get; set; }
        public DbSet<RPGWizard1.Models.Background> Backgrounds { get; set; }
        public DbSet<RPGWizard1.Models.Alignment> bAlignments { get; set; }
    }
}
