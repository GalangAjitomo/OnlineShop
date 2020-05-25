namespace OnlineShop.DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Tbl_ShippingDetails
    {
        [Key]
        public int ShippingDetailId { get; set; }

        public int? MemberId { get; set; }

        [StringLength(500)]
        public string Adress { get; set; }

        [StringLength(500)]
        public string City { get; set; }

        [StringLength(500)]
        public string State { get; set; }

        [StringLength(50)]
        public string Country { get; set; }

        [StringLength(50)]
        public string ZipCode { get; set; }

        public int? OrderId { get; set; }

        public decimal? AmountPaid { get; set; }

        [StringLength(50)]
        public string PaymentType { get; set; }

        public virtual Tbl_Members Tbl_Members { get; set; }
    }
}
