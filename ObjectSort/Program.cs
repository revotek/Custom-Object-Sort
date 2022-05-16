using System;
using System.Collections.Generic;

namespace CustomObjectSort
{
    class Program
    {
        static void Main(string[] args)
        {
            var item1 = new ModelA
            {
                FirstName = "John",
                LastName = "Espinosa"
            };

            var item2 = new ModelB
            {
                Company = "TestCompany",
                EmployeeNumber = "101",
                Id = "1"
            };

            var item3 = new ModelC
            {
                Address1 = "234 Main St.",
                Address2 = "",
                City = "Vegas"
            };

            var item4 = new ModelA
            {
                FirstName = "Jesse",
                LastName = "Espinoza"
            };

            var item5 = new ModelB
            {
                Company = "MyCompany",
                EmployeeNumber = "231",
                Id = "4"
            };

            var items = new List<PropogateItems>();

            items.Add(new PropogateItems
            {
                Id = 1,
                ItemModel = item3,
                Name = "Item3"
            });

            items.Add(new PropogateItems
            {
                Id = 2,
                ItemModel = item5,
                Name = "Item5"
            });

            items.Add(new PropogateItems
            {
                Id = 3,
                ItemModel = item2,
                Name = "Item2"
            });

            items.Add(new PropogateItems
            {
                Id = 4,
                ItemModel = item1,
                Name = "Item1"
            });

            items.Add(new PropogateItems
            {
                Id = 5,
                ItemModel = item4,
                Name = "Item4"
            }); 

            items.Sort(new CustomComparer());

            foreach (var item in items)
            {
                Console.WriteLine(item.Name);
            }

            Console.Read();
        }
    }
}
