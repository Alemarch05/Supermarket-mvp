using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket_mvp.Models
{
   internal class ProductModel
    {
        [DisplayName("Product Id")]
        public int Id { get; set; }

        [DisplayName("Product Name")]
        [Required(ErrorMessage = "Product name is required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Product name must be between 3 and 50 Characters")]
        public string Name { get; set; }


        [DisplayName("Price")]
        [Range(0.01, double.MaxValue, ErrorMessage = "el precio mayor a 0")]
        [StringLength(200, MinimumLength = 3, ErrorMessage = "Product name must be between 3 and 200 Characters")]
        public decimal Price { get; set; }

        [DisplayName("Product Stock")]
        [Required(ErrorMessage = "Product Stock is required")]
        [RegularExpression(@"^\d+$", ErrorMessage = "Product Stock must be a number")]
        [Range(0, int.MaxValue, ErrorMessage = "Stock must be a non-negative number")]
        public int Stock { get; set; }

        [DisplayName("Category Id")]
        [Required(ErrorMessage = "Category Id is required")]
        public int Category_Id { get; set; }
    }
}
