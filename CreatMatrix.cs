using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    public class CreatMatrix
    {
        public long[,] new_matrix { get; set; }

        public CreatMatrix(int siz_matrix)
        {

            Random random_number = new Random();

            long[,] matrix = new long[siz_matrix, siz_matrix];

            Console.WriteLine("\r\n matrix \r\n");

            for (int i = 0; i < siz_matrix; i++)
            {
                for (int j = 0; j < siz_matrix; j++)
                {
                    Console.Write("{0,4}", matrix[i, j] = random_number.Next(10) + random_number.Next(10));
                    //matrix[i, j] = random_number.Next(10) + random_number.Next(10);
                }
                Console.WriteLine();
                new_matrix = matrix;
            }            
        }        
    }
}

