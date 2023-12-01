

using AttendanceManagementApp.DAL.Interrfaces;
using AttendanceManagementApp.DAL.Services;
using AttendanceManagementApp.DAL.Services.Repository;
using AttendanceManagementApp.Models;
using AttendanceManagementApp.Tests.TestCases;
using Moq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;
using Xunit.Abstractions;

namespace AttendanceManagementApp.Tests.TestCases
{
    public class FunctionalTests
    {
        private readonly ITestOutputHelper _output;
        private readonly IAttendanceService _attendanceService;
        private readonly List<Attendance> _attendanceList;
        public readonly Mock<IAttendanceRepository> attendanceservice = new Mock<IAttendanceRepository>();

        private readonly Attendance _attendance;

        private static string type = "Functional";

        public FunctionalTests(ITestOutputHelper output)
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
            _attendanceList = new List<Attendance>
            {
                new Attendance
                {
                    Id = 1,
                    Date = DateTime.Now,
                    EmployeeName = "Jane Doe",
                    IsPresent = true,
                    Notes = "Regular attendance, no issues."
                },
                // Add more Attendance objects if needed
            };

        }


        [Fact]
        public async Task<bool> Testfor_Create_Attendance()
        {
            //Arrange
            var res = false;
            string testName; string status;
            testName = CallAPI.GetCurrentMethodName();

            //Action
            try
            {
                attendanceservice.Setup(repos => repos.CreateAttendance(_attendance)).ReturnsAsync(_attendance);
                var result = await _attendanceService.CreateAttendance(_attendance);
                //Assertion
                if (result != null)
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
        public async Task<bool> Testfor_Update_Attendance()
        {
            //Arrange
            bool res = false;
            string testName; string status;
            testName = CallAPI.GetCurrentMethodName();

            //Action
            try
            {
                attendanceservice.Setup(repos => repos.UpdateAttendance(_attendance)).ReturnsAsync(_attendance);
                var result = await _attendanceService.UpdateAttendance(_attendance);
                if (result != null)
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
        public async Task<bool> Testfor_GetAttendanceById()
        {
            //Arrange
            var res = false;
            int id = 1;
            string testName; string status;
            testName = CallAPI.GetCurrentMethodName();

            //Action
            try
            {
                attendanceservice.Setup(repos => repos.GetAttendanceById(id)).ReturnsAsync(_attendance);
                var result = await _attendanceService.GetAttendanceById(id);
                //Assertion
                if (result != null)
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
        public async Task<bool> Testfor_DeleteAttendanceById()
        {
            //Arrange
            var res = false;
            int id = 1;
            bool response = true;
            string testName; string status;
            testName = CallAPI.GetCurrentMethodName();

            //Action
            try
            {
                attendanceservice.Setup(repos => repos.DeleteAttendanceById(id)).ReturnsAsync(response);
                var result = await _attendanceService.DeleteAttendanceById(id);
                //Assertion
                if (result != null)
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
        public async Task<bool> Testfor_GetAlld()
        {
            //Arrange
            var res = false;
            int id = 1;
            bool response = true;
            string testName; string status;
            testName = CallAPI.GetCurrentMethodName();

            //Action
            try
            {
                attendanceservice.Setup(repos => repos.GetAllAttendances()).Returns(_attendanceList);
                var result =  _attendanceService.GetAllAttendances();
                //Assertion
                if (result != null)
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