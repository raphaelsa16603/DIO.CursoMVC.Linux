using Microsoft.EntityFrameworkCore;
using CursoMVC.Models;

namespace CursoMVC.Models
{
    public class Context : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=CursoMVC.db");
        }

        public DbSet<Categoria> Categorias { get; set; }

        public DbSet<CursoMVC.Models.Produto> Produto { get; set; }
    }
}