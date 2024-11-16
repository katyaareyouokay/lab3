using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3_asrt_factory_method
{
    internal class CDFactory : MusicFactory
    {
        public override IPlayer CreatePlayer()
        {
            return new CDPlayer();
        }

        public override ICover CreateCover()
        {
            return new CDCover();
        }
    }
}
