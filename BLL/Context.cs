using Microsoft.EntityFrameworkCore;

class Context : DbContext
{
    public DbSet<Prioridades> prioridades { get; set; }
    public Context(DbContextOptions<Context> opcion) : base(opcion)
    {
        
    }
}