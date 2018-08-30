using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CallingMePrime.Source;
using NUnit.Framework;

namespace UnitTestProject1.Source
{
    [TestFixture]
    public class IntHelperTest
    {
        [TestCase(7)]
        [TestCase(3)]
        [TestCase(7919)]
        public void IsPrime_Should_Return_True(int toBeTested)
        {
            Assert.IsTrue(IntHelper.IsPrime(toBeTested));
        }

        [TestCase(10)]
        [TestCase(-3)]
        [TestCase(376)]
        [TestCase(1)]
        [TestCase(0)]
        public void IsPrime_Number_Should_Return_False(int toBeTested)
        {
            Assert.IsFalse(IntHelper.IsPrime(toBeTested));
        }

        [TestCase(132, new [] {1, 2, 3, 4, 6, 11, 12, 22, 33, 44, 66, 132})]
        public void GetAsUniqueFactorList_Should_Match_Expected(int number, int[] expectedFactors)
        {
            int[] factors = IntHelper.GetAsUniqueFactorList(number);
            CollectionAssert.AreEquivalent(expectedFactors, factors);
        }

        [TestCase(132, new [] {1, 2, 3, 4, 6, 11, 12, 22, 33, 44, 66, 132 }, new[] { 2, 2, 3, 11 })]
        public void GetAsPrimeList_Should_Return_Expected(int number, int[] allFactors, int[] expectedPrimeFactors)
        {
            int[] primeFactors = IntHelper.GetAsPrimeNumberFactors(number, allFactors);
            CollectionAssert.AreEquivalent(expectedPrimeFactors, primeFactors);
        }
    }
}
