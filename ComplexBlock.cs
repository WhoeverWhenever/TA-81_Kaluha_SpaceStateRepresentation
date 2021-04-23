using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestModel
{
    public class ComplexBlock : BaseBlock
    {
        public List<BaseBlock> Blocks { get; set; }

        public ComplexBlock()
        {
            Blocks = new List<BaseBlock>();
        }

        public override double Calc(double x)
        {
            foreach(var b in Blocks)
            {
                x = b.Calc(x);
            }
            return x;
        }
    }
}
