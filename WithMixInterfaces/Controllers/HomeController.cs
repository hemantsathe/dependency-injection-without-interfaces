using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WithMixInterfaces.Controllers
{
    public class HomeController : Controller
    {
        private readonly OrderService _orderService;

        public HomeController(OrderService orderService)
        {
            _orderService = orderService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> Order()
        {
            ViewBag.OrderStatus = await _orderService.Order();
            return View();
        }
    }
}