


using AttendanceManagementApp.DAL.Interrfaces;
using AttendanceManagementApp.DAL.Services;
using AttendanceManagementApp.DAL.Services.Repository;
using AttendanceManagementApp.Models;
using Moq;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Xunit.Abstractions;

namespace AttendanceManagementApp.Tests.TestCases
{
    public class ExceptionalTests
    {
        private readonly ITestOutputHelper _output;
        private readonly IAttendanceService _attendanceService;
        public readonly Mock<IAttendanceRepository> attendanceservice = new Mock<IAttendanceRepository>();

        private readonly Attendance _attendance;

        private static string type = "Exception";

        public ExceptionalTests(ITestOutputHelper output)
        {
            _attendanceService = new AttendanceService(attendanceservice.Object);

            _output = output;

            _attendance = new Attendance
            {
                Id = 1,
                Date = DateTime.Now,
                EmployeeName = "Jane Doe",
                IsPresent = true,
                Notes = "Regular attendance, no issues."
            };
        }



        [Fact]
        public async Task<bool> Testfor_Validate_ifInvalidAttendanceIdIsPassed()
        {
            //Arrange
            bool res = false;
            _attendance.Id= 0;
            string testName; string status;
            testName = CallAPI.GetCurrentMethodName();

            //Action
            try
            {
                attendanceservice.Setup(repo => repo.CreateAttendance(_attendance)).ReturnsAsync(_attendance);
                var result = await _attendanceService.CreateAttendance(_attendance);
                if (result != null || result.Id !=0)
                {
                    res = true;
                }
            }
            catch (Exception)
            {
                //Assert
                status = Convert.ToString(res);
                _output.WriteLine(testName + ":Failed");
                await CallAPI.saveTestResult(testName, status, type);
                return false;
            }
            status = Convert.ToString(res);
            if (res == true)
            {
                _output.WriteLine(testName + ":Passed");
            }
            else
            {
                _output.WriteLine(testName + ":Failed");
            }
            await CallAPI.saveTestResult(testName, status, type);
            return res;
        }

        [Fact]
        public async Task<bool> Testfor_Validate_ifInvalidNameIsPassed()
        {
            //Arrange
            bool res = false;
            string testName; string status;
            testName = CallAPI.GetCurrentMethodName();

            //Action
            try
            {
                attendanceservice.Setup(repo => repo.CreateAttendance(_attendance)).ReturnsAsync(_attendance);
                var result = await _attendanceService.CreateAttendance(_attendance);
                if (result != null || result.EmployeeName !=null)
                {
                    res = true;
                }
            }
            catch (Exception)
            {
                //Assert
                status = Convert.ToString(res);
                _output.WriteLine(testName + ":Failed");
                await CallAPI.saveTestResult(testName, status, type);
                return false;
            }
            status = Convert.ToString(res);
            if (res == true)
            {
                _output.WriteLine(testName + ":Passed");
            }
            else
            {
                _output.WriteLine(testName + ":Failed");
            }
            await CallAPI.saveTestResult(testName, status, type);
            return res;
        }

        [Fact]
        public async Task<bool> Testfor_Validate_ifInvalidDateIsPassed()
        {
            //Arrange
            bool res = false;
            string testName; string status;
            testName = CallAPI.GetCurrentMethodName();

            //Action
            try
            {
                attendanceservice.Setup(repo => repo.CreateAttendance(_attendance)).ReturnsAsync(_attendance);
                var result = await _attendanceService.CreateAttendance(_attendance);
                if (result != null || result.Date !=null)
                {
                    res = true;
                }
            }
            catch (Exception)
            {
                //Assert
                status = Convert.ToString(res);
                _output.WriteLine(testName + ":Failed");
                await CallAPI.saveTestResult(testName, status, type);
                return false;
            }
            status = Convert.ToString(res);
            if (res == true)
            {
                _output.WriteLine(testName + ":Passed");
            }
            else
            {
                _output.WriteLine(testName + ":Failed");
            }
            await CallAPI.saveTestResult(testName, status, type);
            return res;
        }

        [Fact]
        public async Task<bool> Testfor_Validate_ifInvalidAttendanceNoteIsPassed()
        {
            //Arrange
            bool res = false;
            _attendance.Notes = "";
            string testName; string status;
            testName = CallAPI.GetCurrentMethodName();

            //Action
            try
            {
                attendanceservice.Setup(repo => repo.CreateAttendance(_attendance)).ReturnsAsync(_attendance);
                var result = await _attendanceService.CreateAttendance(_attendance);
                if (result != null || result.Notes !=null)
                {
                    res = true;
                }
            }
            catch (Exception)
            {
                //Assert
                status = Convert.ToString(res);
                _output.WriteLine(testName + ":Failed");
                await CallAPI.saveTestResult(testName, status, type);
                return false;
            }
            status = Convert.ToString(res);
            if (res == true)
            {
                _output.WriteLine(testName + ":Passed");
            }
            else
            {
                _output.WriteLine(testName + ":Failed");
            }
            await CallAPI.saveTestResult(testName, status, type);
            return res;
        }

        [Fact]
        public async Task<bool> Testfor_Validate_ifInvalidPresentValueIsPassed()
        {
            //Arrange
            bool res = false;
            _attendance.Notes = "";
            string testName; string status;
            testName = CallAPI.GetCurrentMethodName();

            //Action
            try
            {
                attendanceservice.Setup(repo => repo.CreateAttendance(_attendance)).ReturnsAsync(_attendance);
                var result = await _attendanceService.CreateAttendance(_attendance);
                if (result != null || result.IsPresent != null)
                {
                    res = true;
                }
            }
            catch (Exception)
            {
                //Assert
                status = Convert.ToString(res);
                _output.WriteLine(testName + ":Failed");
                await CallAPI.saveTestResult(testName, status, type);
                return false;
            }
            status = Convert.ToString(res);
            if (res == true)
            {
                _output.WriteLine(testName + ":Passed");
            }
            else
            {
                _output.WriteLine(testName + ":Failed");
            }
            await CallAPI.saveTestResult(testName, status, type);
            return res;
        }

    }
}