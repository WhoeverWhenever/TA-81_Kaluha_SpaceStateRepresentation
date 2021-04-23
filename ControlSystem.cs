using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestModel
{


    public class ControlSystem
    {

        private double dt;

        private ClampBlock clampInput;
        private SpeedClampBlock spClampInput;
        private ClampBlock clampoutput;
        private DelayBlock delay;
        public SSR SSR1;

        public PIDBlock pid { get; set; }

        public double Time;
        public ComplexBlock Object { get; set; }
        public Matrix Y { get; set; }

        private double valveIn1;
        private double valveIn2;
        private double valve12;
        private double valveOut1;
        public double ValveIn1
        {
            get { return valveIn1; }
            set
            {
                valveIn1 = clampInput.Calc(value);
                pid.Umanual = value;
            }
        }
        public double ValveIn2 { get { return valveIn2; } set { valveIn2 = clampInput.Calc(value); } }
        public double Valve12 { get { return valve12; } set { valve12 = clampInput.Calc(value); } }
        public double ValveOut1 { get { return valveOut1; } set { valveOut1 = clampInput.Calc(value); } }

        public double SetPoint { get; set; }

        private APBlock Tank1;
        private APBlock Tank2;

        private double out1;
        private double out2;

        public double[] a = new double[3];
        public double[] b = new double[3];

        public double Out1 { get { return out1; } }
        public double Out2 { get { return out2; } }

        public ControlSystem(double dt)
        {
            this.dt = dt;
            clampInput = new ClampBlock(0, 100);
            spClampInput = new SpeedClampBlock(dt, 10);

            pid = new PIDBlock(1, 0.02, 0, dt);

            SSR1 = new SSR();
            a = new double[] { 1, 54, 105 };
            b = new double[] { 100.25, 0, 0 };

            SSR1.FromLineDE(a, b, dt);
        }

        public void Calc()
        {

            Time += dt;

            if (!pid.IsManual)
            {
                SSR1.U[0, 0] = pid.Calc(SetPoint - out1);
            }

            Y = SSR1.calcStep();
            out1 = Y[0, 0];

        }
    }

}
