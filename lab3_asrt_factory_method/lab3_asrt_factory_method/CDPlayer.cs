﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3_asrt_factory_method
{
    internal class CDPlayer : IPlayer
    {
        public void Play()
        {
            Console.WriteLine("Playing music on a CD Player.");
        }
    }
}