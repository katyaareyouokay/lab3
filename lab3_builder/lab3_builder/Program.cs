using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3_builder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IRollBuilder builder = new CaliforniaRollBuilder();
            RollDirector director = new RollDirector(builder);

            director.ConstructRoll();
            Roll roll = builder.GetResult();

            Console.WriteLine(roll);
            Console.WriteLine("Еnjoy your meal!");
            Console.ReadKey();
        }
    }
}

