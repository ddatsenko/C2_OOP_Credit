using System;

namespace ZalikD
{
    class Program
    {
        static void Main(string[] args)
        {
            Symbols symbols = new Symbols("ASD#ass#");
            Console.WriteLine(symbols.replace());
            Console.WriteLine(symbols.length());
            Numbers numerals = new Numbers("556634563");
            Console.WriteLine(numerals.replace());
            Console.WriteLine(numerals.length());
        }
    }
}