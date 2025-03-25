using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace manip_matrice
{
    class Function
    {
        public void generateMatrix(int matrix1Dim1, int matrix1Dim2, int matrix2Dim1, int matrix2Dim2, out int[,] matrix1, out int[,] matrix2)
        {
            matrix1 = new int[matrix1Dim1, matrix1Dim2];
            matrix2 = new int[matrix2Dim1, matrix2Dim2];
            Random rand = new Random();

            for (int dim1 = 0; dim1 < matrix1Dim1; dim1++)
            {
                for (int dim2 = 0; dim2 <matrix1Dim2; dim2++)
                {
                    matrix1[dim1, dim2] = rand.Next(10,100);
                }
            }

            for (int dim1 = 0; dim1 < matrix2Dim1; dim1++)
            {
                for (int dim2 = 0; dim2 < matrix2Dim2; dim2++)
                {
                    matrix2[dim1, dim2] = rand.Next(10, 100);
                }
            }
        }

        public void addMatrix(int[,] matrix1, int[,] matrix2, out int[,] finalMatrix)
        {
            finalMatrix = new int[matrix1.GetLength(0), matrix1.GetLength(1)];

            for(int dim1 = 0; dim1 < matrix1.GetLength(0); dim1++)
            {
                for(int dim2 = 0; dim2 < matrix1.GetLength(1); dim2++)
                {
                    finalMatrix[dim1, dim2] = matrix1[dim1, dim2] + matrix2[dim1, dim2];
                }
            }
        }

        public void multiplyMatrix(int[,] matrix1, int[,] matrix2, out int[,] finalMatrix)
        {
            finalMatrix = new int[matrix1.GetLength(0), matrix2.GetLength(1)];

            for(int dim1 = 0; dim1 < matrix1.GetLength(0); dim1++)
            {
                for(int dim2 = 0; dim2 < matrix2.GetLength(1); dim2++)
                {
                    finalMatrix[dim1, dim2] = 0;
                    for(int i=0;i< matrix1.GetLength(1); i++)
                    {
                        finalMatrix[dim1, dim2] += matrix1[dim1, i] * matrix2[i, dim2];
                    }
                }
            }
        }
    }
}
