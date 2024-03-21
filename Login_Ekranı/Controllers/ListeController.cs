using Login_Ekranı.Models;
using Microsoft.AspNetCore.Mvc;

namespace Login_Ekranı.Controllers
{
    public class ListeController : Controller
    {
        static List<LoginUyeModel> login = new List<LoginUyeModel>();

        public IActionResult Listele(LoginUyeModel login)
        {
            return View(login);
        }
    }
}
