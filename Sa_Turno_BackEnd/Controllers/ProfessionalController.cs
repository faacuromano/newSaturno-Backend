using Microsoft.AspNetCore.Mvc;
using Sa_Turno_BackEnd.Entitys;

namespace Sa_Turno_BackEnd.Controllers
{

    [ApiController]
    [Route("professional")]

    public class ProfessionalController : ControllerBase
    {
        List<Professional> professionals = new List<Professional>
            {
              new Professional  
              {
                  Id = 1,
                  Username = "aelohim",
                  Contrasena = "",
                  Nombre = "Aelohim Speciale",
                  Profesion="Programador",
                  Horario="Lun a Jue - 14:00 a 20:00",
                  Direccion="Siempre viva 33",
                  Telefono="123456789",
                  Ubicacion="Rosario",
                  Mail="asdasdasd@hotmail.com",
                  Descripcion="Lorem Ipsum is simply dummy text of the printing and typesetting industry.\"",
              },
              new Professional
              {
                  Id = 2,
                  Username = "soficorvalar",
                  Contrasena = "",
                  Nombre = "Sofia Corvalan",
                  Profesion="Programadora",
                  Horario="Lun a Jue - 7:00 a 15:00",
                  Direccion="Siempre viva 33",
                  Telefono="123456789",
                  Ubicacion="Rosario",
                  Mail="asdasdasd@hotmail.com",
                  Descripcion="Lorem Ipsum is simply dummy text of the printing and typesetting industry.\"",

              },
              new Professional
              {
                  Id = 3,
                  Username = "matiruiz",
                  Contrasena = "",
                  Nombre = "Matias Ruiz",
                  Profesion="Programador",
                  Horario="Lun a Jue - 10:00 a 18:00",
                  Direccion="Siempre viva 33",
                  Telefono="123456789",
                  Ubicacion="Rosario",
                  Mail="asdasdasd@hotmail.com",
                  Descripcion="Lorem Ipsum is simply dummy text of the printing and typesetting industry.\"",
              },
              new Professional
              {
                  Id = 4,
                  Username = "faacuromano",
                  Contrasena = "",
                  Nombre = "Facundo Romanmo",
                  Profesion="Programador",
                  Horario="Lun a Jue - 09:00 a 15:00",
                  Direccion="Siempre viva 33",
                  Telefono="123456789",
                  Ubicacion="Rosario",
                  Mail="asdasdasd@hotmail.com",
                  Descripcion="Lorem Ipsum is simply dummy text of the printing and typesetting industry.\"",
              },

            };

        [HttpGet]
        [Route("list")]
        public dynamic showProfessional()
        {
            return professionals;
        }

        [HttpPost]
        [Route("save")]
        public dynamic saveProfessional(Professional professional)
        {
            professionals.Add(professional);
            return professionals;
        }

        [HttpPut]
        [Route("modify/{id}/{nombre}")]
        public dynamic modifyNameClients(int id, string nombre)
        {
            professionals = professionals.Where(x => x.Id == id).ToList();

            return professionals;
        }

        [HttpDelete]
        [Route("delete/{id}")]
        public dynamic deleteClients(int id)
        {
            var clients_new = professionals.Where(x => x.Id != id).ToList();
            professionals = clients_new;
            return professionals;
        }
    }
}
