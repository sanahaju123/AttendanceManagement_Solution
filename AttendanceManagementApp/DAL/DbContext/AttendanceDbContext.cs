
using AttendanceManagementApp.Models;
using System.Data.Entity;


namespace AttendanceManagementApp.DAL
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext() : base("DefaultConnection") { }

        public DbSet<Attendance> Attendances { get; set; }
    }
}