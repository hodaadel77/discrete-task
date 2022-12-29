using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project._._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2;
            String flag = "prime";
            Console.WriteLine("enter n1");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter n2");
            n2 = int.Parse(Console.ReadLine());
            if (n1 >= 2)
            {
                for (int i = n1; i <= n2; i++)
                {
                    for (int x = 2; x < i; x++)
                    {
                        if (i % x != 0)
                        {
                            flag = "prime";
                        }
                        else
                        {
                            flag = "not prime";
                            break;
                        }
                    }

                    if (flag == "prime")
                    {
                        Console.WriteLine(i);
                    }
                }
            }
            else
            {
                for (int i = 2; i <= n2; i++)
                {
                    for (int x = 2; x < i; x++)
                    {
                        if (i % x != 0)
                        {
                            flag = "prime";
                        }
                        else
                        {
                            flag = "not prime";
                            break;
                        }
                    }

                    if (flag == "prime")
                    {
                        Console.WriteLine(i);
                    }
                }
            }
        }
    }
}
