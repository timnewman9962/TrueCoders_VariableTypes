using System;

namespace VariableTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!\n");

            string strSample = "This is a sample string";
            int nSample = 10;
            char cSample = 'a';
            bool bSample = true;
            double fSample = 3.14;
            decimal decSample = 3.14159m;

            Console.WriteLine($"Outputting my variables...\n"
                                + $"string: {strSample}\n"
                                + $"int: {nSample}\n"
                                + $"char: {cSample}\n"
                                + $"bool: {bSample}\n"
                                + $"double: {fSample}\n"
                                + $"decimal: {decSample}\n"
                                );
        }
    }
}
