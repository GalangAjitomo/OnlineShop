namespace OnlineShop.DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Tbl_Product
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tbl_Product()
        {
            Tbl_Cart = new HashSet<Tbl_Cart>();
        }

        [Key]
        public int ProductId { get; set; }

        [StringLength(500)]
        public string ProductName { get; set; }

        public int? CategoryId { get; set; }

        public bool? IsActive { get; set; }

        public bool? IsDelete { get; set; }

        public DateTime? CreatedDate { get; set; }

        public DateTime? ModifiedDate { get; set; }

        public string Description { get; set; }

        public string ProductImage { get; set; }

        public bool? IsFeatured { get; set; }

        public int? Quantity { get; set; }

        public decimal? Price { get; set; }


        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tbl_Cart> Tbl_Cart { get; set; }

        public virtual Tbl_Category Tbl_Category { get; set; }
    }
}
