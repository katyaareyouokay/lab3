using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3_factory_method
{
    internal interface MembershipInterface
    {
        string Name { get; } // название абонемента
        string Description { get; set; } // описание
        string Duration { get; } // длительность
        decimal GetPrice(); // метод получения цены
    }
}
