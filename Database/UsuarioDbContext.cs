using Agencia.Model;
using Microsoft.EntityFrameworkCore;

namespace Agencia.Database
{
    public class UsuarioDbContext : DbContext
    {
        public UsuarioDbContext(DbContextOptions<UsuarioDbContext> 
        options) : base(options){

        }

        public DbSet<Usuario> Usuarios {get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder){
            var usuario = modelBuilder.Entity<Usuario>();
            usuario.ToTable("usuario");
            usuario.HasKey(x => x.Id);
            usuario.Property(x => x.Id).HasColumnName("id").ValueGeneratedOnAdd();
            usuario.Property(x => x.Nome).HasColumnName("nome").IsRequired();
            usuario.Property(x => x.DataNascimento).HasColumnName("data_nascimento");
        }
           

    }
}