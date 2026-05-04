using System;
using System.Collections.Generic;
using System.Text;

namespace Ice_Task_2
{
    class Patient : Person
    {
        public int PatientID { get; set; }

        public override void DisplayInfo()
        {
            Console.WriteLine($"ID: {PatientID} | Name: {Name} | Age: {Age}");
        }
    }
}
