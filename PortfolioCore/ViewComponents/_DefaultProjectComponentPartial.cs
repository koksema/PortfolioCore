using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PortfolioCore.Context;
using PortfolioCore.Entities;
using Newtonsoft.Json.Linq;


namespace PortfolioCore.ViewComponents
{
	public class _DefaultProjectComponentPartial : ViewComponent
	{
		PortfolioContext context = new PortfolioContext();
		public IViewComponentResult Invoke()
		{
			var values = context.portfolios.ToList();
			return View(values);
		}
	}
}
//