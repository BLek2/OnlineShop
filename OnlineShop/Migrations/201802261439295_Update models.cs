namespace OnlineShop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Updatemodels : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Consoles", "Title", c => c.String(nullable: false, maxLength: 250));
            AlterColumn("dbo.Consoles", "Warrantly", c => c.Int(nullable: false));
            AlterColumn("dbo.PCs", "Title", c => c.String(nullable: false, maxLength: 250));
            AlterColumn("dbo.PCs", "Warrantly", c => c.Int(nullable: false));
            AlterColumn("dbo.Smartphones", "Title", c => c.String(nullable: false, maxLength: 250));
            AlterColumn("dbo.Smartphones", "Warrantly", c => c.Int(nullable: false));
            AlterColumn("dbo.Tablets", "Title", c => c.String(nullable: false, maxLength: 250));
            AlterColumn("dbo.Tablets", "Warrantly", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Tablets", "Warrantly", c => c.String(nullable: false));
            AlterColumn("dbo.Tablets", "Title", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Smartphones", "Warrantly", c => c.String(nullable: false));
            AlterColumn("dbo.Smartphones", "Title", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.PCs", "Warrantly", c => c.String(nullable: false));
            AlterColumn("dbo.PCs", "Title", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Consoles", "Warrantly", c => c.String(nullable: false));
            AlterColumn("dbo.Consoles", "Title", c => c.String(nullable: false, maxLength: 50));
        }
    }
}
