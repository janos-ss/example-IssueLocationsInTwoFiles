﻿using System;
using System.Collections.Generic;
using System.Text;

namespace IssueBackdatingExample1
{
    partial class Employee : IDisposable
    {

        public void DoDayActivity()
        {
            Console.WriteLine("Working hard ...");
        }






        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
