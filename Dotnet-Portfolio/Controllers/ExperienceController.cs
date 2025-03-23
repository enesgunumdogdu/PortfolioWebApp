using System.Net.Mime;
using Dotnet_Portfolio.DAL.Context;
using Dotnet_Portfolio.DAL.Entities;
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

        [HttpGet]
        public IActionResult CreateExperience()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateExperience(Experience experience)
        {
            context.Experinces.Add(experience);
            context.SaveChanges();
            return RedirectToAction("ExperienceList");
        }

        public IActionResult DeleteExperience(int id)
        {
            var value = context.Experinces.Find(id);
            context.Experinces.Remove(value);
            context.SaveChanges();
            return RedirectToAction("ExperienceList");
        }
    }
}
