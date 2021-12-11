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
    }
}