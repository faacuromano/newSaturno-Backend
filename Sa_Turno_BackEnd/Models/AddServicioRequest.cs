namespace Sa_Turno_BackEnd.Models
{
    public class AddServicioRequest
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Profesional { get; set; }
        public string Cliente { get; set; }
        public int Precio { get; set; }
    }
}
