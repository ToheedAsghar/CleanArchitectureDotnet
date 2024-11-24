using System.ComponentModel.DataAnnotations;

namespace Core.Entities
{
    public class Customer
    {
        [Required]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string? Name{ get; set; }

        [StringLength(500)]
        public string? Description{ get; set; }
    }
}
