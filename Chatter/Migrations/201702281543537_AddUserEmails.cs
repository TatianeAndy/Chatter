namespace Chatter.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddUserEmails : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Messages", "UserEmail", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Messages", "UserEmail");
        }
    }
}
