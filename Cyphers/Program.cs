using System;
using System.Collections.Generic;
namespace Cyphers
{
    class Program
    {
        static void Main(string[] args)
        {
            string txt = "Ahoj sVěTe, Jak sE mÁš?";
            Console.WriteLine(txt.Lowercase());
            //Console.WriteLine(Lowercase(txt));
            Console.WriteLine(txt.CountChars(' '));
            Console.WriteLine(txt.Capitalize());
            Console.WriteLine((new List <string> { "A", "B", "C" }).Join("+"));
            Console.WriteLine((new List<int> { 1, 2, 3 }).Join("+"));
            Console.WriteLine(txt.Cypher((c) => { if (c == ' ') return '+'; else return c; }));
            Console.WriteLine(txt.Cypher((c) => { return (char)((int)c + 3); }));
            Console.WriteLine(txt.Cypher(CypherExtensions.ShiftBy2));
        }
    }
}
