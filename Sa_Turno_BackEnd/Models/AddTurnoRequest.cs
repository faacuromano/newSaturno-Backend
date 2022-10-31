using System.ComponentModel.DataAnnotations;

namespace Sa_Turno_BackEnd.Models
{
    public class AddTurnoRequest
    {
        public int Id { get; set; }
        public string Fecha { get; set; }
        public string Horario { get; set; }
        public string Hash { get; set; }
    }
}
