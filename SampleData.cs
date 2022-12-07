using TP_Controller.Models;

namespace TP_Controller
{
    public class SampleData
    {
        public static void Initialize(OrderContext context)
        {
            if (!context.Clients.Any())
            {
                context.Clients.AddRange(
                    new Client
                    {
                        Full_Name = "Ivanov Stepan",
                        Adress = "Ryazan, Pushkina street, 46",
                        Telephone = "89663984330"
                    },
                    new Client
                    {
                        Full_Name = "Petrov Ivan",
                        Adress = "Ryazan, Visokovoltnaya street, 55",
                        Telephone = "89035654560"
                    },
                    new Client
                    {
                        Full_Name = "Bulatov Mikhail",
                        Adress = "Ryazan, Pushkina street, 42",
                        Telephone = "89654561235"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
