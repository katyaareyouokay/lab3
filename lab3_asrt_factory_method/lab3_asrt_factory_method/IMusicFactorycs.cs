using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3_asrt_factory_method
{
    internal abstract class MusicFactory
    {
        public abstract IPlayer CreatePlayer();
        public abstract ICover CreateCover();
    }
}
