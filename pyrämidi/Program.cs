using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pyrämidi
{
    class Program
    {
        static void Main(string[] args)
        {

           
            Console.Write("pyramidi ");
            int num, vali;
            
            {
                
                num = Convert.ToInt32(Console.ReadLine());
                //vali = num ;
                for (int i = 1; i <= num; i++)
                {
                    for (vali = 1; vali <= num ; vali++)
                    {
                        Console.Write("");
                    }
                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write(j);
                    }
                    {
                        Console.WriteLine();
                    }
                }

                Console.ReadKey();
            }

            
        }
    }
}
