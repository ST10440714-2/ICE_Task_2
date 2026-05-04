using System;
using System.Collections.Generic;
using System.Text;

namespace Ice_Task_2
{
    class Appointment
    {
        public int PatientID { get; set; }
        public string Date { get; set; }

        public void Display()
        {
            Console.WriteLine($"Patient ID: {PatientID}, Date: {Date}");
        }
    }
}
