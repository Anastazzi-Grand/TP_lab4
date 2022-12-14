using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TP_Controller.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace TP_Controller.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientController : ControllerBase
    {
        OrderContext db;
        public ClientController(OrderContext context)
        {
            db = context;
        }
        [HttpPut]
        public Client Create(Client client)
        {
            Storage.ClientStorage.Create(client);
            return Storage.ClientStorage.Read(client.Id);
        }

        [HttpGet]
        public Client Read(int clientId)
        {
            return Storage.ClientStorage.Read(clientId);
        }

        [HttpPatch]
        public Client Update(int clientId, Client newClient)
        {
            return Storage.ClientStorage.Update(clientId, newClient);
        }

        [HttpDelete]
        public bool Delete(int clientId)
        {
            return Storage.ClientStorage.Delete(clientId);
        }

        [HttpGet("Enter")]
        public string Enter(string str)
        {
            return str; //метод входа на сайт
        }
    }
}
