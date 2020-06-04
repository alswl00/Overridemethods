using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Overridemethos
{
    class Program
    {
        public static int Power(int input)
        {
            return input * input;
        }
        public static int Power(int input, int count)
        {
            int result = 1;
            for (int i = 1; i <= count; i++)
            {
                result *= input;
            }
            return result;
        }
        public static int SumAll(int end)
        {
            int sum = 0;
            for (int i = 1; i < end; i++)
            {
                sum += i;
            }
            return sum;
        }
        public static int SumAll(int start, int end)
        {
            int sum = 0;
            for (int i = start; i < end; i++)
            {
                sum += i;
            }
            return sum;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Power(2));
            Console.WriteLine(Power(2, 10));
            Console.WriteLine(SumAll(10));
            Console.WriteLine(SumAll(4, 10));
        }
    }
}
