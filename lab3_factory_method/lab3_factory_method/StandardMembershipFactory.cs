﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3_factory_method
{
    internal class StandardMembershipFactory : MembershipFactory
    {
        private readonly decimal _price;
        private readonly string _description;

        public StandardMembershipFactory(decimal price, string description)
        {
            _price = price;
            _description = description;
        }

        public override MembershipInterface GetMembership()
        {
            StandardMembership membership = new(_price)
            {
                Description = _description
            };
            return membership;

        }
    }
}
