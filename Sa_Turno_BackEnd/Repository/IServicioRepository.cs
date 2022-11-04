using Sa_Turno_BackEnd.Entitys;

namespace Sa_Turno_BackEnd.Repository
{
    public interface IServicioRepository
    {
        public Servicio? Get(int id);

        public List<Servicio> GetAll();

        public void Add(Servicio servicio);

        public List<Servicio> Delete(int id);

    }
}
