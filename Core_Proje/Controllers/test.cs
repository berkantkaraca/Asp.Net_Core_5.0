using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.Controllers
{
    public class test : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
