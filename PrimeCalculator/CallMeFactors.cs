using System;
using System.Collections;
using System.Linq;

namespace CallingMePrime
{
    public class CallMeFactors
    {
        public ArrayList FindFactors(int num)
        {
            var primeChecker = new CallMePrime();
            ArrayList listOfFactors = new ArrayList();
            for (int i = num - 1; i > 1; i--)
            {
                if (num % i == 0)
                {
                    listOfFactors.Add(i);
                    if (!primeChecker.IsPrime(i))
                    {

                    }
                }
            }
            return listOfFactors;
        }

        public ArrayList GetFactors(int num)
        {
            ArrayList listOfFactors = new ArrayList();
            for (int i = num - 1; i > 1; i--)
            {
                if (num % i == 0)
                {
                    listOfFactors.Add(i);
                }
            }
            return listOfFactors;
        }
    }
}