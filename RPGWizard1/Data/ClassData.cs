using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using RPGWizard1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RPGWizard1.Data
{
    public class ClassData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new RPGWizardContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<RPGWizardContext>>()))
            {
                // Look for any classes.
                if (context.Classes.Any())
                {
                    return;   // DB has been seeded
                }

                context.Classes.AddRange(
                    new Class
                    {
                        Name = "Barbarian",
                        Description = "Fierce, primative Warrior"

                    },

                    new Class
                    {
                        Name = "Bard",
                        Description = "Musical, inspiring Magician"

                    },

                    new Class
                    {
                        Name = "Cleric",
                        Description = "a"
                    },

                    new Class
                    {
                        Name = "Druid",
                        Description = "a"
                    },

                    new Class
                    {
                        Name = "Fighter",
                        Description = "Master of Weapons, Armor, and Martial Arts"
                    },

                    new Class
                    {
                        Name = "Monk",
                        Description = "a"
                    },

                    new Class
                    {
                        Name = "Paladin",
                        Description = "Holy Warrior"
                    },

                    new Class
                    {
                        Name = "Ranger",
                        Description = "a"
                    },

                    new Class
                    {
                        Name = "Rogue",
                        Description = "a"
                    },

                    new Class
                    {
                        Name = "Sorcerer",
                        Description = "Inherent Magic Spellcaster"
                    },

                    new Class
                    {
                        Name = "Warlock",
                        Description = "Magic powers from Outside Source"
                    },

                    new Class
                    {
                        Name = "Wizard",
                        Description = "a"
                    }

                    );
                context.SaveChanges();
            }
        }
    }
}
