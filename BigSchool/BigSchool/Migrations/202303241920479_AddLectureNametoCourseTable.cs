namespace BigSchool.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddLectureNametoCourseTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Courses", "LecturerName", c => c.String(nullable: false, maxLength: 255));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Courses", "LecturerName");
        }
    }
}
