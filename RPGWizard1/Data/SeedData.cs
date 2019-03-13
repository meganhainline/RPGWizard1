using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using RPGWizard1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RPGWizard1.Data
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new RPGWizardContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<RPGWizardContext>>()))
            {
                // Look for any races.
                if (context.Races.Any())
                {
                    return;   // DB has been seeded
                }

                context.Races.AddRange(
                    new Race
                    {
                        Name = "Human",
                        Traits = "Adaptable and Ambitious"
                        
                    },

                    new Race
                    {
                        Name = "Elf",
                        Traits = "Artistic and Optimistic"

                    },

                    new Race
                    {
                        Name = "Dwarf",
                        Traits = "Traditional and Industrious"
                    },

                    new Race
                    {
                        Name = "Halfling",
                        Traits = "Cheerful and Affable"
                    },

                    new Race
                    {
                        Name = "Gnome",
                        Traits = "Curious and Impulsive"
                    },

                    new Race
                    {
                        Name = "Half-Orc",
                        Traits = "Adaptable and Self-Conscious"
                    },

                    new Race
                    {
                        Name = "Half-Giant",
                        Traits = "Tough and Strong, but not too Nimble"
                    }
                    );
                context.SaveChanges();
            }
        }
    }
}

