using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WithInterfaces.Controllers
{
    public class HomeController : Controller
    {
        private readonly IOrderService _orderService;

        public HomeController(IOrderService orderService)
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