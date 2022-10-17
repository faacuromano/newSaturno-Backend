using Microsoft.AspNetCore.Mvc;
using Sa_Turno_BackEnd.Entitys;

namespace Sa_Turno_BackEnd.Controllers
{
    [ApiController]
    [Route("servicios")]

    public class ServicioController : ControllerBase
    {
        List<Servicio> servicios = new List<Servicio>
           {
            new Servicio
            {
                  Id = 1,
                  Nombre = "Corte de pelo",
                  Profesional = "Roberto el peluquero",
                  Cliente = "Ramon el cliente",
                  Fecha="23/11/2022 - 11:30",
                  Precio= 800,
            },
           };

        [HttpGet]
        [Route("Listar")]
        public dynamic showServices() {

            return servicios;
        }


        [HttpPost]
        [Route("save")]
        public dynamic saveServicios(Servicio servicio)
        {
            servicios.Add(servicio);

            return servicios;
        }

    }
}
