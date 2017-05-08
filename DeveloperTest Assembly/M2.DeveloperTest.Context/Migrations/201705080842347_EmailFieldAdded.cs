namespace M2.DeveloperTest.Context.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EmailFieldAdded : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Participants", "Email", c => c.String(nullable: false, maxLength: 100));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Participants", "Email");
        }
    }
}
