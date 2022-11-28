using Microsoft.AspNetCore.Mvc;

namespace PasswordManager.Areas.Admin.Controllers
{
	public class PasswordController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
