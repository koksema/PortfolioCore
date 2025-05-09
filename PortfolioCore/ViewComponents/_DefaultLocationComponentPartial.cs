using Microsoft.AspNetCore.Mvc;
using PortfolioCore.Context;

namespace PortfolioCore.ViewComponents
{
	public class _DefaultLocationComponentPartial:ViewComponent
	{
		PortfolioContext context = new PortfolioContext();
		public IViewComponentResult Invoke()
		{
			var value = context.contacts.ToList();
			return View(value);
		}
	}
}
