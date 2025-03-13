using Microsoft.AspNetCore.Mvc;

namespace TixtlySW.Controllers
{
    public class PagoCliente : Controller
    {
        public IActionResult ConfirmacionPago()
        {
            return View();
        }
    }
}
