using System;
using System.Collections.Generic;
using System.Text;

namespace Ice_Task_2
{
    class WellnessRecord
    {
        public int PatientID { get; set; }
        public string Notes { get; set; }

        public void Display()
        {
            Console.WriteLine($"Patient ID: {PatientID}, Notes: {Notes}");
        }
    }
}
