using System;

namespace CodeProjectExamples
{
    class Program
    {
        static void Main()
        {
            var s1 = string.Empty;
            const string s2 = "";

            Console.WriteLine($"The Length of s1 is: {s1.Length}");
            Console.WriteLine($"The Length of s2 is: {s2.Length}");
        }
    }
}
