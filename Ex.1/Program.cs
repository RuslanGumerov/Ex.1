using System;

namespace Ex._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[10];
            Random rand = new Random();

            Console.WriteLine("Массив:");

            for (int i = 0; i < num.Length; i++)
            {
                num[i] = rand.Next(20);
                Console.Write(num[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine("\nРезультат проверки на четность: ");
            for (int i = 0; i < num.Length; i++)
            {
                if (num[i] % 2 == 0)
                {
                    Console.WriteLine(num[i] + " Число четное");
                }
                else
                    Console.WriteLine(num[i] + " Число не четное");
            }

            Console.WriteLine("\nРезультат проверки на натуральность: ");

            int n;
            foreach (int x in num)
            {
                n = x;
                bool nat = true;
                for (int i = 2; i < n && n != 0; i++)
                {

                    if (n % i == 0)
                    {
                        nat = false;
                        break;
                    }

                }
                if (nat)
                {
                    Console.WriteLine(n + " Натуральное число");
                }
                else
                    Console.WriteLine(n + " Составное число");
            }

            int sum = 0;
            Console.WriteLine("\nСумма массива:");
            for (int i = 0; i < num.Length; i++)
            {
                sum += num[i];

            }
            Console.Write(sum);
            Console.ReadKey();
        }
    }
}
