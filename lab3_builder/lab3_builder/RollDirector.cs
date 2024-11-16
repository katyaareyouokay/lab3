using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3_builder
{
    internal class RollDirector
    {
        private IRollBuilder builder;

        public RollDirector(IRollBuilder builder)
        {
            this.builder = builder;
        }

        public void ConstructRoll()
        {
            builder.BuildRice();
            builder.BuildFilling();
            builder.BuildTopping();
        }
    }

}
