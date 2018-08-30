//using System;
//using System.Collections;
//using System.Collections.Generic;
//using System.Linq;

//namespace CallingMePrime
//{
//    public class CallMeFactors
//    {
//        public List<int> FindFactors(int num)
//        {
//            var primeChecker = new CallMePrime();
//            List<int> listOfFactors = new List<int>();
//            for (int i = num - 1; i > 1; i--)
//            {
//                if (num % i == 0)
//                {
//                    if (primeChecker.IsPrime(i))
//                    {
//                        listOfFactors.Add(i);
//                    }
//                }
//            }
//            return listOfFactors;
//        }

//        //public List<int> xMen(int num)
//        //{

//        //}

//        public List<int> GetFactors(int num)
//        {
//            var listOfFactors = new List<int>();
//            for (int i = num - 1; i > 1; i--)
//            {
//                if (num % i == 0)
//                {
//                    listOfFactors.Add(i);
//                }
//            }
//            return listOfFactors;
//        }
//    }
//}