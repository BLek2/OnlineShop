namespace OnlineShop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Updatingchangesecreatcombination : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.SecreatCombinations", "SecreatCombination", c => c.String(nullable: false, maxLength: 20));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.SecreatCombinations", "SecreatCombination", c => c.String());
        }
    }
}
