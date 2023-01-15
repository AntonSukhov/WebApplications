using Microsoft.AspNetCore.Mvc.RazorPages;
using RM.BLL.Abstractions.Services;

namespace RM.WebApp.Pages.ModuleDirectory
{
    public class ModuleDirectoryModel : PageModel
    {
        private readonly IModuleService _moduleService;

        public ModuleDirectoryModel(IModuleService moduleService)
        {
            _moduleService = moduleService;
        }

        public void OnGet()
        {
            var modules = _moduleService.GetModules();
        }
    }
}
