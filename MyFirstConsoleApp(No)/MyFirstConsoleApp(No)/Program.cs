using System;

namespace MyFirstConsoleApp_No_
{
    class Program
    {
        static void Main(string[] args)
        {
            OperatorExamples();
        }

        private static void OperatorExamples()
        {
            int p = 2;
            for (int q = 2; q < 32; q = q * 2) 
            {
                while (p < q) 
                {
                    p = p * 2;
                }
                q = p - q;
            }

        }
    }
}
