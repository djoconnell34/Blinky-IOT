using System;
using System.Device.Gpio;

namespace Blinky
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello this is an IOT App");

            int pin = 18;
            GpioController controller = new GpioController();

            controller.OpenPin(pin, PinMode.Output);

            while (true)
            {
                controller.Write(pin, PinValue.High);
                Thread.Sleep(1000);
                controller.Write(pin, PinValue.Low);
                Thread.Sleep(1000);
            }
        }
    }
}
