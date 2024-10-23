using Microsoft.VisualStudio.TestTools.UnitTesting;
using RentalCarDomain;
using RentalCarApp;

namespace RentalCarTests
{
    [TestClass]
    public class RentalCarUnitTests
    {
        [TestMethod]
        public void TestBorrowMethod()
        {
            
            var car = new RealRentalCar("Ford", "Focus", "Hatchback", "ASD-123", 45.00);

            
            car.Borrow();

           
            Assert.IsTrue(car.Borrowed);
        }

        [TestMethod]
        public void TestReturnRentalCarMethod()
        {
            
            var car = new RealRentalCar("Ford", "Focus", "Hatchback", "ASD-123", 45.00);
            car.Borrow(); // Borrow first

            
            car.ReturnRentalCar();

            
            Assert.IsFalse(car.Borrowed);
        }

        [TestMethod]
        public void TestChangePrice()
        {
            
            var car = new RealRentalCar("Ford", "Focus", "Hatchback", "ASD-123", 45.00);

           
            car.ChangePrice(60.00);

            
            Assert.AreEqual(60.00, car.Price);
        }
    }
}
