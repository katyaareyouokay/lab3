using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3_builder
{
    internal interface IRollBuilder
    {
        void BuildRice();
        void BuildFilling();
        void BuildTopping();
        Roll GetResult();
    }
}

