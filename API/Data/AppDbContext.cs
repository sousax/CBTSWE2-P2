using Microsoft.EntityFrameworkCore;
using Models;

//Feito por Eduardo Miranda CB3026604 & Cauã Barros CB3025179

namespace API.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {}   

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Produto>()
                .HasOne<Usuario>() 
                .WithMany() 
                .HasForeignKey(p => p.IdUsuarioCadastro)
                .OnDelete(DeleteBehavior.Restrict); 

            base.OnModelCreating(modelBuilder); 
        }
    }
}
