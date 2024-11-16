using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3_builder
{
    internal class CaliforniaRollBuilder : IRollBuilder
    {
        private Roll roll;

        public CaliforniaRollBuilder()
        {
            this.roll = new Roll();
        }

        public void BuildRice()
        {
            roll.SetRice("Sushi rice");
        }

        public void BuildFilling()
        {
            roll.SetFilling("Crab stick, avocado, cucumber");
        }

        public void BuildTopping()
        {
            roll.SetTopping("Tobiko (fish roe)");
        }

        public Roll GetResult()
        {
            return roll;
        }
    }

}

