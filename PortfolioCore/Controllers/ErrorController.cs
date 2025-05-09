using Microsoft.AspNetCore.Mvc;

namespace PortfolioCore.Controllers
{
	public class ErrorController : Controller
	{
		public IActionResult Error()
		{
			return View();
		}
	}
}
