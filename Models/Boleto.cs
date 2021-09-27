using System;
using System.ComponentModel.DataAnnotations;

namespace ApiRotinaBoleto.Models
{
    public class Boleto
    {
        public Boleto(DateTime dataVencimento, decimal valorBoleto, int idPessoa, string situacaoBoleto, string numeroCodigoBarras)
        {
            DataVencimento = dataVencimento;
            ValorBoleto = valorBoleto;
            IdPessoa = idPessoa;
            SituacaoBoleto= situacaoBoleto;
            NumeroCodigoBarras = numeroCodigoBarras;
        }

        [Key]
        public int IdBoleto { get; set; }
        public DateTime DataVencimento { get; set; }
        public decimal ValorBoleto { get; set; }
        public int IdPessoa { get; set; }
        public DateTime? DataPagamento { get; set; }

        [StringLength(1)]
        public string SituacaoBoleto { get; set; }

        [StringLength(44)]
        public string NumeroCodigoBarras { get; set; }

        public DateTime? DataCredito{ get; set; }
        public decimal? ValorPagamento { get; set; }



    }
}
