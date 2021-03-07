using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoTanks
{
    public class DelayBlock : BaseBlock
    {
        private int time;
        private Queue<double> q;
        private int capacity;
        private double dt;
        public DelayBlock (double dt, int time)
        {
            this.time = time;
            this.dt = dt;
            capacity = (int)(time / dt);
            q = new Queue<double>(capacity);
        }
        public override double Calc(double x)
        {
            q.Enqueue(x);
            if (q.Count > capacity)
            {
                return q.Dequeue();
            }
            else
            {
                return 0;
            }
        }
    }
}
