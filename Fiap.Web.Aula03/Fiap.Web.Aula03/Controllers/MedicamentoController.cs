using Fiap.Web.Aula03.Models;
using Fiap.Web.Aula03.Persistencia;
using Microsoft.AspNetCore.Mvc;

namespace Fiap.Web.Aula03.Controllers
{
    public class MedicamentoController : Controller
    {
        private HospitalContext _context;

        public MedicamentoController(HospitalContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Cadastrar(Medicamento medicamento)
        {
            _context.Medicamentos.Add(medicamento);
            _context.SaveChanges();
            TempData["msg"] = "Medicamento registrado";
            return RedirectToAction("Cadastrar");
        }

    }
}
