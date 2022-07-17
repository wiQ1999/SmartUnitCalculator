using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace SmartUnitCalculator.Pages.Shared
{
    [Authorize]
    public class UserModel : PageModel
    {
        public void OnGet()
        {
        }
    }
}
