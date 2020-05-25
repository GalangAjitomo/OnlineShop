using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OnlineShop.Models
{
    public class ShippingDetail
    {
        [Key]
        public int ShippingDetailId { get; set; }
        [Required]
        public int? MemberId { get; set; }
        [Required]
        [StringLength(500)]
        public string Adress { get; set; }
        [Required]
        [StringLength(500)]
        public string City { get; set; }
        [Required]
        [StringLength(500)]
        public string State { get; set; }
        [Required]
        [StringLength(50)]
        public string Country { get; set; }
        [Required]
        [StringLength(50)]
        public string ZipCode { get; set; }

        public int? OrderId { get; set; }

        public decimal? AmountPaid { get; set; }
        [Required]
        [StringLength(50)]
        public string PaymentType { get; set; }
    }
}