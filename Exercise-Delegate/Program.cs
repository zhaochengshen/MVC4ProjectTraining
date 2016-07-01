using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_Delegate
{
    class Program
    {
        static void Main(string[] args)
        {
            SimpleMath math = new SimpleMath();

            Compute com = new Compute(math.Add);
            Compute com1 = new Compute(math.Sub);
            Compute com2 = new Compute(math.Multiply);
            Compute com3 = new Compute(math.Divide);

            int result = com(3, 2);

            com += com1;
            int result1 = com(3, 2);

            com += com2;
            int result2 = com(3, 2);

            com += com3;
            int result3 = com(4, 2);


            Console.Write("执行函数结果\n3+2={0};\n3-2={1};\n3*2={2};\n4/2={3};", result, result1, result2, result3);

            Console.ReadKey();
        }
    }

    public delegate int Compute(int n, int m);

    class SimpleMath
    {
        public int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        public int Sub(int num1, int num2)
        {
            return num1 - num2;
        }

        public int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }
        public int Divide(int num1, int num2)
        {
            if (num2 == 0) { return -1; }
            return num1 / num2;
        }
    }
}
