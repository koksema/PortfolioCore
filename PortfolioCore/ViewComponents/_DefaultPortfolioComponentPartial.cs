using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PortfolioCore.Context;
using PortfolioCore.Entities;
using Microsoft.AspNetCore.Mvc.Rendering;
namespace PortfolioCore.ViewComponents
{
	public class _DefaultPortfolioComponentPartial : ViewComponent
	{
		PortfolioContext context = new PortfolioContext();
		public IViewComponentResult Invoke()
		{
			var values = context.portfolios.ToList();
			return View(values);
		}
		public IViewComponentResult GetProjectWithCategory(int id)
		{
			var values = context.portfolios.Include(x => x.Category).Where(x => x.CategoryId==id).ToList();
			return View(values);
		}
	}

}

