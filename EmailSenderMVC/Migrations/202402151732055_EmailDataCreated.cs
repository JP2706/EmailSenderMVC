namespace EmailSenderMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EmailDataCreated : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Emails", "CreatedDate", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Emails", "CreatedDate");
        }
    }
}
