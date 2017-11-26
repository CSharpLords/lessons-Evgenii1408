using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args) {
            int  second = 1;
            while (true)
            {
                Console.WriteLine(second);
                Thread.Sleep(1000);

                second=second + 1;
            }

        }
    }
}
 