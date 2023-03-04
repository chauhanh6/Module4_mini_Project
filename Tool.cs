using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module4_mini_Project
{
    internal class Tool : RentalItem
    {
        public string Category { get; set; }

        public Tool(int id, string name, string renterName, double rentPrice, string category)
            : base(id, name, renterName, rentPrice)
        {
            Category = category;
        }

        public override string ToString()
        {
            return base.ToString() + $", Category: {Category}";
        }
    }
}
