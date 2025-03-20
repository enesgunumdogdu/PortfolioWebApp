using Microsoft.AspNetCore.Mvc;

namespace Dotnet_Portfolio.Controllers
{
    public class LayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
