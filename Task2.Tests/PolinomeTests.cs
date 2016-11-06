using NUnit.Framework;
using Task2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2.Tests
{
    [TestFixture()]
    public class PolinomeTests
    {
        [Test()]
        public void EqualsTest()
        {
            Polinome pol1 = new Polinome(1, 2, 3);
            Polinome pol2 = new Polinome(1, 2, 3, 4);

            Polinome expected = new Polinome(2, 4, 6, 4);

            Polinome result = pol1 + pol2;

            Assert.AreEqual(expected, result);
        }

        [Test()]
        public void GetHashCodeTest()
        {
            Assert.Fail();
        }

        [Test()]
        public void PolinomeTest()
        {
            Assert.Fail();
        }

        [Test()]
        public void PolinomeTest1()
        {
            Assert.Fail();
        }

        [Test()]
        public void PolinomeTest2()
        {
            Assert.Fail();
        }

        [Test()]
        public void EqualsTest1()
        {
            Assert.Fail();
        }

        [Test()]
        public void ToStringTest()
        {
            Assert.Fail();
        }
    }
}