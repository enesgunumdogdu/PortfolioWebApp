﻿using Dotnet_Portfolio.DAL.Context;
using Microsoft.AspNetCore.Mvc;

namespace Dotnet_Portfolio.Controllers
{
    public class StatisticController : Controller
    {
        MyPortfolioContext context = new MyPortfolioContext();

        public IActionResult Index()
        {
            ViewBag.v1 = context.Skills.Count();
            ViewBag.v2 = context.Messages.Count();
            ViewBag.v3 = context.Messages.Where(x=> x.isRead == false).Count();
            ViewBag.v4 = context.Messages.Where(x=> x.isRead == true).Count();
            return View();
        }
    }
}
