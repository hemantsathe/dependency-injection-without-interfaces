using System;
using System.Threading.Tasks;

namespace WithInterfaces
{
    public class OrderService : IOrderService
    {
        private readonly IStorage _storage;

        public OrderService(IStorage storage)
        {
            _storage = storage;
        }

        public async Task<OrderStatus> Order()
        {
            Console.WriteLine("Doing some ordering logic here...");
            await _storage.Save();
            return OrderStatus.Ok;
        }
    }
}