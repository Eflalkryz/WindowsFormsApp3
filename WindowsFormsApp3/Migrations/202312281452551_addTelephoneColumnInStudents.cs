namespace WindowsFormsApp3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addTelephoneColumnInStudents : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Students", "Telephone", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Students", "Telephone");
        }
    }
}
