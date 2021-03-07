using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoTanks
{
	public class GainBlock : BaseBlock
	{
		public double Gain { get; set; }

		public GainBlock(double Gain)
		{
			this.Gain = Gain;
		}
		public override double Calc(double x)
		{
			return Gain * x;
		}
	}

}
