using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using RPGWizard1.Models;
using System;
using System.Linq;

namespace RPGWizard1.Data
{
    public class ClassData //THIS PAGE NOT CURRENTLY USED AS CLASS DATA IS IN RaceData PAGE
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new RPGWizardContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<RPGWizardContext>>()))
            {
                
                context.SaveChanges();
            }
        }
    }
}
