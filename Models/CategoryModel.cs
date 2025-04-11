using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Supermarket_mvp.Models
{
    internal class CategoryModel
    {
        [DisplayName("Pay Mode Id")]
        public int Id { get; set; }

        [DisplayName("Pay Mode Name")]
        [Required(ErrorMessage = "Pay mode name is required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Pay Mode name must be between 3 and 50 Characters")]
        public string Name { get; set; }


        [DisplayName("Description")]
        [Required(ErrorMessage = "Pay mode Description is required")]
        [StringLength(200, MinimumLength = 3, ErrorMessage = "Pay Mode name must be between 3 and 200 Characters")]
        public string description { get; set; }
    }
}
