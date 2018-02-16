namespace OnlineShop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Consoles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false, maxLength: 50),
                        MainImagePath = c.String(nullable: false),
                        AnotherImagesPath = c.String(),
                        CodeOfProduct = c.Int(nullable: false),
                        Warrantly = c.String(nullable: false),
                        Price = c.Int(nullable: false),
                        IsOnStorage = c.Boolean(nullable: false),
                        Count = c.Int(nullable: false),
                        Description = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Laptops",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false, maxLength: 50),
                        MainImagePath = c.String(nullable: false),
                        AnotherImagesPath = c.String(),
                        CodeOfProduct = c.Int(nullable: false),
                        Warrantly = c.String(nullable: false),
                        Price = c.Int(nullable: false),
                        IsOnStorage = c.Boolean(nullable: false),
                        Count = c.Int(nullable: false),
                        Description = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Managers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Email = c.String(),
                        Password = c.String(),
                        DatimeRegister = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.PCs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false, maxLength: 50),
                        MainImagePath = c.String(nullable: false),
                        AnotherImagesPath = c.String(),
                        CodeOfProduct = c.Int(nullable: false),
                        Warrantly = c.String(nullable: false),
                        Price = c.Int(nullable: false),
                        IsOnStorage = c.Boolean(nullable: false),
                        Count = c.Int(nullable: false),
                        Description = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.SecreatCombinations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SecreatCombination = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Smartphones",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false, maxLength: 50),
                        MainImagePath = c.String(nullable: false),
                        AnotherImagesPath = c.String(),
                        CodeOfProduct = c.Int(nullable: false),
                        Warrantly = c.String(nullable: false),
                        Price = c.Int(nullable: false),
                        IsOnStorage = c.Boolean(nullable: false),
                        Count = c.Int(nullable: false),
                        Description = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Tablets",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false, maxLength: 50),
                        MainImagePath = c.String(nullable: false),
                        AnotherImagesPath = c.String(),
                        CodeOfProduct = c.Int(nullable: false),
                        Warrantly = c.String(nullable: false),
                        Price = c.Int(nullable: false),
                        IsOnStorage = c.Boolean(nullable: false),
                        Count = c.Int(nullable: false),
                        Description = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Tablets");
            DropTable("dbo.Smartphones");
            DropTable("dbo.SecreatCombinations");
            DropTable("dbo.PCs");
            DropTable("dbo.Managers");
            DropTable("dbo.Laptops");
            DropTable("dbo.Consoles");
        }
    }
}
