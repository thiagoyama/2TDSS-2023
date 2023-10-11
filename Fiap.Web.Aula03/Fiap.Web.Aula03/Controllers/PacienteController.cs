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

        [HttpPost]
        public IActionResult Excluir(int id)
        {
            var paciente = _context.Pacientes.Find(id);
            _context.Pacientes.Remove(paciente);
            _context.SaveChanges();
            TempData["msg"] = "Paciente removido!";
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Editar(Paciente paciente)
        {
            _context.Pacientes.Update(paciente);
            _context.SaveChanges();
            TempData["msg"] = "Paciente atualizado";
            return RedirectToAction("index");
        }

        [HttpGet]
        public IActionResult Editar(int id)
        {
            var paciente = _context.Pacientes.Find(id);
            return View(paciente);
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
