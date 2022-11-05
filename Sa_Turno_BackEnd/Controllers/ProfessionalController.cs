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
                  Username = "megatlon",
                  Nombre = "Megatlón",
                  Profesion="Gimnasio",
                  Horario="Lun a Sab - 7:00 a 23:00",
                  Direccion="Tucumán 1239",
                  Telefono="0341-5282703",
                  Ubicacion="Rosario",
                  Mail="rosario@megatlon.com.ar",
                  Descripcion="La misión de Megatlon es mejorar la calidad de vida de las personas a través de la actividad física y el desarrollo de los vínculos sociales, y su visión es la de ser la empresa de gimnasios y servicios deportivos líder en todos los mercados donde esté presente.\r\n\r\nMegatlon es la marca líder y de mayor prestigio, reconocida en su segmento de actividad por ser top of mind para el 80% de la población adulta de Buenos Aires.\r\n\r\nRespeto, pasión, prioridad por el cliente, profesionalismo y credibilidad son los valores principales que refleja la organización.",
              },
              new Professional
              {
                  Id = 2,
                  Username = "aledemelo",
                  Nombre = "Ale de Melo",
                  Profesion="Peluquería",
                  Horario="Lun a sabado - 9:00 a 18:00",
                  Direccion="M. Moreno 1434",
                  Telefono="0341-6371858",
                  Ubicacion="Rosario",
                  Mail="info@aledemelo.com.ar",
                  Descripcion="Somos un equipo de peluqueros altamente calificados. Es por eso que nuestro salón ha llegado a convertirse en un referente en el mundo de la moda.En Ale de Melo estamos convencidos de nuestro concepto. La belleza proviene del interior. Cada individuo es único. Es por eso que todos tenemos que tener la oportunidad de transformar nuestra belleza propia, interna y única en belleza externa.",

              },
              new Professional
              {
                  Id = 3,
                  Username = "matiruiz",
                  Nombre = "Ortodoncia Rosario",
                  Profesion="Odontología",
                  Horario="Lun a Vie - 9:00 a 18:00",
                  Direccion="Córdoba 940",
                  Telefono="341-5993558",
                  Ubicacion="Rosario",
                  Mail="info@ortodonciarosario.com.ar",
                  Descripcion="Bienvenido a Ortodoncia Rosario. Te esperamos para que seas atendido por una familia de profesionales de la salud bucal con el objetivo de ayudarte a alinear y/o nivelar tus dientes y mejorar tu sonrisa y estética.",
              },
              new Professional
              {
                  Id = 4,
                  Username = "el-yeite",
                  Nombre = "El Yeite",
                  Profesion="Sala de ensayo",
                  Horario="Lun a vie - 15:00 a 23:00",
                  Direccion="San Luis 2073",
                  Telefono="341-6799909",
                  Ubicacion="Rosario",
                  Mail="asdasdasd@hotmail.com",
                  Descripcion="En el Yeite tenemos todos los equipos que tu banda puede llegar a necesitar para ensayar o grabar. Alquilamos platillos. Cerveza bien fría.",
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

        [HttpGet]
        [Route("{id}")]
        public dynamic GetOne(int id)
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
