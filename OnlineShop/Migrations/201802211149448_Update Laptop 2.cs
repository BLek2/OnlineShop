namespace OnlineShop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateLaptop2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Laptops", "Title", c => c.String(nullable: false, maxLength: 250));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Laptops", "Title", c => c.String(nullable: false, maxLength: 50));
        }
    }
}
