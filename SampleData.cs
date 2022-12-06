using TP_Controller.Models;

namespace TP_Controller
{
    public class SampleData
    {
        public static void Initialize(ZakazContext context)
        {
            if (!context.Clients.Any())
            {
                context.Clients.AddRange(
                    new Client
                    {
                        Name = "Pizza",
                        Zakaz = "One big pizza",
                        Price = 600
                    },
                    new Client
                    {
                        Name = "Burger",
                        Zakaz = "Two burgers",
                        Price = 400
                    },
                    new Client
                    {
                        Name = "Coca-Cola",
                        Zakaz = "One liter of Coca-Cola",
                        Price = 300
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
