using System;
using System.Collections.Generic;
using System.Text;

namespace IssueBackdatingExample1
{
    partial class Employee : IDisposable
    {
        public void DoNightActivity()
        {
            Console.WriteLine("PARTY HARD !!!");
        }
    }
}
