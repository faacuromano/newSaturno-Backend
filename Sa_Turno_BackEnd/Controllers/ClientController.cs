using Microsoft.AspNetCore.Mvc;
using Sa_Turno_BackEnd.Entitys;
using Sa_Turno_BackEnd.Models;
using Sa_Turno_BackEnd.Repository;
using System.Linq;
using System.Xml.Linq;

namespace Sa_Turno_BackEnd.Controllers
{
   [Route("[controller]")]
   [ApiController]
   public class ClientController : ControllerBase
   {
        private readonly IClientRepository _clientRepository;

        public ClientController(IClientRepository clientRepository)
        {
            _clientRepository = clientRepository;
        }

       [HttpPost]
        public IActionResult AddClient(AddClientRequest dtoClient)
       {
            try
            {
                List<Client> clients = _clientRepository.GetAll();
                Client client = new Client()
                {
                    Id = clients.Max(x => x.Id) + 1,
                    Username = dtoClient.Username,
                    Password = dtoClient.Password,
                    Nombre = dtoClient.Nombre,
                    Telefono = dtoClient.Username,
                };
                _clientRepository.Add(client);

                Sa_Turno_BackEnd.Models.ClientResponse response = new Sa_Turno_BackEnd.Models.ClientResponse()
                {
                    Id = clients.Max(x => x.Id) + 1,
                    Username = dtoClient.Username,
                    Password = dtoClient.Password,
                    Nombre = dtoClient.Nombre,
                };
                return Created("Sucessfully created", response);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            try
            {
                List<Client> clients = _clientRepository.GetAll();
                List<Sa_Turno_BackEnd.Models.ClientResponse> response = new List<Sa_Turno_BackEnd.Models.ClientResponse>();
                foreach (var client in clients)
                {
                    response.Add(
                        new Sa_Turno_BackEnd.Models.ClientResponse()
                        {
                            Id = client.Id, 
                            Username = client.Username,
                            Password = client.Password,
                        }
                    );
                }
                return Ok(response);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult GetOne(int id)
        {
            return Ok(_clientRepository.Get(id));
        }

        [HttpPut]
        [Route("{id}")]
        public IActionResult Edit(int id, AddClientRequest dtoClient)
        {
            List<Client> clients = _clientRepository.Delete(id);
            Client client = new Client()
            {
                Id = id,
                Username = dtoClient.Username,
                Password = dtoClient.Password,
                Nombre = dtoClient.Nombre,
                Telefono = dtoClient.Username,
            };
            _clientRepository.Add(client);

            return Ok(client);
        }

        [HttpDelete]
        [Route("{id}")]
        public IActionResult DeleteTurno(int id)
        {
            try
            {
                List<Client> clients = _clientRepository.Delete(id);

                return Ok("Cliente ID" + "[" + id + "]" + "---> Eliminado correctamente.");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


    }
}
