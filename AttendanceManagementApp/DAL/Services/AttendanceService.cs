using AttendanceManagementApp.DAL.Interrfaces;
using AttendanceManagementApp.DAL.Services.Repository;
using AttendanceManagementApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace AttendanceManagementApp.DAL.Services
{
    public class AttendanceService : IAttendanceService
    {
        private readonly IAttendanceRepository _repository;

        public AttendanceService(IAttendanceRepository repository)
        {
            _repository = repository;
        }

        public Task<Attendance> CreateAttendance(Attendance expense)
        {
            return _repository.CreateAttendance(expense);
        }

        public Task<bool> DeleteAttendanceById(long id)
        {
            return _repository.DeleteAttendanceById(id);
        }

        public List<Attendance> GetAllAttendances()
        {
            return _repository.GetAllAttendances();
        }

        public Task<Attendance> GetAttendanceById(long id)
        {
            return _repository.GetAttendanceById(id); ;
        }

        public Task<Attendance> UpdateAttendance(Attendance model)
        {
            return _repository.UpdateAttendance(model);
        }
    }
}