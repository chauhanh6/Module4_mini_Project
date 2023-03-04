using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module4_mini_Project
{
    internal class RentalItem : IRental
    {
        public string RenterName { get; set; }
        public string Name { get; set; }

        public double Price { get; set; }

        public int Id { get; set; }

        public RentalItem(int id, string name, string renterName, double rentPrice)
        {
            Id = id;
            Name = name;
            RenterName = renterName;
            Price = rentPrice;

        }

        public override string ToString()
        {
            return $" Id: {Id}, Name: {Name}, Rent Price: {Price:C}, RenterName: {RenterName}";
        }
    }
}
