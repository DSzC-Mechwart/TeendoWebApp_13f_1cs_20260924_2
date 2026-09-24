using Microsoft.EntityFrameworkCore;
using TeendoWebApp_13f_1cs_20260924.Models;

namespace TeendoWebApp_13f_1cs_20260924.Data
{
    public class TeendoDbContext : DbContext
    {
        public TeendoDbContext(DbContextOptions<TeendoDbContext> options) : base(options)
    {
    }
    public DbSet<Teendo> Teendok { get; set; }
}
}
