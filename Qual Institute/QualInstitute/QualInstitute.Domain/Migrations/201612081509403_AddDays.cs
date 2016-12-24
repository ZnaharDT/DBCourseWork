namespace QualInstitute.Domain.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDays : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.ScheduleItems", "Day", c => c.Byte(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.ScheduleItems", "Day", c => c.String());
        }
    }
}
