using System;
using System.Collections.Generic;
using System.Text;

namespace OOP02
{
    internal class Driver
    {
        public int DriverId { get; set; }
        public string FullName { get; set; }
        public string PhoneNumber { get; set; }

        public Driver(int id, string name, string num)
        {
            DriverId = id;
            FullName = name;
            PhoneNumber = num;
        }
    }
}
