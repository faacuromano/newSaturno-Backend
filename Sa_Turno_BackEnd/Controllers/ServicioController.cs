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
    public class ServicioController : ControllerBase
    {
        private readonly IServicioRepository _servicioRepository;

        public ServicioController(IServicioRepository servicioRepository)
        {
            _servicioRepository = servicioRepository;
        }

        [HttpPost]
        public IActionResult AddServicio(AddServicioRequest dtoServicio)
        {
            try
            {
                List<Servicio> servicios = _servicioRepository.GetAll();
                Servicio servicio = new Servicio()
                {
                    Id = servicios.Max(x => x.Id) + 1,
                    Nombre = dtoServicio.Nombre,
                    Profesional = dtoServicio.Profesional,
                    Cliente = dtoServicio.Cliente,
                    Precio = dtoServicio.Precio
                };
                    _servicioRepository.Add(servicio);

                ServicioResponse response = new ServicioResponse()
                {
                    Id = servicios.Max(x => x.Id) + 1,
 
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
                List<Servicio> servicios = _servicioRepository.GetAll();
                List<Sa_Turno_BackEnd.Models.ServicioResponse> response = new List<Sa_Turno_BackEnd.Models.ServicioResponse>();
                foreach (var servicio in servicios)
                {
                    response.Add(
                        new Sa_Turno_BackEnd.Models.ServicioResponse()
                        {
                            Id = servicio.Id,
                            Nombre = servicio.Nombre,
                            Profesional = servicio.Profesional,
                            Cliente = servicio.Cliente,
                            Precio = servicio.Precio
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
            return Ok(_servicioRepository.Get(id));
        }

        [HttpDelete]
        [Route("/delete/{id}")]

        public IActionResult Delete(int id)
        {
            try
            {
                List<Servicio> servicios = _servicioRepository.Delete(id);
                List<Sa_Turno_BackEnd.Models.ServicioResponse> response = new List<Sa_Turno_BackEnd.Models.ServicioResponse>();
                foreach (var servicio in servicios)
                {
                    response.Add(
                        new Sa_Turno_BackEnd.Models.ServicioResponse()
                        {
                            Id = servicio.Id,
                            Nombre = servicio.Nombre,
                            Profesional = servicio.Profesional,
                            Cliente = servicio.Cliente,
                            Precio = servicio.Precio
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
    }
}

