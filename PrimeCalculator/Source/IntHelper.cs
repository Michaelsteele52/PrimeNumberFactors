using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;

namespace CallingMePrime.Source
{
    public static class IntHelper
    {
        public static bool IsPrime(int number)
        {
            if (number < 2)
            {
                return false;
            }

            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }

            return true;
        }

        public static int[] GetAsUniqueFactorList(int number)
        {
            var factors = new List<int>();
            for (int i = number; i > 0; i--)
            {
                if (number % i == 0)
                {
                    if (!factors.Contains(i))
                    {
                        factors.Add(i);
                    }

                    int otherFactor = number / i;

                    if (!factors.Contains(otherFactor))
                    {
                        factors.Add(otherFactor);
                    }
                }
            }
            return factors.ToArray();
        }

        public static int[] GetAsPrimeNumberFactors(int number, int[] allFactors)
        {
            List<int> primeFactors = allFactors.ToList().Where(IsPrime).ToList();
            var scopedFactors = new List<int>();

            foreach (int primeFactor in primeFactors)
            {
                int currentNumber = number;

                currentNumber = currentNumber / primeFactor;

                while (currentNumber % primeFactor == 0)
                {
                    scopedFactors.Add(primeFactor);
                    currentNumber = currentNumber / primeFactor;
                }
            }

            return primeFactors.Concat(scopedFactors).ToArray();
        }
    }
}