using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket_mvp.Models
{
    internal class CustomerModel
    {
        [DisplayName("Customer Id")]
        public int Id { get; set; }

        [DisplayName("Customer Document")]
        [Required(ErrorMessage = "Customer Document is required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Customer document must be between 3 and 50 Characters")]
        public string Document { get; set; }


        [DisplayName("Customer First Name")]
        [Required(ErrorMessage = "Customer FirstName is required")]
        [StringLength(200, MinimumLength = 3, ErrorMessage = "Customer name must be between 3 and 200 Characters")]

        public string FirstName { get; set; }

        [DisplayName("Customer Last Name")]
        [Required(ErrorMessage = "Customer Last Name is required")]
        [StringLength(200, MinimumLength = 3, ErrorMessage = "Customer name must be between 3 and 200 Characters")]
        public string LastName { get; set; }

        [DisplayName("Customer Address Name")]
        [Required(ErrorMessage = "Customer Address is required")]
        [StringLength(200, MinimumLength = 3, ErrorMessage = "Customer name must be between 3 and 200 Characters")]
        public string Address { get; set; }

        [DisplayName("Customer Bithday")]
        [Required(ErrorMessage = "Customer Birthday is required")]
        [StringLength(200, MinimumLength = 3, ErrorMessage = "Customer Birthday must be between 3 and 200 Characters")]
        public string Birthday { get; set; }

        [DisplayName("Customer Phone Number")]
        [Required(ErrorMessage = "Customer Phone Number is required")]
        [StringLength(200, MinimumLength = 3, ErrorMessage = "Customer Number must be between 3 and 200 Characters")]
        public string Phone { get; set; }

        [DisplayName("Customer Email")]
        [Required(ErrorMessage = "Customer Email is required")]
        [StringLength(200, MinimumLength = 3, ErrorMessage = "Customer Email must be between 3 and 200 Characters")]
        public string Email { get; set; }

    }
}
