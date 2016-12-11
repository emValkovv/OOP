using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefinaClassesTwo
{
    class Matrix<T>
    {
        private T[,] matrix;
        private int rows;
        private int cols;

        public Matrix(int rows, int cols)
        {
            this.matrix = new T[rows, cols];
            this.rows = rows;
            this.cols = cols;
        }

        public T this[int rows, int cols]
        {
            get
            {
                return this.matrix[rows, cols];
            }
            set
            {
                this.matrix[rows, cols] = value;
            }
        }

        public int Row 
        {
            get
            {
                return this.rows;
            } 
            private set 
            {
                this.rows = value; 
            }
        }

        public int Col
        {
            get
            {
                return this.cols;
            }
            private set
            {
                this.cols = value;
            }
        }

        public static Matrix<T> operator +(Matrix<T> m1, Matrix<T> m2)
        {
            if (m1.Col != m2.Col || m1.Row != m2.Row)
            {
                throw new ArgumentException("The matrices must be the same size");
            }
            Matrix<T> result = new Matrix<T>(m1.Row, m1.Col);
            for (int row = 0; row < m1.Row; row++)
            {
                for (int col = 0; col < m1.Col; col++)
                {
                    result[row, col] = (dynamic)m1[row, col] + m2[row, col];
                }
            }

            return result;
        }

        public static Matrix<T> operator -(Matrix<T> m1, Matrix<T> m2)
        {
            if (m1.Col != m2.Col || m1.Row != m2.Row)
            {
                throw new ArgumentException("The matrices must be the same size");
            }
            Matrix<T> result = new Matrix<T>(m1.Row, m1.Col);
            for (int row = 0; row < m1.Row; row++)
            {
                for (int col = 0; col < m1.Col; col++)
                {
                    result[row, col] = (dynamic)m1[row, col] - m2[row, col];
                }
            }

            return result;
        }

        public static Matrix<T> operator *(Matrix<T> m1, Matrix<T> m2)
        {
            if (m1.Col != m2.Col || m1.Row != m2.Row)
            {
                throw new ArgumentException("The matrices must be the same size");
            }
            Matrix<T> result = new Matrix<T>(m1.Row, m1.Col);
            for (int row = 0; row < m1.Row; row++)
            {
                for (int col = 0; col < m1.Col; col++)
                {
                    result[row, col] = (dynamic)m1[row, col] * m2[row, col];
                }
            }

            return result;
        }
    }
}
