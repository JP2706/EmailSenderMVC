﻿namespace EmailSenderMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class usertousername : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.AspNetUsers", "Name");
        }
        
        public override void Down()
        {
            AddColumn("dbo.AspNetUsers", "Name", c => c.String(nullable: false));
        }
    }
}
