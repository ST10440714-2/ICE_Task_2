using System;
using System.Collections.Generic;
using System.Text;

namespace Ice_Task_2
{
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}");
        }
    }
}
