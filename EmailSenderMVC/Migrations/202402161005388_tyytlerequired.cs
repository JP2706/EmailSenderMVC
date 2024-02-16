namespace EmailSenderMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class tyytlerequired : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Emails", "Title", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Emails", "Title", c => c.String());
        }
    }
}
