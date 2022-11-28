using Microsoft.AspNetCore.Mvc;

namespace PasswordManager.Areas.Admin.Controllers
{
	public class AddressController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
