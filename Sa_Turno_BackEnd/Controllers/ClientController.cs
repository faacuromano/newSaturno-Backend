using Microsoft.AspNetCore.Mvc;
using Sa_Turno_BackEnd.Entitys;
using System.Xml.Linq;

namespace Sa_Turno_BackEnd.Controllers
{
   [ApiController]
   [Route("client")]
   public class ClientController : ControllerBase
   {
        List<Client> clients = new List<Client>
           {
           new Client
           {
                  Id = 1,
                  Username = "faacuromano",
                  Contrasena = "",
                  Nombre = "Facundo Romanmo",
                  Telefono="3415322313",
           },

           new Client
           {
                  Id = 2,
                  Username = "faacuromano",
                  Contrasena = "",
                  Nombre = "Facundo Romanmo",
                  Telefono="3415322313",
            },
           new Client
           {
                  Id = 3,
                  Username = "faacuromano",
                  Contrasena = "",
                  Nombre = "Facundo Romanmo",
                  Telefono="3415322313",
            },

           };

       [HttpGet]
       [Route("list")]
       public dynamic showClients()
       {
           return clients;
       }

        [HttpPost]
        [Route("save")]
        public dynamic saveProfessional(Client client, string name)
        {
            clients.Add(client);

            return clients;
        }

        [HttpPut]
        [Route("modify/{id}/{nombre}")]
        public dynamic modifyNameClients(int id, string nombre)
        {
            clients = clients.Where(x => x.Id == id).ToList();


            return clients;
        }

        [HttpDelete]
        [Route("delete/{id}")]
        public dynamic deleteClients(int id)
        {
            var clients_new = clients.Where(x => x.Id != id).ToList();
            clients = clients_new;
            return clients;
        }
    }
}
