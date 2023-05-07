using System.ComponentModel.DataAnnotations;

namespace WashingCar.DAL.Entities
{
    public class Vehicle
    {
        [Key]
        [Required]
        public Guid Id { get; set; }
        public ICollection<Service> Services { get; set; }
        public string? Owner { get; set; }
        public string? NumberPlate { get; set; }
    }
}
