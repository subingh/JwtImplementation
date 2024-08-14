using LogIn.Data.Models;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Service.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using WebApplication1.Data;

namespace Service.Services.Implementation
{
    public class ClientService : IClientService
    {
        private readonly ApplicationDbContext _context;
        public ClientService(ApplicationDbContext context)
        {
            _context = context;
        }
        public Client CreateClient(Client client)
        {
            var result = _context.Client.Add(client);
            _context.SaveChanges();
            return result.Entity;
        }

        public bool DeleteClient(int id)
        {
            try
            {
                var result = _context.Client.SingleOrDefault(s => s.Id == id);
                if (result == null)
                {
                    throw new Exception("Client not found");
                }
                _context.Client.Remove(result);
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public Client GetClientById(int id)
        {
            var result = _context.Client.SingleOrDefault(s => s.Id == id);
            return result;
        }

        public List<Client> GetClients()
        {
            var clients = _context.Client.ToList();
            return clients;
        }

        public Client UpdateClient(int id, Client client)
        {
            var result = _context.Client.SingleOrDefault(s => s.Id == id);
            if(result == null)
            {
                throw new Exception("client not found");
            }
            _context.Client.Update(result);
            _context.SaveChanges();
            return result;
        }
    }
}
