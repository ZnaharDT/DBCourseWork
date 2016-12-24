namespace QualInstitute.Domain.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DropSalaryColumn : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Teachers", "Salary");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Teachers", "Salary", c => c.Single(nullable: false));
        }
    }
}
