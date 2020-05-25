namespace OnlineShop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class m14 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Tbl_Cart", "Quantity", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Tbl_Cart", "Quantity");
        }
    }
}
