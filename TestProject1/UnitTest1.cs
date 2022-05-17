using Microsoft.VisualStudio.TestTools.UnitTesting;
using SeanDowdall_s00210945;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void increaseRentByPercentage_Test()
        {
            //ARRANGE
            RentalProperty g1 = new RentalProperty() {Price = 500m };
            decimal expectedPrice = 550m;


            //ACT
            g1.increaseRent_ByPercentage(10m);

            //ASSERT
            Assert.AreEqual(expectedPrice, g1.Price);
        }
    }
}
