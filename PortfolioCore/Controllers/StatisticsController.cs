using Microsoft.AspNetCore.Mvc;
using PortfolioCore.Context;

namespace PortfolioCore.Controllers
{
    public class StatisticsController : Controller
    {
        PortfolioContext context = new PortfolioContext();
        public IActionResult Index()
        {
            ViewBag.v0 = "İstatistikler";
            ViewBag.v1 = context.skills.Count();
            ViewBag.v2 = context.skills.Sum(x => x.SkillValue);
            ViewBag.v3 = context.skills.Where(x => x.SkillValue >= 70).Count();
            ViewBag.v4 = context.skills.Average(x => x.SkillValue);
            ViewBag.v5 = context.experiences.Count();
            ViewBag.v6 = context.experiences.Where(x => x.SubTitle == "Developer").Count();
            ViewBag.v7 = context.messages.Where(x => x.IsRead == true).Count();
            ViewBag.v8 = context.messages.Where(x => x.IsRead == false).Count();
            ViewBag.v9 = context.Services.Count();
            ViewBag.v10 = context.SocialMedias.Count();
            return View();
        }
    }
}
//Lambda--Linq(x=>...)