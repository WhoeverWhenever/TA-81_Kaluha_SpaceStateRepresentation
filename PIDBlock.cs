using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoTanks
{
    public class PIDBlock : BaseBlock
    {
        public bool IsManual { get; set; }
        public double Umanual { get; set; }

        private double sum = 0;

        private double ki;
        private double min = 0f;
        private double max = 100f;
        private double prev = 0;
        private double dt;

        public double K { get; set; }
      
        public double Ki { get { return ki; } set { ki = value; } }
        public double Ti
        {
            get { return 1 / ki; }
            set
            {
                if (value == 0) throw new DivideByZeroException();
                ki = 1 / value;
            }
        }
        public double Kd { get; set; }
        public PIDBlock(double dt)
        {
            this.dt = dt;
        }
        public PIDBlock(double k, double ki, double kd, double dt)
        {
            this.K = k;
            this.Ki = ki;
            this.Kd = kd;
            this.dt = dt;
        }
        public override double Calc(double x)
        {
            var diff = (x - prev) / dt;
            if (IsManual)
            {
                sum = (Umanual / K - (x + Kd * diff)) / Ki;
            }
            else
            {
                sum += (prev + x) * dt / 2;
                
            }

            var p = K*(x + ki * sum + Kd * diff);

            prev = x;

            if (p > 100) 
            {
                sum = (100 / K - (x + Kd * diff)) / Ki;
                p = 100;
            }
            if (p < 0)
            {
                sum = (x + Kd * diff) / Ki;
                p = 0;
            }
         

            return p;

        }
    }
}
