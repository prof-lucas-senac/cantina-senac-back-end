using Microsoft.EntityFrameworkCore;

class CantinaSenacContext : DbContext
{
        string stringConexao = "Server=localhost;Port=3306;Database=CantinaSenacOrm;Uid=root;Pwd=root;";

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseMySql(stringConexao,ServerVersion.AutoDetect(stringConexao));
    }

}