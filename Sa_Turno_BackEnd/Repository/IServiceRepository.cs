using Sa_Turno_BackEnd.Entitys;

namespace Sa_Turno_BackEnd.Repository
{
    public interface IServiceRepository
    {
        public Service? Get(int id);

        public List<Service> GetAll();

        public void Add(Service service);

        public List<Service> Delete(int id);

    }
}
