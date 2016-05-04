namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addEducIDinProfileandExpIDinProfile : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "EducIDinProfile", c => c.Int(nullable: false));
            AddColumn("dbo.Users", "ExpIDinProfile", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Users", "ExpIDinProfile");
            DropColumn("dbo.Users", "EducIDinProfile");
        }
    }
}
