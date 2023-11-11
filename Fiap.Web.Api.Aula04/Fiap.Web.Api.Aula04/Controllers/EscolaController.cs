using Fiap.Web.Api.Aula04.Models;
using Fiap.Web.Api.Aula04.Persistencia;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Fiap.Web.Api.Aula04.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EscolaController : ControllerBase
    {
        private EscolaContext _context;

        public EscolaController(EscolaContext context)
        {
            _context = context;
        }

        //GET api/escola
        [HttpGet]
        public ActionResult<List<Escola>> Get()
        {
            return Ok(_context.Escolas.ToList());
        }

        //GET api/escola/{id}
        [HttpGet("{id}")]
        public ActionResult<Escola> Get(int id)
        {
            var escola = _context.Escolas.Find(id);
            if (escola == null)
            {
                return NotFound();
            }
            return Ok(escola);
        }

        //POST api/escola
        [HttpPost]
        public ActionResult Post(Escola escola)
        {
            _context.Escolas.Add(escola);
            _context.SaveChanges();
            return CreatedAtAction("Get", new {id = escola.Id} , escola); //201
        }

        //PUT api/escola/{id}
        [HttpPut("{id}")]
        public ActionResult Put(Escola escola, int id)
        {
            var busca = _context.Escolas.Find(id);
            if (busca == null)
                return NotFound();
            //Tirar o objeto busca do DbContext
            _context.Entry<Escola>(busca).State = Microsoft.EntityFrameworkCore.EntityState.Detached;
            escola.Id = id;
            _context.Escolas.Update(escola);
            _context.SaveChanges();
            return Ok(escola); //200
        }

        //DELETE api/escola/{id}
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var escola = _context.Escolas.Find(id);
            if (escola == null)
                return NotFound();
            _context.Escolas.Remove(escola);
            _context.SaveChanges(true);
            return NoContent(); //204
        }

    }
}
