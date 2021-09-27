using System.ComponentModel.DataAnnotations;

namespace ApiRotinaBoleto.Models
{
    public class Pessoa
    {

        public Pessoa()
        {

        }

        public Pessoa(string nomePessoa, string nomeFantasia, string documentoPessoa, string tipoPessoa)
        {
            NomePessoa = nomePessoa;
            NomeFantasia = nomeFantasia;
            DocumentoPessoa = documentoPessoa;
            TipoPessoa = tipoPessoa;
        }

        [Key]
        public int IdPessoa { get; set; }

        [StringLength(100)]
        public string NomePessoa { get; set; }

        [StringLength(150)]
        public string NomeFantasia { get; set; }

        [StringLength(14)]
        public string DocumentoPessoa { get; set; }

        [StringLength(1)]
        public string TipoPessoa { get; set; }


    }
}
