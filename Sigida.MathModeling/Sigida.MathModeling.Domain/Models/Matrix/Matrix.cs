using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sigida.MathModeling.Domain
{
    internal static class Matrix<T>
    {
        public static T[,] Diagonal(int row, int column, T value)
        {
            var matrix = new T[row - 1, column - 1];

            for (int i = 0; i < row - 1; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    if (i == j)
                        matrix[i, j] = value;
                }
            }

            return matrix;
        }
        public static T[,] Diagonal(T[,] matrix, T value)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (i == j)
                        matrix[i, j] = value;
                }
            }

            return matrix;
        }
    }
}
