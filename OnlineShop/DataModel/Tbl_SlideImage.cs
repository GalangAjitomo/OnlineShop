namespace OnlineShop.DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Tbl_SlideImage
    {
        [Key]
        public int SlideId { get; set; }

        [StringLength(500)]
        public string SlideTitle { get; set; }

        public string SlideImage { get; set; }
    }
}
