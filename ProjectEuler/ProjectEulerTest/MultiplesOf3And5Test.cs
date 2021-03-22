using NUnit.Framework;
using ProjectEuler.Question1;

namespace ProjectEulerTest
{
    public class MultiplesOf3And5Test
    {
        [SetUp]
        public void Setup()
        {



        }

        [Test]
        public void Test1()
        {
            int expected = 233168;
            Assert.AreEqual(expected, Question1.MutiplesOf3And5());
        }
    }
}