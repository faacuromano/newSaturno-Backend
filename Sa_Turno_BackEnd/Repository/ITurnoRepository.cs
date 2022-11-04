using Sa_Turno_BackEnd.Entitys;

namespace Sa_Turno_BackEnd.Repository
{
    public interface ITurnoRepository
    {
        public Turno? Get(int id);

        public List<Turno> GetAll();

        public void Add(Turno turno);

        public List<Turno> DeleteTurno(int id);
    }
}
