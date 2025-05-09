using Microsoft.AspNetCore.Mvc;
using PortfolioCore.Context;
using PortfolioCore.Entities;

namespace PortfolioCore.Controllers
{
	public class TestimonialController : Controller
	{
		PortfolioContext context = new PortfolioContext();
		public IActionResult TestimonialList()
		{
			var value = context.testimonials.ToList();
			return View(value);
		}
		[HttpGet]
		public IActionResult CreateTestimonial()
		{
			return View();
		}
		[HttpPost]
		public IActionResult CreateTestimonial(Testimonial testimonial)
		{
			context.testimonials.Add(testimonial);
			context.SaveChanges();
			return RedirectToAction("TestimonialList");
		}
		public IActionResult DeleteTestimonial(int id)
		{
			var value = context.testimonials.Find(id);
			context.testimonials.Remove(value);
			context.SaveChanges();
			return RedirectToAction("TestimonialList");
		}
		[HttpGet]
		public IActionResult UpdateTestimonial(int id)
		{
			var value = context.testimonials.Find(id);
			return View(value);
		}
		[HttpPost]
		public IActionResult UpdateTestimonial(Testimonial testimonial)
		{
			context.testimonials.Update(testimonial);
			context.SaveChanges();
			return RedirectToAction("TestimonialList");
		}
	}
}
