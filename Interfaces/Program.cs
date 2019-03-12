using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface IStreamingDevice
    {
        string deviceName { get; set; }
        bool Play();
        void Pause();
        void Ffwd();
        void Rewind();
        bool Stop();
    }

    public class DVDPlayer : IStreamingDevice
    {
        public string spin(string title)
        {
            Console.WriteLine(this.deviceName + " is spinning!");
            return title;
        }
        public string deviceName { get => "DVD"; set => deviceName = "DVD"; }

        public void Ffwd()
        {
            Console.WriteLine("Fast-forward " + this.deviceName);
        }

        public void Pause()
        {
            Console.WriteLine("pause the DVD");
        }

        public bool Play()
        {
            Console.WriteLine("DVD is playing");
            return true;
        }

        public void Rewind()
        {
            Console.WriteLine("rewinding DVD");
        }

        public bool Stop()
        {
            Console.WriteLine("stop DVD");
            return false;
        }
    }

    public class NetFlixPlayer : IStreamingDevice
    {
        public string deviceName { get => "NetFlix"; set => deviceName = "NetFlix"; }

        public void Ffwd()
        {
            Console.WriteLine("Fast-forward NetFlix");
        }

        public void Pause()
        {
            Console.WriteLine("pause the NetFlix");
        }

        public bool Play()
        {
            Console.WriteLine("NetFlix is playing");
            return true;

        }

        public void Rewind()
        {
            Console.WriteLine("rewinding NetFlix");
        }

        public bool Stop()
        {
            Console.WriteLine("stop NetFlix");
            return false;

        }
    }

    public class iPod : IStreamingDevice
    {
        public string deviceName { get => "iPod"; set => deviceName = "iPod"; }

        public void Ffwd()
        {
            Console.WriteLine("Fast-forward iPod");
        }

        public void Pause()
        {
            Console.WriteLine("pause the iPod");
        }

        public bool Play()
        {
            Console.WriteLine("iPod is playing");
            return true;

        }

        public void Rewind()
        {
            Console.WriteLine("rewinding iPod");
        }

        public bool Stop()
        {
            Console.WriteLine("stop iPod");
            return false;

        }
    }

    public class CassettePlayer : IStreamingDevice
    {
        public string deviceName { get => "Walkman"; set => deviceName = "Walkman"; }

        public void Ffwd()
        {
            Console.WriteLine("FFWD Cassette Player");
        }

        public void Pause()
        {
            Console.WriteLine("pause cassette");
        }

        public bool Play()
        {
            Console.WriteLine("play cassette");
            return true;
        }

        public void Rewind()
        {
            Console.WriteLine("rewind cassette");
        }

        public bool Stop()
        {
            Console.WriteLine("stop cassette");
            return false;
        }
        static void start(IStreamingDevice player)
        {
            player.Play();
        }

        static void skipAhead(IStreamingDevice player)
        {
            player.Ffwd();
        }

        static void stop(IStreamingDevice player)
        {
            player.Stop();
        }
        class Program
        {
            static void Main(string[] args)
            {
                var mobileDevice = new iPod();

                Console.WriteLine(mobileDevice.deviceName + " rocks!");
                start(mobileDevice);
                skipAhead(mobileDevice);
                stop(mobileDevice);

                Console.ReadKey();
            }
        }
    }
}
