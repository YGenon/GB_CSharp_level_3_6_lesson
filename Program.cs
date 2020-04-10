using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Создаем 2 матрицы

            CreatMatrix matrix1 = new CreatMatrix(10);
            CreatMatrix matrix2 = new CreatMatrix(10);            

            #endregion

            //Console.ReadKey(true);

            Console.WriteLine("\r\n РЕЗУЛЬТАТ \r\n");             

            Stopwatch SW = new Stopwatch(); // Создаем объект
            SW.Start(); // Запускаем

            Task task = Task.Run(() => Multiplication_matrix(matrix1.new_matrix, matrix2.new_matrix));
            //Multiplication_matrix(matrix1.new_matrix, matrix2.new_matrix);

            SW.Stop();            
            Console.WriteLine("Прошло : " + Convert.ToString(SW.Elapsed.Milliseconds) + " ms \r\n");

            Console.ReadKey(true);

            #region Метод умножения двух матриц

            long[,] Multiplication_matrix(long[,] N, long[,] L)
            {
                long[,] res = new long[N.GetLength(0), N.GetLength(0)];
                for (int row = 0; row < N.GetLength(0); row++)
                {
                    for (int col = 0; col < N.GetLength(1); col++)
                    {
                        Console.Write("{0,4}", res[row, col] = N[row, col] * L[row, col]);                        
                    }
                    Console.WriteLine();
                }
                return res;
            }
            #endregion
        }

    }
}
