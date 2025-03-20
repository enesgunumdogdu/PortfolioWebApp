using Dotnet_Portfolio.DAL.Context;
using Microsoft.AspNetCore.Mvc;

namespace Dotnet_Portfolio.ViewComponents
{
    public class _SkillComponentPartial :ViewComponent
    {
        MyPortfolioContext context = new MyPortfolioContext();
        public IViewComponentResult Invoke()
        {
            var values = context.Skills.ToList();
            return View(values);
        }
    }
}
