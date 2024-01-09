using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Customers.API.DAL.Entity
{
    [Table("Customers", Schema = "dbo")]
    public class Customer : EntityBase
    {
        [Key]
        public int CustomerId { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public string Email { get; set; }

        public bool IsActive { get; set; }

        [Required]
        public DateTime CreatedDT { get; set; }

        public DateTime? UpdatedDT { get; set; }
    }
}