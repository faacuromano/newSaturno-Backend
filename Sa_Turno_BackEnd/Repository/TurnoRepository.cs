using Sa_Turno_BackEnd.Entitys;

namespace Sa_Turno_BackEnd.Repository
{
    public class TurnoRepository : ITurnoRepository
    {
        private List<Turno> FakeTurnos = new List<Turno>
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

        public Turno? Get(int id)
        {
            return FakeTurnos.FirstOrDefault(u => u.Id == id);
        }

        public List<Turno> GetAll()
        {
            return FakeTurnos;
        }

        public void Add(Turno turno)
        {
            FakeTurnos.Add(turno);
        }

        public List<Turno> DeleteTurno(int id)
        {
            return FakeTurnos.Where(x => x.Id != id).ToList();

        }

    }
}
