using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestModel
{
    public class APBlock : BaseBlock
    {

        public double T { get; set; }

        private double dt;
        private double prev;
        private double max;

        public APBlock(double dt, double T, int max)
        {
            this.dt = dt;
            this.T = T;
            this.max = max;
        }
        public override double Calc(double x)
        {
            var y = (dt * x + T * prev) / (T + dt);
            if (y < 0)
            {
                y = 0;
            }
            else if (y > max)
            {
                y = max;
            }
            prev = y;
            return y;
        }


    }
}
