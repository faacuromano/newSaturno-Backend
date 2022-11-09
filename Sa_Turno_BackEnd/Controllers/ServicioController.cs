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
    public class ServiceController : ControllerBase
    {
        private readonly IServiceRepository _serviceRepository;

        public ServiceController(IServiceRepository serviceRepository)
        {
            _serviceRepository = serviceRepository;
        }

        [HttpPost]
        public IActionResult AddServicio(AddServicioRequest dtoServicio)
        {
            try
            {
                List<Service> services = _serviceRepository.GetAll();
                Service servicio = new Service()
                {
                    Id = services.Max(x => x.Id) + 1,
                    Name = dtoServicio.Nombre,
                    Cliente = dtoServicio.Cliente,
                    Price = dtoServicio.Precio
                };
                    _serviceRepository.Add(servicio);

                ServicioResponse response = new ServicioResponse()
                {
                    Id = services.Max(x => x.Id) + 1,
 
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
                List<Service> servicios = _serviceRepository.GetAll();
                List<Sa_Turno_BackEnd.Models.ServicioResponse> response = new List<Sa_Turno_BackEnd.Models.ServicioResponse>();
                foreach (var servicio in servicios)
                {
                    response.Add(
                        new Sa_Turno_BackEnd.Models.ServicioResponse()
                        {
                            Id = servicio.Id,
                            Nombre = servicio.Name,
                            Cliente = servicio.Cliente,
                            Precio = servicio.Price
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
            return Ok(_serviceRepository.Get(id));
        }

        [HttpPut]
        [Route("{id}")]
        public IActionResult Edit(int id, AddServicioRequest dtoServicio)
        {
            List<Service> servicios = _serviceRepository.Delete(id);
            Service servicio = new Service()
            {
                Id = servicios.Max(x => x.Id) + 1,
                Name = dtoServicio.Nombre,
                Cliente = dtoServicio.Cliente,
                Price = dtoServicio.Precio
            };
            _serviceRepository.Add(servicio);

            return Ok(servicio);
        }

        [HttpDelete]
        [Route("{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                List<Service> servicios = _serviceRepository.Delete(id);
                List<Sa_Turno_BackEnd.Models.ServicioResponse> response = new List<Sa_Turno_BackEnd.Models.ServicioResponse>();
                return Ok("Servicio ID" + "["+ id +"]"+ "---> Eliminado correctamente.");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}

