using Microsoft.AspNetCore.Mvc;
using WashingCar.Helpers;
using WashingCar.Models;

namespace WashingCar.Controllers
{
    public class ServicesController : Controller
    {

        private readonly IDropDownListHelper _dropDownList;

        public ServicesController(IDropDownListHelper dropDownList)
        {
            _dropDownList = dropDownList;
        }
        public async Task<IActionResult> GetServices()
        {
            return (IActionResult)await _dropDownList.GetDDLServicesAsync();
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
