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
                Email = "asd@hotmail.com",
                Nombre = "Facundo Romanmo",
                Password = "12345",
                PhoneNumber = "3415322313",
                Ubication = "Rosario",
                UserName = "facuro",
           },

           new Client
           {
                Id = 2,
                Email = "asd@hotmail.com",
                Nombre = "Facundo Romanmo",
                Password = "12345",
                PhoneNumber = "3415322313",
                Ubication = "Rosario",
                UserName = "aeloh",
            },
           new Client
           {
                Id = 3,
                Email = "asd@hotmail.com",
                Nombre = "Facundo Romanmo",
                Password = "12345",
                PhoneNumber = "3415322313",
                Ubication = "Rosario",
                UserName = "matiruiz",
            },
           new Client
           {
                Id = 4,
                Email = "asd@hotmail.com",
                Nombre = "Facundo Romanmo",
                Password = "12345",
                PhoneNumber = "3415322313",
                Ubication = "Rosario",
                UserName = "soficorva",
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
            return FakeClients.FirstOrDefault(u => u.UserName == username && u.Password == password);
        }

        public List<Client> Delete(int id)
        {
            FakeClients.RemoveAll(x => x.Id == id);
            return FakeClients;

        }
    }
}
