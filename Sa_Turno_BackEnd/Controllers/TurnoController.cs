using Microsoft.AspNetCore.Mvc;
using Sa_Turno_BackEnd.Entitys;

namespace Sa_Turno_BackEnd.Controllers
{
    [ApiController]
    [Route("turnos")]

    public class TurnoController : ControllerBase
    {
        List<Turno> turnos = new List<Turno>
           {
            new Turno
            {
                  Id = 1,
                  Fecha = "23/11/2022",
                  Horario = "11:30",
                  Hash = "0e90d91d7c53a786eec0873324be56d7d304f4d9",

            },
            new Turno
            {
                  Id = 2,
                  Fecha = "23/11/2022",
                  Horario = "11:30",
                  Hash = "75117759a74ea5803d81105bbf338231cc531628  ",

            },
             new Turno
            {
                  Id = 3,
                  Fecha = "23/11/2022",
                  Horario = "11:30",
                  Hash = "85136c79cbf9fe36bb9d05d0639c70c265c18d37",
            },
           };


        [HttpGet]
        [Route("Listar")]
        public dynamic showTurnos()
        {
            return turnos;
        }


        [HttpPost]
        [Route("save")]
        public dynamic saveTurnos(Turno turno)
        {
            turnos.Add(turno);

            return turnos;
        }

        [HttpDelete]
        [Route("delete/{id}")]
        public dynamic deleteTurno(int id)
        {
            var turno_deleted = turnos.Where(x => x.Id != id).ToList();
            turnos = turno_deleted;
            return turnos;
        }

    }
}
