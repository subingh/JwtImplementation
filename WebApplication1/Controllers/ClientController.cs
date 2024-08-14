using LogIn.Data.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Service.Services.Interface;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    
    public class ClientController : ControllerBase
    {
        private readonly IClientService _clientService;

        public ClientController(IClientService clientService)
        {
            _clientService = clientService;
        }

        // GET: api/<AuthController>
        [HttpGet]
        public List<Client> Get()
        {
            var clients = _clientService.GetClients();
            return clients;
        }

        // GET api/<ClientController>/5
        [HttpGet("{id}")]
        public Client Get(int id)
        {
            var client = _clientService.GetClientById(id);
            return client;
        }

        // POST api/<ClientController>
        [HttpPost]
        public Client Post([FromBody] Client client)
        {
            var clientDetail = _clientService.CreateClient(client);
            return clientDetail;
        }

        // PUT api/<ClientController>/5
        [HttpPut("{id}")]
        [Authorize]
        public Client Put(int id, [FromBody] Client client)
        {
            var existingclient = _clientService.UpdateClient(id, client);
            return existingclient;
        }

        // DELETE api/<ClientController>/5
        [HttpDelete("{id}")]
        [Authorize]
        public bool Delete(int id)
        {
            var client = _clientService.DeleteClient(id);
            return client;
        }
    }
}
