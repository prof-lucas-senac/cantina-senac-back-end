using Microsoft.EntityFrameworkCore;

public class CantinaSenacContext : DbContext {
    string stringConexao = "Server=localhost;Port=3306;Database=CantinaSenacOrm;Uid=root;Pwd=Tocomfome12art";

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
        optionsBuilder.UseMySql(stringConexao, ServerVersion.AutoDetect(stringConexao));
    }
}