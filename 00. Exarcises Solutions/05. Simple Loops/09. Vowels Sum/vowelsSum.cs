using System;
namespace VowelsSum
{
    class vowelsSum
    {
        static void Main()
        {
            string input = Console.ReadLine().ToLower();
            int sum = 0;
            for (int i = 0; i < input.Length; i++)
            {
                switch (input[i])
                {
                    case 'a': sum = sum + 1; break;
                    case 'e': sum = sum + 2; break;
                    case 'i': sum = sum + 3; break;
                    case 'o': sum = sum + 4; break;
                    case 'u': sum = sum + 5; break;
                    default:
                        break;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
