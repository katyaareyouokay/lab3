using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3_factory_method
{
    internal class FamilyMembershipFactory : MembershipFactory
    {
        private readonly decimal _price;
        private readonly string _description;

        public FamilyMembershipFactory(decimal price, string description)
        {
            _price = price;
            _description = description;
        }

        public override MembershipInterface GetMembership()
        {
            FamilyMembership membership = new(_price)
            {
                Description = _description
            };
            return membership;

        }

    }
}
