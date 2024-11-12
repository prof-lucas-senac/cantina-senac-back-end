using Microsoft.EntityFrameworkCore;

public class CantinaSenacContext : DbContext {
    public DbSet<Administrador> Administrador { get; set; }
    public DbSet<Usuario> Usuario { get; set; }

    string stringConexao = "Server=localhost;Port=3306;Database=CantinaSenacOrm;Uid=root;Pwd=";

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
        optionsBuilder.UseMySql(stringConexao, ServerVersion.AutoDetect(stringConexao));
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder) {
        modelBuilder.Entity<Usuario>().ToTable("Usuario");
        modelBuilder.Entity<Administrador>().ToTable("Administrador");
    }
}