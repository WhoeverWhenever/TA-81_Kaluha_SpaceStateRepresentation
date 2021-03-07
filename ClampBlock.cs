using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoTanks
{
    public class ClampBlock : BaseBlock
    {
        private double min;
        private double max;
        public ClampBlock(double min, double max)
        {
            this.min = min;
            this.max = max;
        }


        public override double Calc(double x)
        {
            if (x < min)
            {
                return min;
            }
            if (x > max)
            {
                return max;
            }
            return x;
        }
    }
}
