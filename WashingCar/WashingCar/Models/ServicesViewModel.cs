using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;
using WashingCar.DAL.Entities;

namespace WashingCar.Models
{
    public class ServicesViewModel : Vehicle
    {
        [Display(Name = "Servicio")]
        //[Range(1, int.MaxValue, ErrorMessage = "Debes de seleccionar un país.")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public Guid ServicesId { get; set; }
        public IEnumerable<SelectListItem> Services { get; set; }

    }
}
