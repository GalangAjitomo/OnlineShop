namespace OnlineShop.DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Tbl_CartStatus
    {
        [Key]
        public int CartStatusId { get; set; }

        [StringLength(500)]
        public string CartStatus { get; set; }
    }
}
