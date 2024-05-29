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

        // GET: api/Funcionarios/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Funcionario>> GetFuncionario(int id)
        {
            var funcionario = await _context.Funcionarios.FindAsync(id);

            if (funcionario == null)
            {
                return NotFound();
            }

            return funcionario;
        }
    }
}
