using NUnit.Framework;
using ProjectEuler;
namespace ProjectEulerTest
{
    public class MutiplesSumTest
    {
        //question 1
        //If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.
        //Find the sum of all the multiples of 3 or 5 below 1000.

        [SetUp]
        public void Setup()
        {
        }

        [TestCase(3, 5, 10, 23)]
        [TestCase(10, 5, 4, 0)]
        [TestCase(15, 5, 5, 0)]
        [TestCase(3, 5, 1000, 233168)]
        public void WillReturnTheSumOfAllNumbers(int num1, int num2, int max, int expected)
        {
           
            Assert.AreEqual(expected, Program.MutiplesSum(num1, num2, max));
        }
    }
}