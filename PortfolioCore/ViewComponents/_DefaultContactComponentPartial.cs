using Microsoft.AspNetCore.Mvc;
using PortfolioCore.Context;

namespace PortfolioCore.ViewComponents
{
	public class _DefaultContactComponentPartial:ViewComponent
	{
		PortfolioContext context = new PortfolioContext();
		public IViewComponentResult Invoke()
		{
			var values = context.contacts.ToList();
			return View(values);
		}
	}
}
