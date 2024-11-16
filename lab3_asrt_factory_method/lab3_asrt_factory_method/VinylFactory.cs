using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3_asrt_factory_method
{
    internal class VinylFactory : MusicFactory
    {
        public override IPlayer CreatePlayer()
        {
            return new VinylPlayer();
        }

        public override ICover CreateCover()
        {
            return new VinylCover();
        }
    }
}

