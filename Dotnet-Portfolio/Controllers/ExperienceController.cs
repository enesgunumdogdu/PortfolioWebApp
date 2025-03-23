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

        [HttpGet]
        public IActionResult UpdateExperience(int id)
        {
            var value = context.Experinces.Find(id);
            return View("UpdateExperience", value);
        }

        [HttpPost]
        public IActionResult UpdateExperience(Experience experience)
        {
            //var value = context.Experinces.Find(experience.ExperienceId);
            //value.Head = experience.Head;
            //value.Title = experience.Title;
            //value.Date = experience.Date;
            //value.Description = experience.Description;
            //context.SaveChanges();
            //return RedirectToAction("ExperienceList");
            context.Experinces.Update(experience);
            context.SaveChanges();
            return RedirectToAction("ExperienceList");
        }
    }
}
