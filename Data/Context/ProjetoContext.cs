using Data.Model;
using Microsoft.EntityFrameworkCore;

namespace Data.Context
{
    internal class ProjetoContext : DbContext
    {
        #region Props
        public DbSet<Computador> Computador { get; set; }
        #endregion

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost; Port=5437; Database=postgres; UserId=postgres; Password=123456");
        }
    }
}
