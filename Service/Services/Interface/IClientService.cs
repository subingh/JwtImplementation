using LogIn.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services.Interface
{
    public interface IClientService
    {
        public List<Client> GetClients();
        public Client GetClientById(int id);
        public Client CreateClient(Client client);
        public Client UpdateClient(int id, Client client);
        public bool DeleteClient(int id);
    }
}
