namespace TP_Controller.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public string Order_date { get; set; } 
        public string Status { get; set; } 
        public string Date_of_excution { get; set; }
        public int Payment { get; set; }

        public int ClientId { get; set; } 
        public Client Client { get; set; }
    }
}
