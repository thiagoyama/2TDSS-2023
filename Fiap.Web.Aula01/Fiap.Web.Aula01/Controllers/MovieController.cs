using Fiap.Web.Aula01.Models;
using Microsoft.AspNetCore.Mvc;

namespace Fiap.Web.Aula01.Controllers
{
    public class MovieController : Controller
    {
        [HttpGet] //Abrir a página HTML com o formulário
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost] //Receber os parametros do formulario após o submit
        public IActionResult Index(Movie movie)
        {
            //Enviar o nome do filme para a página
            ViewData["churros"] = movie.Nome;
            ViewBag.mochila = movie;
            return View(); 
            //Envia um texto para o browser
            //return Content($"Nome: {movie.Nome}, Ano: {movie.Ano}," +
            //    $" Faturamento: {movie.Faturamento}");
        }
    }
}
