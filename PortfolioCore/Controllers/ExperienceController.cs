using Microsoft.AspNetCore.Mvc;
using PortfolioCore.Context;
using PortfolioCore.Entities;

namespace PortfolioCore.Controllers
{
    public class ExperienceController : Controller
    {
        PortfolioContext context = new PortfolioContext();
        public IActionResult ExperienceList()
        {
            var values = context.experiences.ToList();
            return View(values);
        }
        [HttpGet]
        public IActionResult CreateExperience()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateExperience(Experience p)
        {
            context.experiences.Add(p);
            context.SaveChanges();
            return RedirectToAction("ExperienceList");
        }
        public IActionResult DeleteExperience(int id)
        {
            var value=context.experiences.Find(id);
            context.experiences.Remove(value);
            context.SaveChanges();
            return RedirectToAction("ExperienceList");
        }
        [HttpGet]
        public IActionResult UpdateExperience(int id)
        {
            var value = context.experiences.Find(id);
            return View(value);
        }
        [HttpPost]
        public IActionResult UpdateExperience(Experience p)
        {
            context.experiences.Update(p);
            context.SaveChanges();
            return RedirectToAction("ExperienceList");
        }
    }
}
