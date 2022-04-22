using System;

namespace Lotto
{
    class Program
    {
        static void Main(string[] args)
        {
           
                Random random = new Random();
                int[] arrList = new int[50];

                for (int i = 1; i <= 50; i++)
                {
                    for (int j = 1; j < 7; j++)
                    {
                        //int iNum = random.Next(1, 50);

                        arrList[j] = random.Next(1, 50);
                        //Console.WriteLine(random.Next(1, 50).ToString());
                        Console.WriteLine(random.Next(1, 50).ToString());


                }
                    Console.WriteLine("-----------------");
                }
           
        }
    }
}
