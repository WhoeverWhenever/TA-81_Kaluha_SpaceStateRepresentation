using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TwoTanks
{
    public partial class MainForm : Form
    {

        private ControlSystem twoTanks { get; set; }

        private int chartLimit = 100;
        public MainForm()
        {
            InitializeComponent();
            twoTanks = new ControlSystem(1);
        }

        private void tmModeling_Tick(object sender, EventArgs e)
        {
            twoTanks.Calc();
            chPlot.Series[0].Points.AddXY(twoTanks.Time, twoTanks.Out1);
            chPlot.Series[1].Points.AddXY(twoTanks.Time, twoTanks.Out2);

            if (chPlot.Series[0].Points.Count >= chartLimit)
            {
                chPlot.Series[0].Points.RemoveAt(0);
                chPlot.Series[1].Points.RemoveAt(0);
                chPlot.ChartAreas[0].RecalculateAxesScale();
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            tmModeling.Start();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            tmModeling.Stop();
        }

        private void btnX1_Click(object sender, EventArgs e)
        {
            tmModeling.Interval = 1000;
        }

        private void btnX10_Click(object sender, EventArgs e)
        {
            tmModeling.Interval = 100;
        }

        private void btnDownIn1_Click(object sender, EventArgs e)
        {
            twoTanks.ValveIn1--;
            tbValveIn1.Text = twoTanks.ValveIn1.ToString("F2");
        }

        private void btnUpIn1_Click(object sender, EventArgs e)
        {
            twoTanks.ValveIn1++;
            tbValveIn1.Text = twoTanks.ValveIn1.ToString("F2");
        }

        private void tbValveIn1_TextChanged(object sender, EventArgs e)
        {
            double val = 0;
            if(Double.TryParse(tbValveIn1.Text, out val))
            {
                twoTanks.ValveIn1 = val;
                tbValveIn1.Text = twoTanks.ValveIn1.ToString("F2");
            }

        }

        private void tbValveIn2_TextChanged(object sender, EventArgs e)
        {
            double val = 0;
            if (Double.TryParse(tbValveIn2.Text, out val))
            {
                twoTanks.ValveIn2 = val;
                tbValveIn2.Text = twoTanks.ValveIn2.ToString("F2");
            }
        }

        private void tbValve12_TextChanged(object sender, EventArgs e)
        {
            double val = 0;
            if (Double.TryParse(tbValve12.Text, out val))
            {
                twoTanks.Valve12 = val;
                tbValve12.Text = twoTanks.Valve12.ToString("F2");
            }
        }

        private void tbValveOut1_TextChanged(object sender, EventArgs e)
        {
            double val = 0;
            if (Double.TryParse(tbValveOut1.Text, out val))
            {
                twoTanks.ValveOut1 = val;
                tbValveOut1.Text = twoTanks.ValveOut1.ToString("F2");
            }
        }

        private void btnDownIn2_Click(object sender, EventArgs e)
        {
            twoTanks.ValveIn2--;
            tbValveIn2.Text = twoTanks.ValveIn2.ToString("F2");
        }

        private void btnDown12_Click(object sender, EventArgs e)
        {
            twoTanks.Valve12--;
            tbValve12.Text = twoTanks.Valve12.ToString("F2");
        }

        private void btnDownOut1_Click(object sender, EventArgs e)
        {
            twoTanks.ValveOut1--;
            tbValveOut1.Text = twoTanks.ValveOut1.ToString("F2");
        }

        private void btnUpIn2_Click(object sender, EventArgs e)
        {
            twoTanks.ValveIn2++;
            tbValveIn2.Text = twoTanks.ValveIn2.ToString("F2");
        }

        private void btnUp12_Click(object sender, EventArgs e)
        {
            twoTanks.Valve12++;
            tbValve12.Text = twoTanks.Valve12.ToString("F2");
        }

        private void btnUpOut1_Click(object sender, EventArgs e)
        {
            twoTanks.ValveOut1++;
            tbValveOut1.Text = twoTanks.ValveOut1.ToString("F2");
        }
    }
}
