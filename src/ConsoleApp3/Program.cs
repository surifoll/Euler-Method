using System;
using System.Linq;

namespace ConsoleApp3
{/// <summary>
/// Improved Euler Method
/// </summary>
    public class Program
    {
        /// <summary>
        /// Fehintola Suraj Ayodeji
        ///  
        /// 179074142
        /// </summary>
        public void Main(string[] args)
        {
            // ================== Input ===================
            var x = new double[] { 0.5, 0.5, 0.5, 0.5 };
            var y = new double[4]; var y0 = new double[4];double yII2 = 0.0; var lamda = 0.0; var n = 0;
            var A = new[] { new double[] { 10, 7, 8, 7 }, new double[] { 7, 5, 6, 5 }, new double[] { 8, 6, 10, 9 }, new double[] { 7, 5, 9, 10 } };
            //============    Input ==================

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
                    lamda += y[i]*x[i];
                    yII2 += y[i] * y[i];
                }
                for (var i = 0; i < A.Length; i++)
                {
                    x[i] = y[i] / Math.Sqrt(yII2);
                }
                
                Console.WriteLine("###########################################");
                Console.WriteLine($" iteration {n + 1} --- x0 = ({x[0]}), x1 = ({x[1]}) x2 = ({x[2]})   ----- lamda = {lamda} -----  ||Y||2 = {Math.Sqrt(yII2)}   ");
                Console.WriteLine("###########################################");
                n++; lamda = 0;
            }
            Console.ReadLine();

        }
    }
}
