using Microsoft.AspNetCore.Mvc;
using TP_Controller.Models;

namespace TP_Controller.Controllers
{
    public class OrderController : Controller
    {
        [HttpPut]
        public Order Create(Order order)
        {
            Storage.OrderStorage.Create(order);
            return Storage.OrderStorage.Read(order.OrderId);
        }

        [HttpGet]
        public Order Read(int orderId)
        {
            return Storage.OrderStorage.Read(orderId);
        }

        [HttpPatch]
        public Order Update(int orderId, Order newOrder)
        {
            return Storage.OrderStorage.Update(orderId, newOrder);
        }

        [HttpDelete]
        public bool Delete(int orderId)
        {
            return Storage.OrderStorage.Delete(orderId);
        }

        [HttpGet("Enter")]
        public string Enter(string str)
        {
            return str; //метод входа на сайт
        }
    }
}
