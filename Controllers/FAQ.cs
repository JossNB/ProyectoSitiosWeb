using Microsoft.AspNetCore.Mvc;

namespace TixtlySW.Controllers
{
    public class FAQ : Controller
    {
        public IActionResult VistaFAQ()
        {
            return View();
        }
    }
}
