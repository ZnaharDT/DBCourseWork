namespace QualInstitute.Domain.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddSalaryPayment2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Teachers", "Qual", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Teachers", "Qual");
        }
    }
}
