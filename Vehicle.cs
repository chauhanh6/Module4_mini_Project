using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module4_mini_Project
{
    internal class Vehicle : RentalItem
    {
        public string Type { get; set; }
        public int Year { get; set; }


        public Vehicle(int id, string name, string renterName, double rentPrice, string type, int year)
            : base(id, name, renterName, rentPrice)
        {
            Type = type;
            Year = year;

        }

        public override string ToString()
        {
            return base.ToString() + $", Type: {Type}, Year: {Year}";
        }
    }
}
