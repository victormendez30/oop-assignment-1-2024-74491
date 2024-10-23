using RentalCarDomain;

namespace RentalCarApp
{
    public class RentalCarDriver
    {
        public static void Main(string[] args)
        {


            // Create instances of RentalCar
            RentalCarDomain.RentalCar car1 = new RealRentalCar("Ford", "Focus", "Hatchback", "ASD-123", 45.00);
            RentalCarDomain.RentalCar car2 = new RealRentalCar("Honda", "Civic", "HatchBack", "DDD-888", 50.00);
            RentalCarDomain.RentalCar car3 = new RealRentalCar("Chevrolet", "Camaro", "Convertible", "PAL-007", 70.00);
            RentalCarDomain.RentalCar car4 = new RealRentalCar("Volkswagen", "Multivan", "MPV", "HUD-666", 38.00);


            car1.Display();
            car2.Display();
            car3.Display();
            car4.Display();

            // Call methods
            car1.Borrow();
            car1.ChangePrice(47.00);
            car1.CheckPrice();
            car1.ReturnRentalCar();
            car1.CheckBorrowed();
            car2.CheckBorrowed();
            car2.Borrow();
            car2.CheckBorrowed();
            car3.ChangePrice(65.00);
            car3.CheckPrice();
        }



    }
   //Class not abstract to use
    public class RealRentalCar : RentalCarDomain.RentalCar
        {
            public RealRentalCar(string manufacturer, string model, string bodyType, string registrationNumber, double price)
                : base(manufacturer, model, bodyType, registrationNumber, price) { }

            public RealRentalCar(string manufacturer, string model, string bodyType)
                : base(manufacturer, model, bodyType) { }
        }
    
}
