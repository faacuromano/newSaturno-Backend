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
                  FotoPerfil="https://scontent.fros9-2.fna.fbcdn.net/v/t39.30808-6/279943426_10166699690460037_1729726179619868333_n.jpg?_nc_cat=104&ccb=1-7&_nc_sid=09cbfe&_nc_eui2=AeFPWMqjuEMU7u7mi6BkOuvJdysdtUGosTB3Kx21QaixMPDuuEgXdP-ipIPKmFlrNW8&_nc_ohc=m3KFBrZxl48AX_vEHCo&_nc_ht=scontent.fros9-2.fna&oh=00_AfC0TUfybjorJXWnaEvJUDF55RvE_csjWlQO63UbJIf76A&oe=63725069",
                  FotoPortada="https://scontent.fros9-2.fna.fbcdn.net/v/t39.30808-6/310041374_10167122957225037_2802165028858957496_n.jpg?_nc_cat=108&ccb=1-7&_nc_sid=e3f864&_nc_eui2=AeGrhGlxxnkk6WHWlmTy7ho1ozMeL9c_6S2jMx4v1z_pLeZweU3v9GXUX5E5F02cnZU&_nc_ohc=wG4skvfUKMEAX_O7VnR&tn=ErmeG5QLHlxc1M9Z&_nc_ht=scontent.fros9-2.fna&oh=00_AfBM-Rl7hNHKguvjf_w-E1XZS-QntpZtTFzLaJpXudjhnA&oe=637178B4"
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
                  FotoPerfil="https://scontent.fros9-2.fna.fbcdn.net/v/t39.30808-6/291323800_431319099004946_6961230187146325336_n.jpg?_nc_cat=103&ccb=1-7&_nc_sid=09cbfe&_nc_eui2=AeH0PZ_tZsN1aIc8G-grwtUxdWuvvnumwkV1a6--e6bCRUFlIBqMQXrCk0Y9w3RvLOA&_nc_ohc=HUN54gzlhhAAX_3FGes&_nc_ht=scontent.fros9-2.fna&oh=00_AfACfUP2Enhhc1euTFryo0czivvkxYYPpu3HiOF0SuRUQw&oe=63719E1D",
                  FotoPortada="https://scontent.fros9-2.fna.fbcdn.net/v/t39.30808-6/277991945_7261773857228163_291554928038924265_n.jpg?_nc_cat=106&ccb=1-7&_nc_sid=e3f864&_nc_eui2=AeGowSVE1jNYZmQkte5DAb88Eu078bpshJgS7TvxumyEmJgtTMGyjidyPHZm8vGrUlw&_nc_ohc=RabtVXKyTTUAX-sXbqa&_nc_ht=scontent.fros9-2.fna&oh=00_AfCeMvAGVIxPHG45tX6JNscsbE7_utDmlfGVTeysCyawwQ&oe=63712C26"
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
                  FotoPerfil="https://scontent.fros9-1.fna.fbcdn.net/v/t39.30808-6/305019212_2371173523038033_6488024530444082669_n.jpg?_nc_cat=108&ccb=1-7&_nc_sid=09cbfe&_nc_eui2=AeHdusAdAnulfive2M4R-h7smuhcqTqUbKia6FypOpRsqLdtAGJL4UsXQ6ZTH66f2ME&_nc_ohc=EOAetmRSyFkAX80Vmjv&tn=ErmeG5QLHlxc1M9Z&_nc_ht=scontent.fros9-1.fna&oh=00_AfCKd4QoQGeSzDqMlbTTk1x83kNI8S0jNVLi8qUG9Gv4Xw&oe=63721E64",
                  FotoPortada="https://scontent.fros9-2.fna.fbcdn.net/v/t39.30808-6/305481421_2371173799704672_8217648126840987850_n.jpg?_nc_cat=103&ccb=1-7&_nc_sid=e3f864&_nc_eui2=AeF59GmfvERoh04MT3YOOv3hLQFzH5vDQWwtAXMfm8NBbIFls562_CNkV8QD-BKvKPU&_nc_ohc=Bgm2_0bnbyYAX_TvjnC&_nc_ht=scontent.fros9-2.fna&oh=00_AfA2KTFafcVPJzRO9pp7yP7KR9-LS93lLS6u8vLGiBGnJw&oe=6372BD2F"
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
                  Mail="asdasdsd@hotmail.com",
                  Descripcion="En el Yeite tenemos todos los equipos que tu banda puede llegar a necesitar para ensayar o grabar. Alquilamos platillos. Cerveza bien fría.",
                  FotoPerfil="https://scontent.fros9-1.fna.fbcdn.net/v/t39.30808-6/292409105_436811015121009_1794291114756506121_n.png?_nc_cat=111&ccb=1-7&_nc_sid=09cbfe&_nc_eui2=AeEs6vJ_bR0bNpdQTAsNsQbzyugzbXcD6hrK6DNtdwPqGpbi8CWIJYlEhFlSba5iq40&_nc_ohc=g9nmpKYsby0AX-4-nRK&_nc_ht=scontent.fros9-1.fna&oh=00_AfD1JYwjMLn3zGfTF8C_nj35r5YSu4fFHE52XJ9f1jjrPw&oe=637257C3",
                  FotoPortada="https://scontent.fros9-2.fna.fbcdn.net/v/t39.30808-6/292524349_436811011787676_4697193701284965411_n.png?_nc_cat=104&ccb=1-7&_nc_sid=e3f864&_nc_eui2=AeEkzPUsJSOsl9VfxnYyHgcFF0u3Jp2-w4EXS7cmnb7DgYq_y8TGHZxWiw8HwkRSn9g&_nc_ohc=qSCqZK6MCLEAX8I4-kG&tn=ErmeG5QLHlxc1M9Z&_nc_ht=scontent.fros9-2.fna&oh=00_AfBJzgZfzHSo55Ik1VrZA2CbjGKE9FxvtIdup5CzjyH9bg&oe=6372237F"
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
