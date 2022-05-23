using Microsoft.AspNetCore.Mvc;

namespace ControleDeContatos.Controllers
{
    public class ContatoController : Controller
    {
        public IActionResult Index() //iaction das paginas
        {
            return View();
        }

        public IActionResult Criar() //iaction das paginas
        {
            return View();
        }

        public IActionResult Editar() //iaction das paginas
        {
            return View();
        }

        public IActionResult ApagarConfirmacao() //iaction das paginas
        {
            return View();
        }
    }
}
