using System;

namespace CabInvoiceGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Cab Invoice Generator");
            InvoiceGenerator invoiceGenerator = new InvoiceGenerator();
            Console.WriteLine("Enter the distance");
            double distance =Convert.ToDouble( Console.ReadLine());
            Console.WriteLine("Enter the time");
            int time = Convert.ToInt32(Console.ReadLine());
            double totalFare = invoiceGenerator.CalculateFare(distance,time);
            Console.WriteLine("Total Fare : {0}",totalFare);
        }
    }
}
