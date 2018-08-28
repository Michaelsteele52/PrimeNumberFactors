using System;
using System.Collections;

namespace CallingMePrime
{
    public class CallMePrime
    {
        static void Main(string[] args)
        {
            var factors = new CallMeFactors();
            var printer = new PrintService();
            ArrayList primeFactors = factors.FindFactors(212);
            foreach(int pf in primeFactors)
            {
                printer.Printer(pf);
            }
            printer.Pause();
        }

        public Boolean IsPrime(int toBeTested)
        {
            int count = 0;
            if (toBeTested > 1)
            {
                for (int i = 2; i < toBeTested; i++)
                {
                    if (toBeTested % i == 0)
                    {
                        count++;
                    }
                }
                if (count == 0)
                {
                    return true;
                }
            }
            return false;
        }
    }
}