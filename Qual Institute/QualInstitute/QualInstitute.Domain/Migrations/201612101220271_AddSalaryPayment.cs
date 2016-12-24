namespace QualInstitute.Domain.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddSalaryPayment : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.LessonPayments",
                c => new
                    {
                        PaymentID = c.Int(nullable: false, identity: true),
                        Qual = c.Boolean(nullable: false),
                        Rate = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.PaymentID);
            
            DropColumn("dbo.Teachers", "Qual");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Teachers", "Qual", c => c.String());
            DropTable("dbo.LessonPayments");
        }
    }
}
