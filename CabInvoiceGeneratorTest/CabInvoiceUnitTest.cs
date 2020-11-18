using Microsoft.VisualStudio.TestTools.UnitTesting;
using CabInvoiceGenerator;

namespace CabInvoiceGeneratorTest
{
    [TestClass]
    public class CabInvoiceUnitTest
    {
        private readonly InvoiceGenerator invoiceGenerator = new InvoiceGenerator();

        /// <summary>
        /// Givens the distance time when calculated should return total fare.
        /// </summary>
        [TestMethod]
        public void GivenDistanceTime_WhenCalculated_ShouldReturnTotalFare()
        {
            double distance = 10.5;
            int time = 20;
            double expectedFare = 125;

            double actualFare = invoiceGenerator.CalculateFare(distance, time);

            Assert.AreEqual(expectedFare, actualFare);
        }
    }
}
