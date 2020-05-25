namespace OnlineShop.DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Tbl_Roles
    {
        [Key]
        public int RoleId { get; set; }

        [StringLength(200)]
        public string RoleName { get; set; }
    }
}
