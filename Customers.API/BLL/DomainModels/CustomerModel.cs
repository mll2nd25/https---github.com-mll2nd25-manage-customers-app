using System.ComponentModel.DataAnnotations;

namespace Customers.API.BLL.DomainModels
{
    public class CustomerModel
    {
        public int CustomerId { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public string Email { get; set; }

         public bool IsActive { get; set; }

        public DateTime CreatedDT { get; set; }
        
        public DateTime? UpdatedDT { get; set; }

        public string CreatedDTStr => $"{CreatedDT.ToShortDateString()} {CreatedDT.ToShortTimeString()}";
        public string UpdatedDTStr => UpdatedDT != null ? $"{((DateTime)UpdatedDT).ToShortDateString()} {((DateTime)UpdatedDT).ToShortTimeString()}" : "N/A";
    }
}