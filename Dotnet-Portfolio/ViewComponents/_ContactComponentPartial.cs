using Microsoft.AspNetCore.Mvc;

namespace Dotnet_Portfolio.ViewComponents
{
    public class _ContactComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
