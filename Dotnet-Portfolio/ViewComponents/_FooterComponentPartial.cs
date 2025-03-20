using Microsoft.AspNetCore.Mvc;

namespace Dotnet_Portfolio.ViewComponents
{
    public class _FooterComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
