using Microsoft.AspNetCore.Mvc;

namespace Dotnet_Portfolio.ViewComponents
{
    public class _StatisticComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
