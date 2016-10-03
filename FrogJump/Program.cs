using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrogJump
{
    class Program
    {
        static void Main(string[] args)
        {
            int X = 25;
            int Y = 80;
            int D = 10;
            int result = 1;
            while (X+D < Y)
            {
                X += D;
                result++;
            }
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
