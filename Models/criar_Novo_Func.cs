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

        // POST: api/Funcionarios
        [HttpPost]
        public async Task<ActionResult<Funcionario>> CreateFuncionario(Funcionario funcionario)
        {
            _context.Funcionarios.Add(funcionario);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetFuncionario), new { id = funcionario.Id }, funcionario);
        }
    }
}
