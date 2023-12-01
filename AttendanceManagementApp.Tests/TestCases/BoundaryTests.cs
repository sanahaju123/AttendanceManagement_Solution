

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
    public class BoundaryTests
    {
        private readonly ITestOutputHelper _output;
        private readonly IAttendanceService _attendanceService;
        public readonly Mock<IAttendanceRepository> attendanceservice = new Mock<IAttendanceRepository>();

        private readonly Attendance _attendance;

        private static string type = "Boundary";

        public BoundaryTests(ITestOutputHelper output)
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
        public async Task<bool> Testfor_Attendance_Notes_NotEmpty()
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
                var actualLength = _attendance.Notes.ToString().Length;
                if (result.Notes.ToString().Length == actualLength)
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
        public async Task<bool> Testfor_Attendance_Id_NotEmpty()
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
                var actualLength = _attendance.Id.ToString().Length;
                if (result.Id.ToString().Length == actualLength)
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
        public async Task<bool> Testfor_Attendance_Date_NotEmpty()
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
                var actualLength = _attendance.Date.ToString().Length;
                if (result.Date.ToString().Length == actualLength)
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
        public async Task<bool> Testfor_Attendance_EmployeeName_NotEmpty()
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
                var actualLength = _attendance.EmployeeName.ToString().Length;
                if (result.EmployeeName.ToString().Length == actualLength)
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
        public async Task<bool> Testfor_Attendance_PresentType_NotEmpty()
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
                var actualLength = _attendance.IsPresent.ToString().Length;
                if (result.IsPresent.ToString().Length == actualLength)
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