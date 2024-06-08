using System.Text.Json.Serialization;

namespace WebAPI_Evandro.Enums
{
  [JsonConverter(typeof(JsonStringEnumConverter))]
  public enum TurnoEnum
    {
        Manha,
        Tarde,
        Noite
    }
}
