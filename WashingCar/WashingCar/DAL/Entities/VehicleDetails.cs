using System.ComponentModel.DataAnnotations;

namespace WashingCar.DAL.Entities
{
    public class VehicleDetail
    {
        [Key]
        [Required]
        public Guid Id { get; set; }
        public DateTime? CreationDate { get; set; }
        public DateTime? DeliveryDate { get; set; }
    }
}
