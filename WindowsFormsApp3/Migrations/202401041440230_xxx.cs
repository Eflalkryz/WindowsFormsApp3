namespace WindowsFormsApp3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class xxx : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Students", "Exam1", c => c.Int(nullable: false));
            AddColumn("dbo.Students", "Exam2", c => c.Int(nullable: false));
            AddColumn("dbo.Students", "Avg", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Students", "Avg");
            DropColumn("dbo.Students", "Exam2");
            DropColumn("dbo.Students", "Exam1");
        }
    }
}
