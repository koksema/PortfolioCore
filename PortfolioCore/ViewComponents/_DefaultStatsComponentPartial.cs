using System.Security.Cryptography;
using Microsoft.AspNetCore.Mvc;
using PortfolioCore.Context;

namespace PortfolioCore.Models
{
	public class _DefaultStatsComponentPartial : ViewComponent
	{
		PortfolioContext context = new PortfolioContext();
		public IViewComponentResult Invoke()
		{
			ViewBag.v0 = context.testimonials.Count();
			ViewBag.v1 = context.portfolios.Count();
			ViewBag.v2 = context.skills.Count();
			Random rd = new Random();
			int RdNumber = rd.Next(10, 21);
			ViewBag.v3 = RdNumber;
			return View();
		}
	}
}
