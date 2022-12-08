using CadastroAPI.Data;
using CadastroAPI.Model;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LojasAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CadastroController : Controller
    {
        private CadastroContext _context;

        public CadastroController(CadastroContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<Cadastro> GetCadastro()
        {return _context.Registros;
        }
        [HttpPost]
        public IActionResult AddCadastro([FromBody] Cadastro cadastro)
        {
            _context.Registros.Add(cadastro);
            _context.SaveChanges();
            return CreatedAtAction(nameof(GetCadastroById), new { Id = cadastro.Id}, cadastro);
        }
        [HttpGet("{id}")]
        public IActionResult GetCadastroById(int id)
        {
            Cadastro cadastro = _context.Registros.FirstOrDefault(cadastro => cadastro.Id == id);
            if(cadastro != null)
            {return Ok(cadastro);
            }
            return NotFound();
        }

    }
}
