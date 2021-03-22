using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using ProjectEuler;

namespace ProjectEulerTest
{
    public class SmallestEvenlyDivisbleNumberInRangeTest
    {

        //Question 5
        //2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder.
        //What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?


        [SetUp]
        public void Setup()
        {
        }


        [TestCase(1, 10, 2520)]
        [TestCase(1, 20, 232792560)]
        public void Test1(int lowerBoundry, int higherBoundry, int expected)
        {

            Assert.AreEqual(expected, Program.SmallestEvenlyDivisbleNumberInRange(lowerBoundry, higherBoundry));

        }

    }
}
