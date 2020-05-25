namespace OnlineShop.DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Tbl_Cart
    {
        [Key]
        public int CartId { get; set; }

        public int? ProductId { get; set; }

        public int? MemberId { get; set; }

        public int? CartStatusId { get; set; }

        public int Quantity { get; set; }

        public virtual Tbl_Product Tbl_Product { get; set; }
    }
}
