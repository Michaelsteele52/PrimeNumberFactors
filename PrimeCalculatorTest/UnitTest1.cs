//using System;
//using System.Collections;
//using System.Collections.Generic;
//using CallingMePrime;
//using NUnit.Framework;

//namespace UnitTestProject1
//{
//    [TestFixture]
//    public class ProgramTester
//    {
//        [TestCase(7)]
//        [TestCase(3)]
//        [TestCase(7919)]
//        public void IsPrime_Should_Return_True(int toBeTested)
//        {
//            Assert.IsTrue(.IsPrime(toBeTested));
//        }

//        [TestCase(10)]
//        [TestCase(-3)]
//        [TestCase(376)]
//        [TestCase(1)]
//        [TestCase(0)]
//        public void IsPrime_Number_Should_Return_False(int toBeTested)
//        {
//            var primer = new CallMePrime();
//            Assert.IsFalse(primer.IsPrime(toBeTested));
//        }

//        [TestCase(2551112, new int[]{1275556, 637778,318889,8,4,2})]
//        [TestCase(212, new int[] {106, 53, 4, 2})]
//        [TestCase(2334, new int[] {1167, 778, 389, 6, 3, 2})]
//        [TestCase(234, new int[] {117, 78, 39, 26, 18, 13, 9, 6, 3, 2})]
//        public void GetFactors_Test(int num, int[] expectedFactors)
//        {
//            var factors = new CallMeFactors();
//            List<int> foundFactors = factors.FindFactors(num);
//            int counter = 0;
//            foreach (var item in foundFactors)
//            {
//                Assert.AreEqual(expectedFactors[counter], item);
//                counter++;
//            }
//        }
//        [TestCase(2551112, new int[] { 318889, 2, 2, 2 })]
//        [TestCase(212, new int[] { 53, 2, 2 })]
//        [TestCase(2334, new int[] { 389, 3, 2 })]
//        [TestCase(234, new int[] { 13, 3, 3, 2 })]
//        public void GetPrimeFactors_Test(int num, int[]expectedFactors)
//        {
//            var primefactorfinder = new CallMeFactors();
//            List<int> primeFactors = new List<int>();
//            primeFactors = primefactorfinder.FindFactors(num);
//            CollectionAssert.AreEquivalent(expectedFactors, primeFactors);
//        }
//    }
//} 