using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3_asrt_factory_method
{
    internal class CDCover : ICover
    {
        public void Display()
        {
            Console.WriteLine("Displaying a modern CD cover.");
        }
    }
}
