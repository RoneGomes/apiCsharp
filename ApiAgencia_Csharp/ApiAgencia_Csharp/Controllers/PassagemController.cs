using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiAgencia_Csharp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PassagemController : ControllerBase
    {

        private readonly PassagemDbContext _context;

        public PassagemController(PassagemDbContext context)
        {​​
            _context = context;
        }​​

       
        [HttpGet]
        public IEnumerable<Passagem> Getpassagems()
        {
            return _context.Passagems;
        }

        [HttpGet("{id}")]
        public IActionResult GetPassagemPorId(int id)
        {
            Passagem passagem = _context.Passagems.SingleOrDefault(modelo => modelo.passagemId == id);
            if (passagem == null)
            {
                return NotFound();
            }
            return new ObjectResult(passagem);
        }


        [HttpPost]
        public IActionResult CriarPassagem(Passagem item)
        {
            if (item == null)
            {
                return BadRequest();
            }

            _context.Passagems.Add(item);
            _context.SaveChanges();
            return new ObjectResult(item);

        }


        [HttpPut("{id}")]
        public IActionResult AtualizaPassagem(int id, Passagem item)
        {
            if (id != item.passagemId)
            {
                return BadRequest();
            }
            _context.Entry(item).State = EntityState.Modified;
            _context.SaveChanges();

            return new NoContentResult();
        }



        [HttpDelete("{id}")]
        public IActionResult Deletapassagem(int id)
        {
            var passagem = _context.passagems.SingleOrDefault(m => m.passagemId == id);

            if (passagem == null)
            {
                return BadRequest();
            }

            _context.Passagems.Remove(passagem);
            _context.SaveChanges();
            return Ok(passagem);
        }

    }
}

