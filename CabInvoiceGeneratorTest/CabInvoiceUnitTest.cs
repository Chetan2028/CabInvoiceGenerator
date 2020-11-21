using Microsoft.VisualStudio.TestTools.UnitTesting;
using CabInvoiceGenerator;

namespace CabInvoiceGeneratorTest
{
    [TestClass]
    public class CabInvoiceUnitTest
    {
        InvoiceGenerator invoiceGenerator = null;

        /// <summary>
        /// Givens the distance and time when analyse should return total fare.
        /// </summary>
        [TestMethod]
        public void GivenDistanceAndTime_WhenAnalyse_ShouldReturnTotalFare()
        {
            //Create instance of invoice generator for normal ride
            invoiceGenerator = new InvoiceGenerator(RideType.NORMAL);
            double distance = 2.0;
            int time = 5;

            //Calculating Fare
            double actualFare = invoiceGenerator.CalculateFare(distance, time);
            double expectedFare = 25;

            //Asserting values
            Assert.AreEqual(expectedFare, actualFare);
        }
        /// <summary>
        /// Givens the multiple rides when analyze should return invoice summary.
        /// </summary>
        [TestMethod]
        public void GivenMultipleRides_WhenAnalyze_ShouldReturnInvoiceSummary()
        {
            //Create instance of invoice generator for normal ride
            invoiceGenerator = new InvoiceGenerator(RideType.NORMAL);
            Ride[] rides = { new Ride(2.0, 5), new Ride(0.1, 1) };

            //Generating Summary for Rides
            InvoiceSummary summary = invoiceGenerator.CalculateFare(rides);
            InvoiceSummary expectedSummary = new InvoiceSummary(2, 30.0);

            //Asserting Values
            Assert.AreEqual(expectedSummary, summary);
        }

        /// <summary>
        /// Givens the multiple rides for premium when analyze should return invoice summary.
        /// </summary>
        [TestMethod]
        public void GivenMultipleRidesForPremium_WhenAnalyze_ShouldReturnInvoiceSummary()
        {
            //Create instance of invoice generator for normal ride
            invoiceGenerator = new InvoiceGenerator(RideType.PREMIUM);
            Ride[] rides = { new Ride(2.0, 5), new Ride(0.1, 1) };

            //Generating Summary for Rides
            InvoiceSummary summary = invoiceGenerator.CalculateFare(rides);
            InvoiceSummary expectedSummary = new InvoiceSummary(2, 60.0);

            //Asserting Values
            Assert.AreEqual(expectedSummary, summary);
        }

        /// <summary>
        /// Test case UC5.2
        /// Givens distance and time it should return premium total fare
        /// </summary>
        [TestMethod]
        public void GivenDistanceAndTime_ItShouldReturnPremiumTotalFare()
        {
            /// Creating Instance of InvoiceGenerator For Normal Ride
            invoiceGenerator = new InvoiceGenerator(RideType.PREMIUM);
            double distance = 2.0;
            int time = 5;
            /// Calculating Fare
            double fare = invoiceGenerator.CalculateFare(distance, time);
            double excepted = 40;
            /// Assert
            Assert.AreEqual(excepted, fare);
        }
    }
}
