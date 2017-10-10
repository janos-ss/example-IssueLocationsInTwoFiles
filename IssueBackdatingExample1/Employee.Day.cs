using System;
using System.Collections.Generic;
using System.Text;

namespace IssueBackdatingExample1
{
    partial class Employee
    {
        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public void DoDayActivity()
        {
            Console.WriteLine("Working hard ...");
        }
    }
}
