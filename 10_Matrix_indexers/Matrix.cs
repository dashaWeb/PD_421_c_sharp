using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Matrix_indexers
{
    internal class Matrix
    {
        int[,] matrix;
        public Matrix(int rows =2, int cols = 2)
        {
            matrix = new int[rows, cols];
        }
        public int this[int r, int c] {
            get => matrix[r,c]; 
            set => matrix[r,c] = value; }
        public override string ToString()
        {
            StringBuilder st = new StringBuilder(100);
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    st.Append($"{matrix[i, j],7}");
                }
                st.AppendLine();
            }
            return st.ToString();
        }
    }
}
