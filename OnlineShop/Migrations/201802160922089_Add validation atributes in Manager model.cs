namespace OnlineShop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddvalidationatributesinManagermodel : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Managers", "Name", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Managers", "Email", c => c.String(nullable: false));
            AlterColumn("dbo.Managers", "Password", c => c.String(nullable: false, maxLength: 50));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Managers", "Password", c => c.String());
            AlterColumn("dbo.Managers", "Email", c => c.String());
            AlterColumn("dbo.Managers", "Name", c => c.String());
        }
    }
}
