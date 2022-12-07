using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TP_Controller.Models;

namespace TP_Controller.Controllers
{
    public class HomeController : Controller
    {
        OrderContext db;
        public HomeController(OrderContext context)
        {
            db = context;
        }
        public IActionResult Index()
        {
            return View(db.Clients.ToList());
        }
   
    }
}