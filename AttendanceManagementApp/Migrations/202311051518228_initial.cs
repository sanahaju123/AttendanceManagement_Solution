namespace AttendanceManagementApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class InitialAttendanceEntry : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AttendanceEntries",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    Date = c.DateTime(nullable: false),
                    EmployeeName = c.String(),
                    IsPresent = c.Boolean(nullable: false),
                    Notes = c.String(),
                })
    .PrimaryKey(t => t.Id);
        }

        public override void Down()
        {
            DropTable("dbo.AttendanceEntries");
        }
    }
}
