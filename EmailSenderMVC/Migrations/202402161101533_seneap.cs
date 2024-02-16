namespace EmailSenderMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class seneap : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.SentEmailAcountParams",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        HostSmtp = c.String(nullable: false),
                        EnableSsl = c.Boolean(nullable: false),
                        Port = c.Int(nullable: false),
                        SenderEmail = c.String(nullable: false),
                        SenderEmailPassword = c.String(nullable: false),
                        UserId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId)
                .Index(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SentEmailAcountParams", "UserId", "dbo.AspNetUsers");
            DropIndex("dbo.SentEmailAcountParams", new[] { "UserId" });
            DropTable("dbo.SentEmailAcountParams");
        }
    }
}
