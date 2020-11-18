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
        
    }
}
