namespace QualInstitute.Domain.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedMonthWork : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TeacherMonthWorks",
                c => new
                    {
                        ItemID = c.Int(nullable: false, identity: true),
                        TeacherID = c.Int(nullable: false),
                        LectureHours = c.Int(nullable: false),
                        PracticeHours = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ItemID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.TeacherMonthWorks");
        }
    }
}
