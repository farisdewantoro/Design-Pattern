using System;

namespace Bridge
{
    public interface IElectronicDevice
    {
        void Start();
        void Stop();
    }

    public class Refrigerator : IElectronicDevice
    {
        public void Start()
        {
            Console.WriteLine("Compressor Start");
            Console.WriteLine("Ice Cooling Start");
        }
        public void Stop()
        {
            Console.WriteLine("Ice Cooling Stop");
            Console.WriteLine("Compressor Stop");
        }
    }

    public class Bulb : IElectronicDevice
    {
        public void Start()
        {
            Console.WriteLine("Warm up the bulb");
            Console.WriteLine("Glow the bulb");
        }
        public void Stop()
        {
            Console.WriteLine("Switch of the bulb");
        }
    }
    public interface ISwitch
    {
        void On();
        void Off();
    }
    public class Switch : ISwitch
    {
        private IElectronicDevice electronicDevice;
        public void SetDevice(IElectronicDevice electronicDevice)
        {
            this.electronicDevice = electronicDevice;
        }
        public void Off()
        {
            electronicDevice.Stop();
        }
        public void On()
        {
            electronicDevice.Start();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Switch s = new Switch();
            s.SetDevice(new Bulb());
            s.On();
            s.Off();

            s.SetDevice(new Refrigerator());
            s.On();
            s.Off();
            Console.Read();
        }
    }

}
