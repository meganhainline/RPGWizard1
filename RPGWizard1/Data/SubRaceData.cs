using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using RPGWizard1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RPGWizard1.Data
{
    public static class SubRaceData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new RPGWizardContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<RPGWizardContext>>()))
            {
                // Look for any subraces.
                if (context.SubRaces.Any())
                {
                    return;   // DB has been seeded
                }

                context.Races.AddRange(
                    new SubRace
                    {
                        Name = "Human",
                        Traits = "Adaptable and Ambitious"

                    },

                    new SubRace
                    {
                        Name = "Elf",
                        Traits = "Artistic and Optimistic"

                    },

                    new SubRace
                    {
                        Name = "Dwarf",
                        Traits = "Traditional and Industrious"
                    },

                    new SubRace
                    {
                        Name = "Halfling",
                        Traits = "Cheerful and Affable"
                    },

                    new SubRace
                    {
                        Name = "Gnome",
                        Traits = "Curious and Impulsive"
                    },

                    new SubRace
                    {
                        Name = "Half-Orc",
                        Traits = "Adaptable and Self-Conscious"
                    },

                    new SubRace
                    {
                        Name = "Half-Giant",
                        Traits = "Tough and Strong, but not too Nimble"
                    }
                    );
                context.SaveChanges();
            }
        }
    }
}*/
