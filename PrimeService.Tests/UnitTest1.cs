using Microsoft.VisualStudio.TestTools.UnitTesting;
using Prime.Services;

namespace Prime.UnitTests.Services
{
    /// <summary>
    ///  Unit Testing C# with MSTest and .Net using https://docs.microsoft.com/en-us/dotnet/core/testing/unit-testing-with-mstest
    /// </summary>
    // TestClass attribute denotes a class that contains unit tests
    [TestClass]
    public class PrimeService_IsPrimeShould
    {
        private readonly PrimeService _primeService;

        public PrimeService_IsPrimeShould()
        {
            _primeService = new PrimeService();
        }
        // TestMethod attribute indcates a method that is a test method
        [TestMethod]
        public void IsPrime_InputIs1_ReturnFalse()
        {
            bool result = _primeService.IsPrime(1);

            // condition it is checking to be false, message
            Assert.IsFalse(result, "1 should not be prime");
        }

        // You can execute a particular test method with different input arguments
        // datarow allows you to specify values for those inputs
        // this will run 3 tests with the same test method
        [TestMethod]
        [DataRow(-1)]
        [DataRow(0)]
        [DataRow(1)]
        public void IsPrime_ValueLessThan2_ReturnFalse(int value)
        {
            bool result = _primeService.IsPrime(value);
            Assert.IsFalse(result, $"{value} should not be prime");
        }

        [TestMethod]
        [DataRow(2)]
        [DataRow(7)]
        [DataRow(13)]
        public void IsPrime_ValueIsPrime_ReturnTrue(int value)
        {
            bool result = _primeService.IsPrime(value);
            Assert.IsTrue(result, $"{value} should not be prime");
        }

        [TestMethod]
        [DataRow(6)]
        [DataRow(55)]
        [DataRow(100)]
        public void IsPrime_ValueIsNotPrime_ReturnFalse(int value)
        {
            bool result = _primeService.IsPrime(value);
            Assert.IsFalse(result, $"{value} should be prime");
        }
    }
}
