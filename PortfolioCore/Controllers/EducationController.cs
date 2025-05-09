using Microsoft.AspNetCore.Mvc;
using PortfolioCore.Context;
using PortfolioCore.Entities;

namespace PortfolioCore.Controllers
{
    public class EducationController : Controller
	{
        
        PortfolioContext context = new PortfolioContext();
		public IActionResult EducationList()
		{
			var values = context.educations.ToList();
			return View(values);
		}
		[HttpGet]
		public IActionResult CreateEducation()
		{
			return View();
		}
		[HttpPost]
		public IActionResult CreateEducation(Education education)
		{
			context.educations.Add(education);
			context.SaveChanges();
			return RedirectToAction("EducationList");
		}
		public IActionResult DeleteEducation(int id)
		{
			var value = context.educations.Find(id);
			context.educations.Remove(value);
			context.SaveChanges();
			return RedirectToAction("EducationList");
		}
		[HttpGet]
		public IActionResult UpdateEducation(int id)
		{
			var value = context.educations.Find(id);
			return View(value);
		}
		[HttpPost]
		public IActionResult UpdateEducation(Education education)
		{
			context.educations.Update(education);
			context.SaveChanges();
			return RedirectToAction("EducationList");
		}
	}
}

