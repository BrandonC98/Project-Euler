using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using ProjectEuler;

namespace ProjectEulerTest
{
    public class LargestPalindromeTest
    {

        //Question 4
        //A palindromic number reads the same both ways.The largest palindrome made from the product of two 2-digit numbers is 9009 = 91 × 99.
        //Find the largest palindrome made from the product of two 3-digit numbers.


        [SetUp]
        public void Setup()
        {
        }


        [TestCase(2, 9009)]
        [TestCase(1, 9)]
        [TestCase(3, 580085)]
        public void WillReturnTheLargestParlindromeNumberWithTheAmountOfDigits(int digitcount, int expected)
        {

            Assert.AreEqual(expected, Program.LargestPalindrome(digitcount));
                            
        }

    }

}