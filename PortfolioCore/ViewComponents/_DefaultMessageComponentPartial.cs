using Microsoft.AspNetCore.Mvc;
using PortfolioCore.Context;
using PortfolioCore.Entities;

namespace PortfolioCore.ViewComponents
{
	public class _DefaultMessageComponentPartial:ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View(new Message());
		}
	}
}
