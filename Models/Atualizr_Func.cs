using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace CadastroFuncionarios.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FuncionariosController : ControllerBase
    {
        private readonly CadastroFuncionariosContext _context;

        public FuncionariosController(CadastroFuncionariosContext context)
        {
            _context = context;
        }

        // PUT: api/Funcionarios/5
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateFuncionario(int id, Funcionario funcionario)
        {
            if (id != funcionario.Id)
            {
                return BadRequest();
            }

            _context.Entry(funcionario).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
