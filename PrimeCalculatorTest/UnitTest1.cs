using System;
using System.Collections;
using CallingMePrime;
using NUnit.Framework;

namespace UnitTestProject1
{
    [TestFixture]
    public class ProgramTester
    {
        [TestCase(7)]
        [TestCase(3)]
        [TestCase(7919)]
        public void IsPrime_Should_Return_True(int toBeTested)
        {
            var primer = new CallMePrime();
            Assert.IsTrue(primer.IsPrime(toBeTested));
        }

        [TestCase(10)]
        [TestCase(-3)]
        [TestCase(376)]
        [TestCase(1)]
        [TestCase(0)]
        public void IsPrime_Number_Should_Return_False(int toBeTested)
        {
            var primer = new CallMePrime();
            Assert.IsFalse(primer.IsPrime(toBeTested));
        }

        [Test]
        public void Printer_Test()
        {
            var printer = new PrintService();
            printer.Printer(7);
        }

        [TestCase(2551112, new int[] {318889,2,2,2})]
        [TestCase(212, new int[] {53, 2, 2 })]
        [TestCase(2334, new int[] {389, 3, 2 })]
        [TestCase(234, new int[] {13, 3, 3, 2 })]
        public void FindFactors(int testInput, int[] expectedResults)
        {
            var factors = new CallMeFactors();
            ArrayList primeFactors = factors.FindFactors(testInput);
            int counter = 0;
            foreach (int item in expectedResults)
            {
                Assert.AreEqual(item, primeFactors[counter]);
                counter++;
            }
        }

        //[TestCase(120), new int[]{}]
    }
} 