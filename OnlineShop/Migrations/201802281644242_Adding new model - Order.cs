namespace OnlineShop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingnewmodelOrder : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ProductName = c.String(),
                        NameCustomer = c.String(),
                        SurnameCustomer = c.String(),
                        PhoneNumber = c.Int(nullable: false),
                        Email = c.String(),
                        City = c.String(),
                        WayToDeliver = c.String(),
                        WayToPay = c.String(),
                        DateTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Orders");
        }
    }
}
