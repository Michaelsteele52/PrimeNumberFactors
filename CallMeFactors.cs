using System;

namespace CallingMePrime
{

    public class CallMeFactors
    {
        public void FindFactors(int factor)
        {
            ArrayList listOfFactors = new ArrayList();
            listOfFactors.Add(factor);
            for (int i = factor - 1; i > 1; i--)
            {
                if (factor % i == 0)
                {
                    listOfFactors.Add(i);
                }
            }
            //foreach factor in listOfFactors
            //{
                
            //}
        }
    }
}
