namespace OnlineShop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class m11 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Tbl_Product", "abcd");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Tbl_Product", "abcd", c => c.Decimal(precision: 18, scale: 2));
        }
    }
}
