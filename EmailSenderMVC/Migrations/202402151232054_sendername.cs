namespace EmailSenderMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class sendername : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Emails", "SenderName", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Emails", "SenderName");
        }
    }
}
