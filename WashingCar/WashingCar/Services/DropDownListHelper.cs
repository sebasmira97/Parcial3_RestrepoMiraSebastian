using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WashingCar.DAL;
using WashingCar.Helpers;

namespace WashingCar.Services
{
    public class DropDownListHelper :IDropDownListHelper
    {
        private readonly DatabaseContext _context;

        public DropDownListHelper(DatabaseContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<SelectListItem>> GetDDLServicesAsync()
        {
            List<SelectListItem> listServices = await _context.Services
                .Select(s => new SelectListItem
                {
                    Text = s.Name, 
                    Value = s.Id.ToString(),                    
                })
                .OrderBy(s => s.Text)
                .ToListAsync();

            listServices.Insert(0, new SelectListItem
            {
                Text = "Selecione un servicio..",
                Value = Guid.Empty.ToString(), //Cambio el 0 por Guid.Empty ya que debo manejar el mismo tipo de dato en todo el DDL
                Selected = true //Le coloco esta propiedad para que me salga seleccionada por defecto desde la UI
            });

            return listServices;
        }
    }
}
