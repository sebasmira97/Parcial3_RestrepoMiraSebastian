using System.ComponentModel.DataAnnotations;

namespace WashingCar.DAL.Entities
{
    public class Service
    {
        [Key]
        [Required]
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public double Price { get; set; }
        public ICollection<Vehicle> Vehicles { get; set; }
    }
}
