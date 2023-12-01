using System;
using System.Collections.Generic;
using System.Text;

namespace AttendanceManagementApp.Tests.TestCases
{
    public class TestCaseDto
    {
        public class TestCaseResultDto
        {
            public string MethodName { get; set; }
            public string MethodType { get; set; }
            public int? ActualAttendance { get; set; }
            public int EarnedAttendance { get; set; }
            public string Status { get; set; }
            public bool IsMandatory { get; set; }
            public string ErroMessage { get; set; }
        }

        public class TestResults
        {
            public string TestCaseResults { get; set; } // string format of dictionary object
            public string CustomData { get; set; }  // custom.ih
        }
    }
}
