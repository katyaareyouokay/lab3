﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3_factory_method
{
    internal abstract class MembershipFactory
    {
        public abstract MembershipInterface GetMembership();
    }
}
