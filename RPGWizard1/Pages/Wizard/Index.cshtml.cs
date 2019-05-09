using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RPGWizard1.Data;

namespace RPGWizard1.Pages.Wizard
{
    public class IndexModel : PageModel
    {
        private readonly RPGWizardContext _context;

        public IndexModel(RPGWizardContext context)
        {
            _context = context;
        }

        public async Task OnGetAsync()
        {
            
        }

    }
}
