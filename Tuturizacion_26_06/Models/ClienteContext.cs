using Microsoft.EntityFrameworkCore;

namespace Tuturizacion_26_06.Models
{
    public class ClienteContext : DbContext
    {
        public DbSet<Cliente> Clientes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"server=DESKTOP-Q01VLRN; Database=ClientesForo; Trusted_Connection=true;Encrypt=False;");
        }
    }
}
