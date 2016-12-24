namespace QualInstitute.Domain.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddStudyingPlan : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.StudyingPlanItems",
                c => new
                    {
                        ItemID = c.Int(nullable: false, identity: true),
                        SpecialityID = c.Int(nullable: false),
                        SubjectID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ItemID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.StudyingPlanItems");
        }
    }
}
