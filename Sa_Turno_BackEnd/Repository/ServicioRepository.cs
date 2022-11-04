using Sa_Turno_BackEnd.Entitys;


namespace Sa_Turno_BackEnd.Repository
{
    public class ServicioRepository : IServicioRepository
    {
        private List<Servicio> FakeServicios = new List<Servicio>
           {
            new Servicio
            {
             Id = 0,
             Nombre = "Corte de pelo",
             Profesional = "Jorge",
             Cliente = "Pablo",
             Precio = 200

    },
            new Servicio
            {
             Id = 1,
             Nombre = "Carpintero",
             Profesional = "Jorge",
             Cliente = "Pablo",
             Precio = 200
            },
             new Servicio
            {
             Id = 2,
             Nombre = "Dentista",
             Profesional = "Jorge",
             Cliente = "Pablo",
             Precio = 200
            },
           };

        public Servicio? Get(int id)
        {
            return FakeServicios.FirstOrDefault(u => u.Id == id);
        }

        public List<Servicio> GetAll()
        {
            return FakeServicios;
        }

        public void Add(Servicio servicio)
        {
            FakeServicios.Add(servicio);
        }

        public List<Servicio> Delete(int id)
        {
            FakeServicios.RemoveAll(x => x.Id == id);
            return FakeServicios;

        }
    }
}