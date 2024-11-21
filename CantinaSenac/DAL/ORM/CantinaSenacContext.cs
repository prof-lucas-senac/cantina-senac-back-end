using Microsoft.EntityFrameworkCore;

class CantinaSenacContext : DbContext
{
    public DbSet<Administrador> Administrador { get; set; }
    public DbSet<Usuario> Usuario { get; set; }
    public DbSet<Feedback> Feedback { get; set; }
    public DbSet<Postagem> Postagem { get; set; }
    string stringConexao = "Server=localhost;Port=3306;Database=CantinaSenacOrm;Uid=root;Pwd=root;";

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseMySql(stringConexao, ServerVersion.AutoDetect(stringConexao));
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Usuario>().ToTable("Usuario");
        modelBuilder.Entity<Administrador>().ToTable("Administrador");
        modelBuilder.Entity<Postagem>().ToTable("Postagem");
        modelBuilder.Entity<Feedback>().ToTable("Feedback");
    }

}