using AttendanceManagementApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace AttendanceManagementApp.DAL.Services.Repository
{
    public class AttendanceRepository : IAttendanceRepository
    {
        private readonly DatabaseContext _dbContext;
        public AttendanceRepository(DatabaseContext dbContext)
        {
            _dbContext = dbContext;
        }


        public async Task<Attendance> CreateAttendance(Attendance expense)
        {
            try
            {
                var result =  _dbContext.Attendances.Add(expense);
                await _dbContext.SaveChangesAsync();
                return expense;
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }

        public async Task<bool> DeleteAttendanceById(long id)
        {
            try
            {
                _dbContext.Attendances.Remove(_dbContext.Attendances.Single(a => a.Id == id));
                _dbContext.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }

        public List<Attendance> GetAllAttendances()
        {
            try
            {
                var result = _dbContext.Attendances.ToList();
                return result;
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }

        public async Task<Attendance> GetAttendanceById(long id)
        {
            try
            {
                return await _dbContext.Attendances.FindAsync(id);
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }

      
        

        public async Task<Attendance> UpdateAttendance(Attendance model)
        {
            var ex = await _dbContext.Attendances.FindAsync(model.Id);
            try
            {
                await _dbContext.SaveChangesAsync();
                return ex;
            }
            catch (Exception exc)
            {
                throw (exc);
            }
        }
    }
}