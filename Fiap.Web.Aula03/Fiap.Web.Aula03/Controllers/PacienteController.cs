using Fiap.Web.Aula03.Persistencia;
using Microsoft.AspNetCore.Mvc;

namespace Fiap.Web.Aula03.Controllers
{
    public class PacienteController : Controller
    {
        private HospitalContext _context;

        //Recebe o DbContext por injeção de dependência
        public PacienteController(HospitalContext context)
        {
            _context = context;
        }

        //Tarefa é criar o CRUD com o Banco

        public IActionResult Index()
        {
            return View();
        }
    }
}
