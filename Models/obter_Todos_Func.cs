using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
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

        // GET: api/Funcionarios
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Funcionario>>> GetFuncionarios()
        {
            return await _context.Funcionarios.ToListAsync();
        }
    }
}
