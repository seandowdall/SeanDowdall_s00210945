using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeanDowdall_s00210945
{
    public class RentalProperty
    {
        //properties
        public int ID { get; set; }
        public Enum RentalType { get; set; }
        public string Location { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }

        //Methods
        public void increaseRent_ByPercentage(decimal increasePercent)
        {
            
            Price = Price * (1 + increasePercent);
        }
        public string GetDescription()
        {
            return $"Description: {Description}";
        }
    }//end of RentalProperty Class
    public class RentalData : DbContext
    {
        public RentalData() : base("MyRentalData1003") { }

        public DbSet<RentalProperty> RentalProperties { get; set; }

    }
}
