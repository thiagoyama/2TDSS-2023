using Fiap.Web.Aula02.Models;
using Microsoft.AspNetCore.Mvc;

namespace Fiap.Web.Aula02.Controllers
{
    public class PersonagemController : Controller
    {
        //Armazenar os personagens em memória
        private static List<Personagem> _lista = new List<Personagem>();

        //Listar os personagens (Criar uma página com uma tabela HTML)
        [HttpGet]
        public IActionResult Index()
        {
            //Enviar a lista de personagem para a view
            return View(_lista);
        }

        [HttpPost]
        public IActionResult Cadastrar(Personagem personagem)
        {
            _lista.Add(personagem);
            ViewBag.mensagem = "Personagem cadastrado!";
            return View();
        }

        [HttpGet]
        public IActionResult Cadastrar()
        {
            return View();
        }
    }
}
