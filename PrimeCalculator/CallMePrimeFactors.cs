//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace CallingMePrime
//{
//    public class CallMePrimeFactors
//    {
//        public List<int> GetPrimeFactor(int num, List<int> primeFactors)
//        {
//            var factorFinder = new CallMeFactors();
//            var primeFinder = new CallMePrime();
//            List<int> listOfFactors =  new List<int>();
//            listOfFactors = factorFinder.GetFactors(num);
//            foreach (int factor in listOfFactors)
//            {
//                if (primeFinder.IsPrime(factor))
//                {
//                    primeFactors.Add(factor);
//                }
//                else
//                {
//                    primeFactors = GetPrimeFactor(factor, primeFactors);
//                }
//            }
//            return primeFactors;
//        }
//    }
//}
