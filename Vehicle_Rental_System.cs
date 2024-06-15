using System;

namespace VehicleRentalSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime date = new DateTime(2024, 06, 13);
            string customerName = "John Doe";
            DateTime reservationStart = new DateTime(2024, 06, 03);

            // Example input data
            string vehicleType = "car";
            string vehicleBrand = "Mitsubishi";
            string vehicleModel = "Mirage";
            double vehicleValue = 15000.00;
            int safetyRating = 3;
            int rentalPeriod = 10;
            int riderAge = 24; // relevant for motorcycles
            int driverExperience = 6; // relevant for cargo vans

            double rentalCost = CalculateRentalCost(vehicleType, rentalPeriod);
            double dailyCost = rentalCost / rentalPeriod;
            double insuranceCost = 15.00; 
            double dayInsurance = 1.50; 
            double totalCost = rentalCost + insuranceCost;

            GenerateInvoice(vehicleType, vehicleBrand, vehicleModel, vehicleValue, safetyRating, rentalPeriod, rentalCost, insuranceCost, totalCost, date, customerName, reservationStart, dailyCost, dayInsurance);
        }

        static double CalculateRentalCost(string vehicleType, int rentalPeriod)
        {
            double dailyCost;

            if (rentalPeriod > 7)
            {
                switch (vehicleType.ToLower())
                {
                    case "car":
                        dailyCost = 15;
                        break;
                    case "motorcycle":
                        dailyCost = 10;
                        break;
                    case "cargo van":
                        dailyCost = 40;
                        break;
                    default:
                        throw new ArgumentException("Invalid vehicle type");
                }
            }
            else
            {
                switch (vehicleType.ToLower())
                {
                    case "car":
                        dailyCost = 20;
                        break;
                    case "motorcycle":
                        dailyCost = 15;
                        break;
                    case "cargo van":
                        dailyCost = 50;
                        break;
                    default:
                        throw new ArgumentException("Invalid vehicle type");
                }
            }

            return dailyCost * rentalPeriod;
        }

        static void GenerateInvoice(string vehicleType, string vehicleBrand, string vehicleModel, double vehicleValue, int safetyRating, int rentalPeriod, double rentalCost, double insuranceCost, double totalCost, DateTime date, string customerName, DateTime reservationStart, double dailyCost, double dayInsurance)
        {
            Console.WriteLine($"A {vehicleType} that is valued at {vehicleValue} , and has a security rating of {safetyRating}");
            Console.WriteLine("");
            Console.WriteLine("XXXXXXXXXX");
            Console.WriteLine($"Data: {date}");
            Console.WriteLine($"Customer Name: {customerName}");

            Console.WriteLine($"Rented Vehicle Model: {vehicleBrand} {vehicleModel}");
            Console.WriteLine("");

            Console.WriteLine($"Reservation start date: {reservationStart}");
            Console.WriteLine($"Actual rental days: {rentalPeriod}");
            Console.WriteLine("");

            Console.WriteLine($"Actual Return date: {date}");
            Console.WriteLine($"Actual rental days: {rentalPeriod}");
            Console.WriteLine("");

            Console.WriteLine($"Rental cost per day: ${dailyCost:F2}");
            Console.WriteLine($"Insurance per day: ${dayInsurance:F2}");
            Console.WriteLine("");

            Console.WriteLine($"Total rent: ${rentalCost:F2}");
            Console.WriteLine($"Total insurance: ${insuranceCost:F2}");
            Console.WriteLine($"Total: ${totalCost:F2}");
            Console.WriteLine("XXXXXXXXXX");
        }
    }
}
