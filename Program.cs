using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Xml.Linq;
using System.Drawing;

namespace Module4_mini_Project
{
    internal class Program
    {
        static List<IRental> rentalItems = new List<IRental>();

        static void Main(string[] args)
        {
            static void AllItems()
            {
                Console.WriteLine("All rental items:");
                foreach (IRental item in rentalItems)
                {
                    Console.WriteLine(item.ToString());
                }
            }

            static void AvailableItems()
            {
                Console.WriteLine("All Available rental items:");
                foreach (IRental item in rentalItems)
                {
                    if (String.IsNullOrEmpty(item.RenterName))
                    {
                        Console.WriteLine(item.ToString());
                    }
                }
            }

            static void RentItem()
            {
                Console.Write("Enter the Id of the item to rent: ");

                if (!int.TryParse(Console.ReadLine(), out int itemId))
                {
                    Console.WriteLine("ID can't be blank or must be number");
                    return;
                }


                IRental rentalItem = rentalItems.Find(item => item.Id == itemId);

                if (rentalItem == null)
                {
                    Console.WriteLine("Item not found.");
                    return;
                }


                if (!String.IsNullOrEmpty(rentalItem.RenterName))
                {
                    Console.WriteLine("Item is not available for rent.");
                    return;
                }

                Console.Write("Enter renter's name: ");

                string renterName = Console.ReadLine();

                if (String.IsNullOrEmpty(renterName))
                {
                    Console.WriteLine("Name can't be blank or empty");
                    return;
                }

                rentalItem.RenterName = renterName;
                Console.WriteLine($"Id {rentalItem.Id} Item '{rentalItem.Name}' has been rented.");
            }


            rentalItems.Add(new Vehicle(1, "Car", "", 100.0, "Sedan", 2021));
            rentalItems.Add(new Vehicle(2, "Truck", "", 150.0, "Pickup", 2020));
            rentalItems.Add(new Vehicle(3, "SUV", "", 120.0, "Compact", 2022));
            rentalItems.Add(new Tool(4, "Hammer", "", 5.0, "Hand Tools"));
            rentalItems.Add(new Tool(5, "Saw", "", 10.0, "Hand Tools"));
            rentalItems.Add(new Tool(6, "Drill", "", 20.0, "Power Tools"));
            rentalItems.Add(new RentalItem(7, "Bike", "", 25.0));
            rentalItems.Add(new RentalItem(8, "Kayak", "", 35.0));
            rentalItems.Add(new RentalItem(9, "Tent", "", 40.0));
            rentalItems.Add(new RentalItem(10, "Lawn Mower", "", 30.0));

            int choice = 0;

            do
            {
                Console.Clear();
                Console.WriteLine("*** Rental Agency ***");
                Console.WriteLine("1. List all rental items");
                Console.WriteLine("2. List all available items");
                Console.WriteLine("3. Rent an item");
                Console.WriteLine("4. Exit");
                Console.Write("Please select an option >>");


                if (!int.TryParse(Console.ReadLine(), out int choices))
                {
                    Console.WriteLine("ID can't be blank or must be number");
                    return;
                }

                choice = choices;

                switch (choice)
                {
                    case 1:
                        AllItems();
                        break;
                    case 2:
                        AvailableItems();
                        break;
                    case 3:
                        RentItem();
                        break;
                    case 4:
                        Console.WriteLine("Exiting...");
                        break;
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }

                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
            } while (choice != 4);

        }
    }
}
