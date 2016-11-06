using NUnit.Framework;
using Task1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.Tests
{
    [TestFixture()]
    public class CustomerTests
    {
        [TestCase("Name", "Jeffrey Richter")]
        [TestCase("Revenue", "1000000,00")]
        [TestCase("NP", "Jeffrey Richter +1 (425) 555-0100")]
        [TestCase("NPR", "Jeffrey Richter +1 (425) 555-0100 1000000,00")]
        public void ToStringTest(string format, string result)
        {
            Customer customer = new Customer("Jeffrey Richter", "+1 (425) 555-0100", 1000000);
            Assert.AreEqual(customer.ToString(format), result);
        }

        
    }
}