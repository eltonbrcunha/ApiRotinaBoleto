using ApiRotinaBoleto.Data;
using ApiRotinaBoleto.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiRotinaBoleto.Controllers
{
    public class BoletoController : Controller
    {
        private readonly SqlContext _context;

        public BoletoController(SqlContext context)
        {

            _context = context;
        }

        /// <summary>
        /// Lista Todos os Boletos registrados no banco de dados
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("Boleto/ListarBoletos")]
        public List<Boleto> ListarBoletos()
        {
            return _context.Boleto.ToList();

        }

        /// <summary>
        /// Localiza boleto por número de Código de Barras
        /// </summary>
        /// <param name="numeroCodigoBarras">Número do Código de Barras para localizar o boleto</param>
        /// <returns></returns>
        [HttpGet]
        [Route("Boleto/LocalizarBoleto")]
        public ActionResult<IEnumerable<Boleto>> LocalizarBoleto(string numeroCodigoBarras)
        {
           var result= _context.Boleto.FirstOrDefault(b => b.NumeroCodigoBarras == numeroCodigoBarras);
            return Ok (result);
        }



        [HttpPost]
        [Route("LancarBoleto")]
        public async Task<IActionResult> LancarBoleto(DateTime dataVencimento,decimal valorBoleto,int idPessoa,string numeroCodigoBarras)
        {
            var boleto = new Boleto(
                dataVencimento,
                valorBoleto,
                idPessoa,
                "N",
                numeroCodigoBarras

                );

            _context.Add(boleto);
            await _context.SaveChangesAsync();
            return Ok();
        }
    }
}
