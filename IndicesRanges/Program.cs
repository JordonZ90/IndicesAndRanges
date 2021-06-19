using System;

namespace IndicesRanges
{
    class Program
    {
        static void Main(string[] args)
        {
            IndicesAndRanges();
        }
        public static void IndicesAndRanges()
        {
            char[] vowels = new char[] { 'a', 'e', 'i', 'o', 'u' };
            char lastElement = vowels[^1];   // u
            char secondToLast = vowels[^2];  // o
            char[] firstTwo = vowels[..2];   // a, e
            char[] lastThree = vowels[..2];  // i, o, u
            char[] middleOne = vowels[2..3]; // i
            char[] lastTwo = vowels[^2..];   // o, u

            Console.WriteLine(lastElement);
            Console.WriteLine(secondToLast);
            Console.WriteLine(firstTwo);
            Console.WriteLine(lastThree);
            Console.WriteLine(middleOne);
            Console.WriteLine(lastTwo);
        }
    }
}
