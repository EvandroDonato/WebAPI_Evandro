using System.ComponentModel.DataAnnotations;
using WebAPI_Evandro.Enums;

namespace WebAPI_Evandro.Models
{
    public class FuncionarioModel
  {
    [Key]
    public int Id { get; set; }
    public string Nome { get; set; }
    public string SobreNome { get; set; }
    public DepartamentoEnum Departamento { get; set; }
    public bool Ativo { get; set; }
    public TurnoEnum Turno { get; set; }
    public DateTime DataCriacao { get; set; }

    public DateTime DataDeAlteracao { get; set; }
  }
}

