using Fiap.Web.Aula02.Models;
using Microsoft.AspNetCore.Mvc;

namespace Fiap.Web.Aula02.Controllers
{
    public class PersonagemController : Controller
    {
        //Armazenar os personagens em memória
        private static List<Personagem> _lista = new List<Personagem>();
        private static int _count = 0;

        [HttpPost]
        public IActionResult Excluir(int id)
        {
            //Remover o personagem da lista
            var p = _lista.First(p =>  p.Id == id);
            _lista.Remove(p);
            //Enviar uma mensagem para a view
            TempData["msg"] = "Personagem removido!";
            //Redirect para a listagem'
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Editar(Personagem personagem)
        {
            //Alterar o personagem na lista
            var index = _lista.FindIndex(p => p.Id == personagem.Id);
            _lista[index] = personagem;
            //Mensagem de sucesso
            TempData["msg"] = "Personagem atualizado!";
            //Redirect para a listagem'
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Editar(int id)
        {
            //Pesquisar o personagem pelo id
            var churros = _lista.First(p => p.Id == id);
            //Retornar a view com os dados do personagem
            return View(churros);
        }

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
            personagem.Id = ++_count;
            _lista.Add(personagem);
            TempData["msg"] = "Personagem cadastrado!";
            return RedirectToAction("Cadastrar"); //Action método
        }

        [HttpGet]
        public IActionResult Cadastrar()
        {
            return View();
        }
    }
}
