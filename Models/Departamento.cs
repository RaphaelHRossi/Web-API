using System.Text.Json.Serialization;

namespace EFAPI.Models
{
    public class Departamento
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sigla { get; set; }
    }
}
