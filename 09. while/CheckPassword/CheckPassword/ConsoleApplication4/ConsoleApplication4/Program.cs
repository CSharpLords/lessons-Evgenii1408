using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
          
        {
            
            for (int n = 1;n <= 9;n = n + 1)
            {
                Console.WriteLine(n+"x7=" + n*7);
                
                Thread.Sleep(1000);

            }
            Console.Read();

        }
        }
    }


