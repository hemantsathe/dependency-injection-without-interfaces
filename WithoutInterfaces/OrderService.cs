using System.Threading.Tasks;

namespace WithoutInterfaces
{
    public class OrderService
    {
        private readonly Logger _logger;
        private readonly Storage _storage;

        public OrderService(Logger logger, Storage storage)
        {
            _logger = logger;
            _storage = storage;
        }

        public async Task<OrderStatus> Order()
        {
            _logger.Log("Doing some ordering logic here...\n");
            await _storage.Save();
            return OrderStatus.Ok;
        }
    }
}