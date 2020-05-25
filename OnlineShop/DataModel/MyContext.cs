namespace OnlineShop.DataModel
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class MyContext : DbContext
    {
        public MyContext()
            : base("name=MyContext")
        {
        }

        public virtual DbSet<Tbl_Cart> Tbl_Cart { get; set; }
        public virtual DbSet<Tbl_CartStatus> Tbl_CartStatus { get; set; }
        public virtual DbSet<Tbl_Category> Tbl_Category { get; set; }
        public virtual DbSet<Tbl_MemberRole> Tbl_MemberRole { get; set; }
        public virtual DbSet<Tbl_Members> Tbl_Members { get; set; }
        public virtual DbSet<Tbl_Product> Tbl_Product { get; set; }
        public virtual DbSet<Tbl_Roles> Tbl_Roles { get; set; }
        public virtual DbSet<Tbl_ShippingDetails> Tbl_ShippingDetails { get; set; }
        public virtual DbSet<Tbl_SlideImage> Tbl_SlideImage { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Tbl_CartStatus>()
                .Property(e => e.CartStatus)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_Category>()
                .Property(e => e.CategoryName)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_Members>()
                .Property(e => e.FristName)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_Members>()
                .Property(e => e.LastName)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_Members>()
                .Property(e => e.EmailId)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_Members>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_Product>()
                .Property(e => e.ProductName)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_Product>()
                .Property(e => e.ProductImage)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_Roles>()
                .Property(e => e.RoleName)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_ShippingDetails>()
                .Property(e => e.Adress)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_ShippingDetails>()
                .Property(e => e.City)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_ShippingDetails>()
                .Property(e => e.State)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_ShippingDetails>()
                .Property(e => e.Country)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_ShippingDetails>()
                .Property(e => e.ZipCode)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_ShippingDetails>()
                .Property(e => e.AmountPaid)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Tbl_ShippingDetails>()
                .Property(e => e.PaymentType)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_SlideImage>()
                .Property(e => e.SlideTitle)
                .IsUnicode(false);

            modelBuilder.Entity<Tbl_SlideImage>()
                .Property(e => e.SlideImage)
                .IsUnicode(false);
        }
    }
}
