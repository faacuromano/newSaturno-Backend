using System.ComponentModel.DataAnnotations;

namespace Sa_Turno_BackEnd.Models
{
    public class AddClientRequest
    {
        [MaxLength(10)]
        public string Username { get; set; }
        public string Password { get; set; }
        public string Nombre { get; set; }
        public string Telefono { get; set; }
    }
}
