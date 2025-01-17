﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3_factory_method
{
    internal class StandardAndPoolMembership : MembershipInterface
    {
        private readonly string _name;
        private readonly string _duration;
        private readonly decimal _price;

        public StandardAndPoolMembership(decimal price)
        {
            _name = "Standard + Pool Membership";
            _duration = "3 Months";
            _price = price;
        }

        public string Name => _name;

        public string Description { get; set; }

        public string Duration => _duration;

        public decimal GetPrice() => _price;
    }
}
