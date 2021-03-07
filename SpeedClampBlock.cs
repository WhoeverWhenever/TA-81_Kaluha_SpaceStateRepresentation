using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoTanks
{
    public class SpeedClampBlock : BaseBlock
    {
        private double dt;
        private double maxSpeed;
        private double prev = 0;
        public SpeedClampBlock (double dt, double maxSpeed)
        {
            this.dt = dt;
            this.maxSpeed = maxSpeed;
        }
        public override double Calc(double x)
        {
            var speed = (x - prev) / dt;
           

            if (Math.Abs(speed) > maxSpeed)
            {

                x = maxSpeed * dt + prev;
            }
            prev = x;
            return x;
 
        }
    }
}
