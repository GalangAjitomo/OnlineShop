namespace OnlineShop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class m13 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Tbl_Product", "Description", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Tbl_Product", "Description", c => c.DateTime());
        }
    }
}
