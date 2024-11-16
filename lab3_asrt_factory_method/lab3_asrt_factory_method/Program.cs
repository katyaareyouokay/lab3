using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3_asrt_factory_method
{
    internal class MusicApplication
    {
        private IPlayer _player;
        private ICover _cover;

        public MusicApplication(MusicFactory factory)
        {
            _player = factory.CreatePlayer();
            _cover = factory.CreateCover();
        }

        public void Run()
        {
            _cover.Display();
            _player.Play();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            // Приложение для виниловых пластинок
            MusicFactory vinylFactory = new VinylFactory();
            MusicApplication vinylApp = new MusicApplication(vinylFactory);
            Console.WriteLine("Vinyl Application:");
            vinylApp.Run();

            // Приложение для компакт-дисков
            MusicFactory cdFactory = new CDFactory();
            MusicApplication cdApp = new MusicApplication(cdFactory);
            Console.WriteLine("\nCD Application:");
            cdApp.Run();
            Console.ReadKey();
        }
    }
}

