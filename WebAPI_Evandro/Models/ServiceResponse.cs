using WebAPI_Evandro.Enums;

namespace WebAPI_Evandro.Models
{

  //A classe vai receber dados genéricos <T>
  public class ServiceResponse<T>
  {
    public T? Dados { get; set; }
    public string Mensagem { get; set; } = string.Empty;
    public bool Sucesso { get; set; } = true;
  }

}  
