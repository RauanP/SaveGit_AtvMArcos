using Microsoft.AspNetCore.Mvc;

namespace Atv_Marcos.Controllers
{
    public class ClienteController : Controller
    {
        public IActionResult CadastroCliente()
        {
            return View();
        }
    }
}
