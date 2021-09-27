using Microsoft.EntityFrameworkCore;
using System.Data.SqlClient;
using ApiRotinaBoleto.Models;

namespace ApiRotinaBoleto.Data
{
    public class SqlContext : DbContext
    {

        public SqlContext(DbContextOptions<SqlContext> options) : base(options)
        {

        }

        public string ConnectionString { get; set; }



        private SqlConnection GetConnection()
        {
            return new SqlConnection(ConnectionString);
        }



        public DbSet<ApiRotinaBoleto.Models.Pessoa> Pessoa { get; set; }
        public DbSet<ApiRotinaBoleto.Models.Boleto> Boleto{ get; set; }
    }
}
