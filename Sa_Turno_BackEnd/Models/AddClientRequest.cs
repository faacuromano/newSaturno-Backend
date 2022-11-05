using System.ComponentModel.DataAnnotations;

namespace Sa_Turno_BackEnd.Models
{
    public class AddClientRequest
    {
        [MaxLength(10)]
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Nombre { get; set; }
        public string Password { get; set; }
        public string PhoneNumber { get; set; }
        public string Ubication { get; set; }


    }
}
