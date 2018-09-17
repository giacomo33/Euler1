using System;
using System.Linq;
using Euler1.Extensions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Euler1Test
{
    [TestClass]
    public class Euler1Test
    {
        [TestMethod]
        public void CalculateEuler1_SumNumbersUnder1000_Expected233168()
        {
            //arrange
            int number = 999;

            //act
            int expectedSum = number.GetNumbersMultiple3or5()
                 .Sum();

            //assert
            Assert.IsTrue(expectedSum == 233168);
        }

        [TestMethod]
        public void CalculateEuler1_SumNumberEqual0_Expected0()
        {
            //arrange
            int number = 0;

            //act
            int expectedSum = number.GetNumbersMultiple3or5()
                 .Sum();

            //assert
            Assert.IsTrue(expectedSum == 0);
        }

    }
}
