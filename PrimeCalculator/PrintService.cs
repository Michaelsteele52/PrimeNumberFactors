using System;

namespace CallingMePrime
{
    public class PrintService
    {
        public void Printer(int numberToPrint)
        {
            Console.WriteLine(numberToPrint);
            Console.ReadKey();
        }

        public void Pause()
        {
            Console.ReadKey();
        }
    }
}