using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using RPGWizard1.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace RPGWizard1.Data
{
    public static class RaceData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new RPGWizardContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<RPGWizardContext>>()))
            {
                // Look for any races.
                if (!(context.Races.Any()))
                {
                    //if no data is found, use these hard=coded values

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
                            Name = "Tiefling",
                            Traits = "Self-Reliant and Suspicious"
                        }
                    );
                }

                // Look for any classes.
                if (!(context.Classes.Any()))
                {
                    //if we don't find class already, use these values
                    context.Classes.AddRange(
                        new Class
                        {
                            Name = "Barbarian",
                            Description = "Fierce, Primative Warrior"

                        },

                        new Class
                        {
                            Name = "Bard",
                            Description = "Musical, Inspiring Magician"

                        },

                        new Class
                        {
                            Name = "Cleric",
                            Description = "Priest-like Divine Magic Caster, serves a Higher Power"
                        },

                        new Class
                        {
                            Name = "Druid",
                            Description = "Power of Nature Magic Caster, can Take Animal Form"
                        },

                        new Class
                        {
                            Name = "Fighter",
                            Description = "Master of Weapons, Armor, and Martial Arts"
                        },

                        new Class
                        {
                            Name = "Monk",
                            Description = "Martial Arts Master, Seeking Physical and Spiritual Perfection"
                        },

                        new Class
                        {
                            Name = "Paladin",
                            Description = "Holy Warrior"
                        },

                        new Class
                        {
                            Name = "Ranger",
                            Description = "Warrior who uses Physical Prowess and Nature Magic"
                        },

                        new Class
                        {
                            Name = "Rogue",
                            Description = "Scoundrel who uses Stealth and Trickery"
                        },

                        new Class
                        {
                            Name = "Sorcerer",
                            Description = "Inherent Magic Spellcaster"
                        },

                        new Class
                        {
                            Name = "Warlock",
                            Description = "Cast Spells via a Dark Bargain"
                        },

                        new Class
                        {
                            Name = "Wizard",
                            Description = "Scholarly Magic User"
                        }

                        );
                    
                }
                context.SaveChanges();
            }
        }
    }
}

