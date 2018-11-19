using System;
using System.Linq;

namespace ConsoleApp2
{/// <summary>
    /// Euler Method
    /// </summary>
    public class Program
    {
        /// <summary>
        /// 
        /// Fehintola Suraj Ayodeji
        /// 
        /// 
        /// 
        /// </summary>
        public void Main(string[] args)
        {
            var x = new double[] { 1, 1, 1 };
            var y = new double[3]; var y0 = new double[3];
            var lamda = Double.MinValue;
            var n = 0;
            var A = new[] { new double[] { 5, -1, 7 }, new double[] { -1, -1, 1 }, new double[] { 7, 1, 5 } };
            while (n < 10)
            {
                for (var i = 0; i < A.Length; i++)
                {
                    for (var j = 0; j < A[i].Length; j++)
                    {
                        y0[j] = A[i][j] * x[j];
                    }
                    y[i] = y0.Sum();
                }
                for (var i = 0; i < A.Length; i++)
                {
                    lamda = (lamda < Math.Abs(y[i])) ? Math.Abs(y[i]) : lamda;
                }
                for (var i = 0; i < A.Length; i++)
                {
                    x[i] = y[i] / lamda;
                }
                Console.WriteLine("###########################################");
                Console.WriteLine($" iteration {n + 1} --- x0 ({x[0]}), x1 ({x[1]}) x2 ({x[2]})   ----- lamda {lamda} -----");
                Console.WriteLine("###########################################");
                n++; lamda = 0;
            }
            Console.ReadLine();

        }
    }
}
