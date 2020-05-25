using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlineShop.Models
{
    public class CategoryDetail
    {
        [Key]
        public int CategoryId { get; set; }
        [Required(ErrorMessage ="Category Name is Required")]
        [StringLength(100,ErrorMessage ="Minimum 3 and Maximum 100 characters are allowed",MinimumLength =3)]
        public string CategoryName { get; set; }

        public bool? IsActive { get; set; }

        public bool? IsDelete { get; set; }
    }

    public class ProductDetail
    {
        [Key]
        public int ProductId { get; set; }

        [Required(ErrorMessage = "Product Name is Required")]
        [StringLength(100, ErrorMessage = "Minimum 3 and Maximum 100 characters are allowed", MinimumLength = 3)]
        public string ProductName { get; set; }

        [Required]
        [Range(1,50)]
        public int? CategoryId { get; set; }

        public bool? IsActive { get; set; }

        public bool? IsDelete { get; set; }

        public DateTime? CreatedDate { get; set; }

        public DateTime? ModifiedDate { get; set; }
        [Required(ErrorMessage = "Description is Required")]
        public DateTime? Description { get; set; }

        public string ProductImage { get; set; }

        public bool? IsFeatured { get; set; }
        [Required]
        [Range(typeof(int),"1","500",ErrorMessage ="invalid quantity")]
        public int? Quantity { get; set; }
        [Required]
        [Range(typeof(decimal), "1", "10000000", ErrorMessage = "invalid price")]
        public decimal? Price { get; set; }
        public SelectList Categories { get; set; }
    }
}