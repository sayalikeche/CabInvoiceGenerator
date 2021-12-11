using CabInvoiceGenerator;
using NUnit.Framework;

namespace CabInvoiceGeneratorTest
{
    public class Test
    {
        [Test]
        public void GivenDistanceAndTime_WhenACalculate_shouldReturntotalFare()
        {
            InvoiceGenerator invoice = new InvoiceGenerator(5, 2);
            double result = invoice.CalculateCabFare();
            Assert.AreEqual(result, 52);
        }
        [Test]
        public void GivenDistanceAndTime_MultipleRide_WhenACalculate_shoouldReturntotalFare()
        {
            InvoiceGenerator invoice = new InvoiceGenerator();
            Ride[] rides = { new Ride(5, 2), new Ride(7, 2) };
            double expected = invoice.CalculateMultipleRideFair(rides);
            double result = invoice.CalculateMultipleRideFair(rides);
            Assert.AreEqual(result, expected);
        }
    }
}
       


        
    
