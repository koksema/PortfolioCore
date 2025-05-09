using Microsoft.AspNetCore.Mvc;
using PortfolioCore.Context;

namespace PortfolioCore.ViewComponents
{
	public class _DefaultTestimonialComponentPartial : ViewComponent
	{
		PortfolioContext context = new PortfolioContext();
		public IViewComponentResult Invoke()
		{
			var value = context.testimonials.ToList();
			return View(value);
		}
	}
}