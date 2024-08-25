using Exo.WebApi.Models;
using Microsoft.EntityFrameworkCore;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;
namespace Exo.WebApi.Contexts
{
    public class ExoContext : DbContext
    {
        public ExoContext()
        {
        }
        public ExoContext(DbContextOptions<ExoContext> options) :
        base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder
        optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                // Essa string de conexão depende da SUA máquina.
                optionsBuilder.UseSqlServer("User Id='sa';Password='@secret86';Server='VELOIS';Database='ExoApi';");
                //optionsBuilder.UseSqlServer("Server=VELOIS\\;Database=ExoApi");
                // Exemplo 1 de string de conexão:
                // User
                // + Trusted_Connection=False;
            }
        }
        public DbSet<Projeto> Projetos { get; set; }
    }
}