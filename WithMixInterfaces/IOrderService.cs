using System.Threading.Tasks;

namespace WithMixInterfaces
{
    public interface IOrderService
    {
        Task<OrderStatus> Order();
    }
}