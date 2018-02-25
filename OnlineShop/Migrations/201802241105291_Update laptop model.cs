namespace OnlineShop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Updatelaptopmodel : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Laptops", "Warrantly", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Laptops", "Warrantly", c => c.String(nullable: false));
        }
    }
}
