namespace OnlineShop.DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Tbl_MemberRole
    {
        [Key]
        public int MemberRoleID { get; set; }

        public int? memberId { get; set; }

        public int? RoleId { get; set; }
    }
}
