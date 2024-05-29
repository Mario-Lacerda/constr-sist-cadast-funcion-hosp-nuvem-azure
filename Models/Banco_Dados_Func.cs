public class CadastroFuncionariosContext : DbContext
{
    public CadastroFuncionariosContext(DbContextOptions<CadastroFuncionariosContext> options)
        : base(options)
    {
    }

    public DbSet<Funcionario> Funcionarios { get; set; }
}
