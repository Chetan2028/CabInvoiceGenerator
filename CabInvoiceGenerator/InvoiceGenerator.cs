using System;
using System.Collections.Generic;
using System.Text;

namespace CabInvoiceGenerator
{
    public class InvoiceGenerator
    {
        /// Constants
        public const int MINIMUM_FARE = 5;
        public const int COST_PER_KM = 10;
        public const int COST_PER_TIME = 1;

        public InvoiceGenerator()
        {
            
        }
        /// <summary>
        /// Calculates the fare.
        /// </summary>
        /// <param name="distance">The distance.</param>
        /// <param name="time">The time.</param>
        /// <returns></returns>
        public double CalculateFare(double distance , int time)
        {
            double totalFare = distance * COST_PER_KM + COST_PER_TIME * time;
            return Math.Max(totalFare, MINIMUM_FARE);
        }

        /// <summary>
        /// Calculates the multiple rides.
        /// </summary>
        /// <param name="rides">The rides.</param>
        /// <returns></returns>
        public string CalculateMultipleRides(Ride[] rides)
        {
            double totalFare = 0;
            int totalRides = 0;
            foreach (Ride ride in rides)
            {
                totalFare += CalculateFare(ride.distance, ride.time);
                totalRides++;
            }
            return "Total Number of Rides : " + totalRides + "\nTotal Fare : " + totalFare + "\nAverage Fare Ride : " + totalFare / totalRides;
        }
    }
}
