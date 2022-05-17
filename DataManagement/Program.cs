using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeanDowdall_s00210945;

namespace DataManagement
{
    class Program
    {
        public enum RentalType
        {
            House,
            Flat,
            Share
        }
        
        static void Main(string[] args)
        {
            //problems with database connection - needed to put code in xaml.cs to move on

            RentalData db = new RentalData();

            using (db)
            {
                RentalProperty p1 = new RentalProperty()
                {
                    Price = 400,
                    RentalType = RentalType.Flat,
                    Description = "A modern 1 bedroom apartment located close to the campus." +
                  "  The accomodation comprises of 1 en-suite bedroom with a study area, " +
                  "a small kitchen and a lounge/dining room",
                    Location = "Town Centre"
                };

                RentalProperty p2 = new RentalProperty()
                {
                    Price = 400,
                    RentalType = RentalType.House,
                    Description = "A modern 4 bedroom townhouse located 2 km from the campus. " +
                    "The house has 4 large double bedrooms with ample space for a desk, " +
                    "a large kitchen with all mod cons.  " +
                    "There is also a dining room and a large sitting room",
                    Location = "Ballinode"
                };

                RentalProperty p3 = new RentalProperty()
                {
                    Price = 400,
                    RentalType = RentalType.Share,
                    Description = "1 bedroom available to share in a 3 bedroom house located in the " +
                    "beautiful seaside village of Strandhill.  The property is located on the bus route to " +
                    "IT Sligo with regular buses to and from the campus",
                    Location = "Strandhill"
                };


                Console.WriteLine("Rental Properties have been created");

                //add to games table and save changes

                db.RentalProperties.Add(p1);
                db.RentalProperties.Add(p2);
                db.RentalProperties.Add(p3);


                Console.WriteLine("Rental Properties have been added to table");

                db.SaveChanges();
                Console.WriteLine("Data has been saved to DB, hit enter to continue");
                Console.ReadLine();
            }
        }
    }
}
