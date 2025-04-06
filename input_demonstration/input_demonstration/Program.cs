using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Drawing;
using System.Security.Principal;

namespace input_demonstration
{
    internal class Program
    {
        static SerialPort _serialPort;
        public static void Main()
        {
            string val;
            _serialPort = new SerialPort();
            _serialPort.PortName = "COM5";
            _serialPort.BaudRate = 9600;
            _serialPort.Open();
            _serialPort.ReadExisting();
            while (true)
            {
                Console.Clear(); //clears out the previous data

                val = _serialPort.ReadLine(); //prints left click state
                Console.WriteLine("Left Click: " + val);
                Thread.Sleep(50);

                val = _serialPort.ReadLine(); //prints right click state
                Console.WriteLine("Right Click: " + val);
                Thread.Sleep(50);

                val = _serialPort.ReadLine(); //prints mouse x position
                Console.WriteLine("Mouse X Position: " + val);
                Thread.Sleep(50);

                val = _serialPort.ReadLine(); //prints mouse y position
                Console.WriteLine("Mouse Y Position: " + val);
                Thread.Sleep(50);

                Thread.Sleep(200);
            }
        }
    }
}
