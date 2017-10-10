using System;
using System.Collections.Generic;
using System.Text;

namespace IssueBackdatingExample1
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.DoDayActivity();
            employee.DoNightActivity();
        }
    }
}
