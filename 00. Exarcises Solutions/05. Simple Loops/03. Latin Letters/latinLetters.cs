using System;
namespace LatinLetters
{
    class latinLetters
    {
        static void Main()
        {
            string[] letters = { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m",
                                 "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };
            for (int i = 0; i <= 25; i++)
            {
                Console.WriteLine(letters[i]);
            }
        }
    }
}
