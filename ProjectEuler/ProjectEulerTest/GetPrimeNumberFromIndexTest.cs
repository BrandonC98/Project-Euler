using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using ProjectEuler;

namespace ProjectEulerTest
{
    public class GetPrimeNumberFromIndexTest
    {

        //Question 7
        //By listing the first six prime numbers: 2, 3, 5, 7, 11, and 13, we can see that the 6th prime is 13.
        //What is the 10001st prime number?

        [SetUp]
        public void Setup()
        {
        }

        [TestCase(3, 5)]
        [TestCase(6, 13)]
        [TestCase(10001, 104743)]
        public void WillReturnTheNumberAtPrimeIndex(int index, int expected)
        {

            Assert.AreEqual(expected, Program.GetPrimeNumberFromIndex(index));
        }
       
    }
}