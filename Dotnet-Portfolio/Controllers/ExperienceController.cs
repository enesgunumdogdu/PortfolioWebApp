using System.Net.Mime;
using Dotnet_Portfolio.DAL.Context;
using Microsoft.AspNetCore.Mvc;

namespace Dotnet_Portfolio.Controllers
{
    public class ExperienceController : Controller
    {
        MyPortfolioContext context = new MyPortfolioContext();
        public IActionResult ExperienceList()
        {
            var values = context.Experinces.ToList();
            return View(values);
        }
    }
}
