namespace RentalCarDomain
{
    public abstract class RentalCar
    {
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public string BodyType { get; set; }
        public string RegistrationNumber { get; set; }
        public double Price { get; set; }
        public bool Borrowed { get; set; }

        // Constructor that takes all six parameters
        public RentalCar(string manufacturer, string model, string bodyType, string registrationNumber, double price, bool borrowed)
        {
            Manufacturer = manufacturer;
            Model = model;
            BodyType = bodyType;
            RegistrationNumber = registrationNumber;
            Price = price;
            Borrowed = borrowed;
        }

        // Constructor that not sets borrowed (default to false)
        public RentalCar(string manufacturer, string model, string bodyType, string registrationNumber, double price)
            : this(manufacturer, model, bodyType, registrationNumber, price, false) { }

        // Constructor that not sets registrationNumber, price and borrowed
        // and default to registrationNumber = "Not Registered", price = 0.00 and borrowed = false
        public RentalCar(string manufacturer, string model, string bodyType)
            : this(manufacturer, model, bodyType, "Not Registered", 0.0, false) { }

        // Method to borrow the car
        public void Borrow()
        {
            if (!Borrowed)
            {
                Borrowed = true;
                Console.WriteLine($"The car {Model} has been borrowed succesfully.");
            }
            else
            {
                Console.WriteLine($"Sorry, {Model} is already borrowed");
            }
        }

        // Method to return the rental car
        public void ReturnRentalCar()
        {
            Borrowed = false;
            Console.WriteLine($"The car {Model} was returned successfully.");
        }

        // Method to change the car price
        public void ChangePrice(double newPrice)
        {
            if (newPrice >= 0)
            {
                Price = newPrice;
                Console.WriteLine($"Price of {Model} has been changed to: $ {Price}");
            }
            else
            {
                Console.WriteLine("Sorry, the price cannot be negative.");
            }
        }

        // Method to check the car price
        public void CheckPrice()
        {
            Console.WriteLine($"The price to rent {Model} is $ {Price} ");
           
        }

        // Method to check if the car is borrowed
        public void CheckBorrowed()
        {
            
                if (Borrowed == true)
                    Console.WriteLine($"The car {Model} is borrowed");
                else
                    Console.WriteLine($"The car {Model} is available"); 
        }

        // Method to display car details
        public void Display()
        {
            Console.WriteLine("********** Rental Car Details **********");
            Console.WriteLine($"Manufacturer: {Manufacturer}");
            Console.WriteLine($"Model: {Model}");
            Console.WriteLine($"BodyType: {BodyType}");
            Console.WriteLine($"Registration Number: {RegistrationNumber}");
            Console.WriteLine($"Price: $ {Price}");
            Console.WriteLine($"Borrowed: {Borrowed}");
            Console.WriteLine("-----------------------------------------");
        }
    }

    
}

