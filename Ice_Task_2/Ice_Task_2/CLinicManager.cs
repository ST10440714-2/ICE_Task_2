using System;
using System.Collections.Generic;
using System.Text;

namespace Ice_Task_2
{
    class ClinicManager : IReport
    {
        public void GenerateReport()
        {
            Console.WriteLine("Clinic report generated successfully.");
        }
    }
}
