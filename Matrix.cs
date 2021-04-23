using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestModel
{
    public class Matrix
    {

        public double[,] mass;

        public int N { get; }
        public int M { get; }

        public Matrix(int n, int m)
        {
            this.N = n;
            this.M = m;
            mass = new double[this.N, this.M];
        }

        public double this[int i, int j]
        {
            get { return mass[i, j]; }
            set { mass[i, j] = value; }
        }

        public void log(string message)
        {
            Console.WriteLine(message);
            for (int i = 0; i < this.N; i++)
            {
                for (int j = 0; j < this.M; j++)
                {
                    Console.Write(mass[i, j]);
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
        }

        public static Matrix E(int n)
        {
            Matrix res = new Matrix(n, n);
            for (int i = 0; i < n; i++)
            {
                res[i, i] = 1;
            }
            return res;
        }

        public static Matrix MulScalar(Matrix a, double sclr)
        {
            Matrix res = new Matrix(a.N, a.M);
            for (int i = 0; i < a.N; i++)
            {
                for (int j = 0; j < a.M; j++)
                {
                    res[i, j] = a[i, j] * sclr;
                }
            }
            return res;
        }

        public static Matrix Mul(Matrix a, Matrix b)
        {
            if (a.M != b.N)
            {
                throw new Exception("Wrong dimensions!");
            }
            Matrix res = new Matrix(a.N, b.M);
            for (int i = 0; i < a.N; i++)
            {
                for (int j = 0; j < b.M; j++)
                {
                    for (int k = 0; k < b.N; k++)
                    {
                        res[i, j] += a[i, k] * b[k, j];
                    }
                }
            }
            return res;
        }

        public static Matrix Sum(Matrix a, Matrix b)
        {
            if ((a.N != b.N) || (a.M != b.M))
            {
                throw new Exception("Wrong dimensions!");
            }
            Matrix res = new Matrix(a.N, a.M);
            for (int i = 0; i < a.N; i++)
            {
                for (int j = 0; j < b.M; j++)
                {
                    res[i, j] = a[i, j] + b[i, j];
                }
            }
            return res;
        }

        public static Matrix Sub(Matrix a, Matrix b)
        {
            if ((a.N != b.N) || (a.M != b.M))
            {
                throw new Exception("Wrong dimensions!");
            }
            Matrix res = new Matrix(a.N, a.M);
            for (int i = 0; i < a.N; i++)
            {
                for (int j = 0; j < b.M; j++)
                {
                    res[i, j] = a[i, j] - b[i, j];
                }
            }
            return res;
        }

        public static Matrix operator *(Matrix a, Matrix b)
        {
            return Matrix.Mul(a, b);
        }
        public static Matrix operator *(Matrix a, double b)
        {
            return Matrix.MulScalar(a, b);
        }
        public static Matrix operator +(Matrix a, Matrix b)
        {
            return Matrix.Sum(a, b);
        }
        public static Matrix operator -(Matrix a, Matrix b)
        {
            return Matrix.Sub(a, b);
        }
    }
}
