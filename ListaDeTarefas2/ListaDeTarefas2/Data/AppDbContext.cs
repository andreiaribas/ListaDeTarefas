using ListaDeTarefas2.Models;
using Microsoft.EntityFrameworkCore;

namespace ListaDeTarefas2.Data
{
    public class AppDbContext : DbContext
    {

        public DbSet<Tarefa> Tarefas { get; set; }

        protected override void OnConfiguring(
            DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseSqlite(connectionString: "DataSource=app.db;Cache=Shared");
    }
}
