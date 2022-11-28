using Microsoft.AspNetCore.Mvc;

namespace PasswordManager.Areas.Admin.Controllers
{
	public class PaymentController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
