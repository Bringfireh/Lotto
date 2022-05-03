using System;
using System.Collections.Generic;
using System.Linq;
namespace Lotto
{
    class Program
    {
        static void Main(string[] args)
        {
           
                Random random = new Random();
                List<int> arrList = new List<int>();

                for (int i = 1; i <= 50; i++)
                {
                        List<int> tempnum = new List<int>();
                        for (int j = 1; j < 7; j++)
                            {
                    
                                int randnum = random.Next(1,50);
                                //instead of tempnum, you can use arrList in the while for the numbers not to repeat.
                                while (tempnum.Where(x => x.Equals(randnum)).Count()>0)
                                {
                                    randnum = random.Next(1,50);
                                }
                                tempnum.Add(randnum);
                                arrList.Add(randnum);
                                Console.WriteLine(randnum);


                        }
                    Console.WriteLine("-----------------");
                    Console.WriteLine("-----------------");
            }
           
        }
    }
}
