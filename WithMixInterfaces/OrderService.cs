using System;
using System.Threading.Tasks;

namespace WithMixInterfaces
{
    public class OrderService : IOrderService
    {
        private readonly IStorage _storage;
        private readonly Logger _logger;

        public OrderService(IStorage storage, Logger logger)
        {
            _storage = storage;
            _logger = logger;
        }

        public async Task<OrderStatus> Order()
        {
            _logger.Log("Doing some ordering logic here...\n");
            Console.WriteLine("Doing some ordering logic here...");
            await _storage.Save();
            return OrderStatus.Ok;
        }
    }
}