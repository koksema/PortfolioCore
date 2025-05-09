using Microsoft.AspNetCore.Mvc;
using PortfolioCore.Context;
using PortfolioCore.Entities;

namespace PortfolioCore.Controllers
{
    public class SkillController : Controller
    {
        PortfolioContext context=new PortfolioContext();
        public IActionResult SkillList()
        {
            var values=context.skills.ToList();
            return View(values);
        }
        [HttpGet]
        public IActionResult CreateSkill()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateSkill(Skill skill)
        {
            context.skills.Add(skill);
            context.SaveChanges();
            return RedirectToAction("SkillList");
        }

        public IActionResult DeleteSkill(int id)
        {
            var value=context.skills.Find(id);
            context.skills.Remove(value);
            context.SaveChanges();
            return RedirectToAction("SkillList");
        }
        [HttpGet]
        public IActionResult UpdateSkill(int id)
        {
            var value = context.skills.Find(id);
            return View(value);
        }
        [HttpPost]
        public IActionResult UpdateSkill(Skill skill)
        {
            context.skills.Update(skill);
            context.SaveChanges();
            return RedirectToAction("SkillList");
        }
    }
}
