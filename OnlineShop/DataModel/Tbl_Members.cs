namespace OnlineShop.DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Tbl_Members
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tbl_Members()
        {
            Tbl_ShippingDetails = new HashSet<Tbl_ShippingDetails>();
        }

        [Key]
        public int MemberId { get; set; }

        [StringLength(200)]
        public string FristName { get; set; }

        [StringLength(200)]
        public string LastName { get; set; }

        [StringLength(200)]
        public string EmailId { get; set; }

        [StringLength(500)]
        public string Password { get; set; }

        public bool? IsActive { get; set; }

        public bool? IsDelete { get; set; }

        public DateTime? CreatedOn { get; set; }

        public DateTime? ModifiedOn { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tbl_ShippingDetails> Tbl_ShippingDetails { get; set; }
    }
}
