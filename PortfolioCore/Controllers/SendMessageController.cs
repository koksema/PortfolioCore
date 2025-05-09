using Microsoft.AspNetCore.Mvc;
using PortfolioCore.Context;
using PortfolioCore.Entities;

namespace PortfolioCore.Controllers
{
	public class SendMessageController : Controller
	{
		PortfolioContext context = new PortfolioContext();
		[HttpPost]
		public IActionResult SendMessage(Message message)
		{
			context.messages.Add(message);
			context.SaveChanges();
			ViewBag.Success = "mesaj başarıyla gönderildi";
			return View("~/Views/Default/Index.cshtml");
		}
	}
}
