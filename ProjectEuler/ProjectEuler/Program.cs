using System;
using System.Collections.Generic;

namespace ProjectEuler
{
    public class Program
    {

        public static int MutiplesSum(int mutiple1, int mutiple2, int maxNumber)
        {
            int sum = 0;

            for (int i = 0; i < maxNumber; i++)
            {

                if (i % mutiple1 == 0 || i % mutiple2 == 0) sum += i;

            }

            return sum;

        }

        public static int SmallestEvenlyDivisbleNumberInRange(int lowerBoundry, int higherBoundry)
        {
            var range = GetRange(lowerBoundry, higherBoundry);
            int counter = lowerBoundry;

            while(!IsDivisable(counter, range))
            {

                counter++;

            }

            return counter;

        }

        private static bool IsDivisable(int number, int[] range)
        {

            foreach(int num in range)
            {

                if (number % num != 0) return false;

            }

            return true;

        }

        private static int[] GetRange(int lowerBoundry, int higherBoundry)
        {

            int diff = Math.Abs(lowerBoundry - higherBoundry);

            int[] arr = new int[diff];

            for(int i = 0; i < diff; i++)
            {

                arr[i] = i + lowerBoundry; 

            }

            return arr;

        }

        public static int GetPrimeNumberFromIndex(int index)
        {

            int primeCount = 0;
            int curentNum = 0;

            while(primeCount != index)
            {

                if(IsPrime(curentNum))
                {

                    primeCount++;
                    if (primeCount == index) return curentNum;
                
                }

                curentNum++;

            }

            throw new Exception();           
        }


        public static bool IsPrime(int num)
        {
            if (num <= 1) return false; //can't be a prime number if below 1

            var isPrime = true;

            for (int i = 2; i <= num / 2; i++)
            {
                if (num % i == 0) { //if the remainder is equal to 0 then the number isn't prime
                    isPrime = false;
                    break;
                }
            }   

            return isPrime;

        }

        public static int LargestPalindrome(int digitCount)
        {

            if (digitCount <= 1) return 9;

            int number;
            int reverse = 0;
            int rem;

            int upperNumber = (int)Math.Pow(10, digitCount);
            int lowerNumber = (int)Math.Pow(10, digitCount - 1);

            for (int i = upperNumber - 1; i > lowerNumber; i--)
            {

                for(int n = upperNumber - 1; n > lowerNumber; n--)
                {

                        number = i * n;

                        //reverse number
                        while (number != 0)
                        {

                            rem = number % 10;
                            reverse = reverse * 10 + rem;
                            number /= 10;

                        }

                        if (i * n == reverse) return reverse;
                        reverse = 0;                   
                     
                }

            }

            return 0;

        }


        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


        }

    }

    
}
