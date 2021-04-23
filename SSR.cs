using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestModel
{
    public class SSR
    {

        private Matrix X;
        private Matrix F;
        private Matrix G;

        public Matrix A { get; set; }
        public Matrix B { get; set; }
        public Matrix C { get; set; }
        public Matrix D { get; set; }
        public Matrix U { get; set; }
        public Matrix Y { get; set; }
        public double Time { get; set; }
        public double dt { get; set; }

        public SSR()
        {
            A = new Matrix(1, 1);
            B = new Matrix(1, 1);
            C = new Matrix(1, 1);
            D = new Matrix(1, 1);
            X = new Matrix(1, 1);
            U = new Matrix(1, 1);
            Y = new Matrix(1, 1);
            dt = 1;
        }

        public SSR(Matrix A, Matrix B, Matrix C, Matrix D)
        {
            this.A = A;
            this.B = B;
            this.C = C;
            this.D = D;
            X = new Matrix(1, 1);
            U = new Matrix(1, 1);
            Y = new Matrix(1, 1);
            dt = 1;
        }

        public void FromLineDE(double[] a, double[] b, double dt)
        {
            int n = a.Length - 1;
            int m = b.Length;
            A = new Matrix(n, n);
            B = new Matrix(n, 1);
            C = new Matrix(1, n);
            D = new Matrix(1, 1);
            X = new Matrix(n, 1);
            U = new Matrix(1, 1);
            Y = new Matrix(1, 1);
            this.dt = dt;

            for (int i = 0; i != n - 1; i++)
            {
                A[i, i + 1] = 1;
            }

            for (int j = 0; j != n; j++)
            {
                A[n - 1, j] = -1 * a[j] / a[n];
            }

            B[n - 1, 0] = 1 / a[n];

            for (int i = 0; i != n; i++)
            {
                C[0, i] = (b[i] - a[i] / a[n] * b[n]);
            }

            D[0, 0] = b[n] / a[n];

            A.log("A");
            B.log("B");
            C.log("C");
            toDiscrete();
        }

        private Matrix FMatrix(int cnt)
        {
            double f = 1;
            Matrix R = Matrix.E(A.N);
            Matrix PowA = A;
            for (int i = 1; i != cnt; i++)
            {
                f *= i;
                R += PowA * (Math.Pow(dt, i) / f);
                PowA *= A;
            }
            return R;
        }

        private Matrix GMatrix(int cnt)
        {
            double f = 1;
            Matrix R = Matrix.E(A.N) * dt;
            Matrix PowA = A;
            for (int i = 2; i != cnt + 1; i++)
            {
                f *= i;
                R += PowA * (Math.Pow(dt, i) / f);
                PowA *= A;
            }
            return R * B;
        }

        private void toDiscrete()
        {
            F = FMatrix(3);
            G = GMatrix(3);
            F.log("F");
            G.log("G");
        }

        public Matrix calcStep()
        {
            X = F * X + G * U;
            Y = C * X + D * U;
            Time += dt;
            return Y;
        }

    }
}
