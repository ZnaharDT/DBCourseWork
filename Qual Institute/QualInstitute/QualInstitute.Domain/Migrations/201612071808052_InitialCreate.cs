namespace QualInstitute.Domain.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Groups",
                c => new
                    {
                        GroupID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        SpecialityID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.GroupID);
            
            CreateTable(
                "dbo.Marks",
                c => new
                    {
                        MarkId = c.Int(nullable: false, identity: true),
                        StudentID = c.Int(nullable: false),
                        SubjectID = c.Int(nullable: false),
                        MarkValue = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.MarkId);
            
            CreateTable(
                "dbo.ScheduleItems",
                c => new
                    {
                        ItemID = c.Int(nullable: false, identity: true),
                        TeacherID = c.Int(nullable: false),
                        SubjectID = c.Int(nullable: false),
                        GroupID = c.Int(nullable: false),
                        Day = c.String(),
                        Time = c.Time(nullable: false, precision: 7),
                    })
                .PrimaryKey(t => t.ItemID);
            
            CreateTable(
                "dbo.Specialities",
                c => new
                    {
                        SpecialityID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        StudyingTime = c.Int(nullable: false),
                        TimesAtYear = c.Int(nullable: false),
                        HasHostel = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.SpecialityID);
            
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        StudentID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Surname = c.String(),
                        Organisation = c.String(),
                        GroupID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.StudentID);
            
            CreateTable(
                "dbo.Subjects",
                c => new
                    {
                        SubjectID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        LectionHours = c.Single(nullable: false),
                        PracticeHours = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.SubjectID);
            
            CreateTable(
                "dbo.Teachers",
                c => new
                    {
                        TeacherID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Surname = c.String(),
                        Salary = c.Single(nullable: false),
                        Qual = c.String(),
                    })
                .PrimaryKey(t => t.TeacherID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Teachers");
            DropTable("dbo.Subjects");
            DropTable("dbo.Students");
            DropTable("dbo.Specialities");
            DropTable("dbo.ScheduleItems");
            DropTable("dbo.Marks");
            DropTable("dbo.Groups");
        }
    }
}
