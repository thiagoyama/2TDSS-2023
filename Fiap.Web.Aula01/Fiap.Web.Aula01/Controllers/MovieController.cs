using Microsoft.AspNetCore.Mvc;

namespace Fiap.Web.Aula01.Controllers
{
    public class MovieController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
