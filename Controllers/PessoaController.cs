using ApiRotinaBoleto.Data;
using ApiRotinaBoleto.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiRotinaBoleto.Controllers
{
    public class PessoaController : Controller
    {
        private readonly SqlContext _context;

        public PessoaController(SqlContext context)
        {
            _context = context;
        }


        [HttpGet]
        [Route("Pessoa/ListarPessoa")]
        public List<Pessoa> ListarPessoas()
        {
            return _context.Pessoa.ToList();
        }


        [HttpPost]
        [Route("Pessoa/CadastrarPessoa")]
        public async Task<IActionResult> CadastrarPessoa([FromBody] Pessoa pes)
        {
            var pessoa = new Pessoa
                (
                pes.NomePessoa,
                pes.NomeFantasia,
                pes.DocumentoPessoa,
                pes.TipoPessoa
                );

            _context.Add(pessoa);
            await _context.SaveChangesAsync();

            return Ok();
        }

    }
}
