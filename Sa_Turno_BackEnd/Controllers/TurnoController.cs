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
    public class TurnoController : ControllerBase
    {
        private readonly ITurnoRepository _turnoRepository;

        public TurnoController(ITurnoRepository turnoRepository)
        {
            _turnoRepository = turnoRepository;
        }

        [HttpPost]
        public IActionResult AddTurno(AddTurnoRequest dtoTurno)
        {
            try
            {
                List<Turno> turnos = _turnoRepository.GetAll();
                Turno turno = new Turno()
                {
                    Id = turnos.Max(x => x.Id) + 1,
                    Fecha = dtoTurno.Fecha,
                    Horario = dtoTurno.Horario,
                    Hash = dtoTurno.Hash,
                };
                _turnoRepository.Add(turno);

                TurnoResponse response = new TurnoResponse()
                {
                    Id = turnos.Max(x => x.Id) + 1,
                    Fecha = dtoTurno.Fecha,
                    Horario = dtoTurno.Horario,
                    Hash = dtoTurno.Hash,
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
                List<Turno> turnos = _turnoRepository.GetAll();
                List<Sa_Turno_BackEnd.Models.TurnoResponse> response = new List<Sa_Turno_BackEnd.Models.TurnoResponse>();
                foreach (var turno in turnos)
                {
                    response.Add(
                        new Sa_Turno_BackEnd.Models.TurnoResponse()
                        {
                            Id = turno.Id,
                            Fecha = turno.Fecha,
                            Horario = turno.Horario,
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
            return Ok(_turnoRepository.Get(id));
        }

        [HttpDelete]
        [Route("delete/{id}")]
        public IActionResult DeleteTurno(int id)
        {
            try
            {
                List<Turno> turnos = _turnoRepository.DeleteTurno(id);
                List<Sa_Turno_BackEnd.Models.TurnoResponse> response = new List<Sa_Turno_BackEnd.Models.TurnoResponse>();
                foreach (var turno in turnos)
                {
                    response.Add(
                        new Sa_Turno_BackEnd.Models.TurnoResponse()
                        {
                            Id = turno.Id,
                            Fecha = turno.Fecha,
                            Horario = turno.Horario,
                            Hash = turno.Hash
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
