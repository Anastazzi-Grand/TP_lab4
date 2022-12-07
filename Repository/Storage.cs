using TP_Controller.Repository;

namespace TP_Controller
{
    public static class Storage
    {
        public static ClientStorage ClientStorage { get; } = new ClientStorage();
        public static OrderStorage OrderStorage { get; } = new OrderStorage();
    }
}
