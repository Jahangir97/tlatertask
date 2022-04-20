using System;

namespace Mod7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" eded daxil edin: ");
            int number = Convert.ToInt32(Console.ReadLine());
            int mod = number % 7;
            int result;
            if (mod > 3)
            {
                result = number + 7 - mod;
                Console.WriteLine(result);
            }
            else if (mod == 0)
            {
                Console.WriteLine("Eded yeddiye qaliqsiz bolunur.");
            }
            else
            {
                result = number - mod;
                Console.WriteLine(result);
            }
        }
    }
}

