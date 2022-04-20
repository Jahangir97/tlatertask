using System;

namespace Array3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bir eded daxil edin:");
            int numm = Convert.ToInt32(Console.ReadLine());
            int number;
            if (numm < 50)
            {
                Console.WriteLine("\n3-e boluneededler:");
                int divLen = numm / 3 + 1;
                int[] divisibles3 = new int[divLen];
                for (number = 0; number < numm; number++)
                {
                    int index = number / 3;
                    if (number % 3 == 0)
                    {
                        divisibles3[index] = number;
                        Console.Write(divisibles3[index] + " ");
                    }
                }
            }

            else if (numm > 100)
            {
                Console.WriteLine("\n8-e bolun ededler:");
                int divLen = numm / 8 + 1;
                int[] divisibles8 = new int[divLen];
                for (number = 0; number < numm; number++)
                {
                    int index = number / 8;
                    if (number % 8 == 0)
                    {
                        divisibles8[index] = number;
                        Console.Write(divisibles8[index] + " ");
                    }
                }
            }

            else
            {
                Console.WriteLine("\n5-e bolun ededler:");
                int divLen = numm / 5 + 1;
                int[] divisibles5 = new int[divLen];
                for (number = 0; number < numm; number++)
                {
                    if (number % 5 == 0)
                    {
                        int index = number / 5;
                        divisibles5[index] = number;
                        Console.Write(divisibles5[index] + " ");
                    }
                }
            }
        }
    }
}
