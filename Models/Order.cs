namespace TP_Controller.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string Date_of_order { get; set; } 
        public string Status_of_order { get; set; } 
        public string Date_of_excution { get; set; }
        public int Payment { get; set; }

        public int ClientId { get; set; } 
        public Client Client { get; set; }
    }
}
