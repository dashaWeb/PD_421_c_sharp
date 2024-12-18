using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Exception
{
    internal class BadProductDateException : ApplicationException
    {
        public DateTime ErrorDate { get; set; }
        public BadProductDateException(string message, DateTime date)
            : base(message)
        {
            ErrorDate = date;
        }
    }
}
