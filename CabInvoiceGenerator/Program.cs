using System;

namespace CabInvoiceGenerator
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Cab Invoice Generator");
            InvoiceGenerator invoiceGenerator = new InvoiceGenerator();
            Ride[] rides = new Ride[3];
            rides[0] = new Ride(10, 10);
            rides[1] = new Ride(4.5, 8);
            rides[2] = new Ride(20, 30);
            Console.WriteLine(invoiceGenerator.CalculateMultipleRides(rides));
        }
    }
}
