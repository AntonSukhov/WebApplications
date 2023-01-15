using RM.WebApp.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RM.WebApp.Pages.WorkTypeDirectory
{
    [Authorize(Policy = Constants.CanAccessToWorkTypeDirectoryPolicy)]
    public class WorkTypesModel : PageModel
    {
        public void OnGet()
        {
        }
    }
}
