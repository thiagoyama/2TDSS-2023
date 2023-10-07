using Fiap.Web.Aula03.Models;
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

        //Criar o cadastro de paciente (Criar o método GET para abrir a página com o form HTML)
        //Criar uma página separada com o formulário HTML (cadastrar e no editar)
        [HttpGet]
        public IActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Cadastrar(Paciente paciente)
        {
            //Cadastrar no banco de dados
            _context.Pacientes.Add(paciente);
            _context.SaveChanges();
            //Mensagem de sucesso
            TempData["msg"] = "Paciente cadastrado!";
            return RedirectToAction("cadastrar");
        }

        public IActionResult Index()
        {                      
            var lista = _context.Pacientes.ToList();
            return View(lista);
        }
    }
}
