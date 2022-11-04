using Sa_Turno_BackEnd.Entitys;

namespace Sa_Turno_BackEnd.Repository
{
    public class ClientRepository : IClientRepository
    {
        private List<Client> FakeClients = new List<Client>()
        {
           new Client
           {
                  Id = 1,
                  Username = "faacuromano",
                  Password = "",
                  Nombre = "Facundo Romanmo",
                  Telefono="3415322313",
           },

           new Client
           {
                  Id = 2,
                  Username = "faacuromano",
                  Password = "",
                  Nombre = "Facundo Romanmo",
                  Telefono="3415322313",
            },
           new Client
           {
                  Id = 3,
                  Username = "faacuromano",
                  Password = "",
                  Nombre = "Facundo Romanmo",
                  Telefono="3415322313",
            },
        };

        public Client? Get(int id)
        {
            return FakeClients.FirstOrDefault(u => u.Id == id);
        }

        public List<Client> GetAll()
        {
            return FakeClients;
        }

        public void Add(Client client)
        {
            FakeClients.Add(client);
        }

        public List<Client> Delete(int id)
        {
            return FakeClients.Where(x => x.Id != id).ToList();


        }
    }
}
