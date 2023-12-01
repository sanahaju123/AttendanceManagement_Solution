using AttendanceManagementApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceManagementApp.DAL.Interrfaces
{
    public interface IAttendanceService
    {
        List<Attendance> GetAllAttendances();
        Task<Attendance> CreateAttendance(Attendance expense);
        Task<Attendance> GetAttendanceById(long id);
        Task<bool> DeleteAttendanceById(long id);
        Task<Attendance> UpdateAttendance(Attendance model);
    }
}
