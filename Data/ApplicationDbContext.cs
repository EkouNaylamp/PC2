using Microsoft.EntityFrameworkCore;
using PC2.Models;

namespace PC2.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<CuentaBancaria> CuentasBancarias { get; set; }
    }
}
