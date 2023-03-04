using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module4_mini_Project
{
    internal interface IRental
    {
        int Id { get; set; }
        string Name { get; set; }
        double Price { get; set; }
        string RenterName { get; set; }
    }
}
