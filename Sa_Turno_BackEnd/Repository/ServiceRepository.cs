using Sa_Turno_BackEnd.Entitys;


namespace Sa_Turno_BackEnd.Repository
{
    public class ServiceRepository : IServiceRepository
    {
        private List<Service> FakeServices = new List<Service>
           {
            new Service
            {
             Id = 0,
             Name = "Corte de pelo",
             Profesional = "Jorge",
             Cliente = "Pablo",
             Price = 200

    },
            new Service
            {
             Id = 1,
             Name = "Carpintero",
             Profesional = "Jorge",
             Cliente = "Pablo",
             Price = 200
            },
             new Service
            {
             Id = 2,
             Name = "Dentista",
             Profesional = "Jorge",
             Cliente = "Pablo",
             Price = 200
            },
           };

        public Service? Get(int id)
        {
            return FakeServices.FirstOrDefault(u => u.Id == id);
        }

        public List<Service> GetAll()
        {
            return FakeServices;
        }

        public void Add(Service servicio)
        {
            FakeServices.Add(servicio);
        }

        public List<Service> Delete(int id)
        {
            FakeServices.RemoveAll(x => x.Id == id);
            return FakeServices;

        }
    }
}