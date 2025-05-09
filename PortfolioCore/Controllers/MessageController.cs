using Microsoft.AspNetCore.Mvc;
using PortfolioCore.Context;

namespace PortfolioCore.Controllers
{
	public class MessageController : Controller
	{
		PortfolioContext context = new PortfolioContext();
		public IActionResult MessageList()
		{
			var values = context.messages.ToList();
			return View(values);
		}
		public IActionResult ChangeIsReadToTrue(int id)
		{
			var value = context.messages.Find(id);
			value.IsRead = true;
			context.SaveChanges();
			return RedirectToAction("MessageList");
		}
		public IActionResult ChangeIsReadToFalse(int id)
		{
			var value = context.messages.Find(id);
			value.IsRead = false;
			context.SaveChanges();
			return RedirectToAction("MessageList");
		}
		public IActionResult OpenMessage(int id)
		{
			var value = context.messages.Find(id);
			return View(value);
		}
		public IActionResult DeleteMessage(int id)
		{
			var value = context.messages.Find(id);
			context.messages.Remove(value);
			context.SaveChanges();
			return RedirectToAction("MessageList");
		}
		
	}
}
