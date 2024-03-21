using Login_Ekranı.Models;
using Microsoft.AspNetCore.Mvc;

namespace Login_Ekranı.Controllers
{
	public class LoginController : Controller
	{

        [HttpGet]
		public IActionResult Uye()
		{
			return View();
		}
	}
}
