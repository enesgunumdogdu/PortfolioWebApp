using Dotnet_Portfolio.DAL.Context;
using Microsoft.AspNetCore.Mvc;

namespace Dotnet_Portfolio.ViewComponents
{
    public class _ExperienceComponentPartial : ViewComponent
    {
        MyPortfolioContext context = new MyPortfolioContext();
        public IViewComponentResult Invoke()
        {
            var values = context.Experinces.ToList();
            return View(values);
        }
    }
}
