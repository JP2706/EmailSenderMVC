namespace EmailSenderMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class odbjestdef : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Emails", "Receivers", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Emails", "Receivers", c => c.String());
        }
    }
}
