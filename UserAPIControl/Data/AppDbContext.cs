using Microsoft.EntityFrameworkCore;
using UserAPIControl.Models;

namespace UserAPIControl.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    //public DbSet<Categoria> Categorias { get; set; }
    public DbSet<User> Users { get; set; }

    //public DbSet<Gasto> Gastos { get; set; }
}