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
                  Username = "facuro",
                  Password = "12345",
                  Nombre = "Facundo Romanmo",
                  Telefono="3415322313",
           },

           new Client
           {
                  Id = 2,
                  Username = "soficorva",
                  Password = "12345",
                  Nombre = "Facundo Romanmo",
                  Telefono="3415322313",
            },
           new Client
           {
                  Id = 3,
                  Username = "matiruiz",
                  Password = "12345",
                  Nombre = "Facundo Romanmo",
                  Telefono="3415322313",
            },
           new Client
           {
                  Id = 4,
                  Username = "aelo",
                  Password = "12345",
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

        public Client? Login(string username, string password)
        {
            return FakeClients.FirstOrDefault(u => u.Username == username && u.Password == password);
        }

        public List<Client> Delete(int id)
        {
            FakeClients.RemoveAll(x => x.Id == id);
            return FakeClients;

        }
    }
}
