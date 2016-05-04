namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FixSkillIdtoINT : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Skills");
            AlterColumn("dbo.Skills", "SkillID", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Skills", "SkillID");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.Skills");
            AlterColumn("dbo.Skills", "SkillID", c => c.String(nullable: false, maxLength: 128));
            AddPrimaryKey("dbo.Skills", "SkillID");
        }
    }
}
