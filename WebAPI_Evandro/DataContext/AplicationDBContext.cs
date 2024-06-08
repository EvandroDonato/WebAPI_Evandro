using Microsoft.EntityFrameworkCore;
using WebAPI_Evandro.Models;

namespace WebAPI_Evandro.DataContext
{
  public class AplicationDBContext : DbContext
  {
    public AplicationDBContext(DbContextOptions<AplicationDBContext> options) : base(options)
    {

    }
    public DbSet<FuncionarioModel> Funcionarios { get; set; }

  }
}
