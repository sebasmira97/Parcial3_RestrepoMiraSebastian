using Microsoft.AspNetCore.Mvc;

namespace WashingCar.Controllers
{
    public class VehicleController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
