using System;
using System.Collections.Generic;
using System.Text;

namespace Ice_Task_2
{
    class InvalidInputException : Exception
    {
        public InvalidInputException(string message) : base(message)
        {
        }
    }
}