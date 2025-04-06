using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace input_demonstration
{
    internal class Program
    {
        static SerialPort _serialPort;
        public static void Main()
        {
            _serialPort = new SerialPort();
            _serialPort.PortName = "COM5";
            _serialPort.BaudRate = 9600;
            _serialPort.Open();
            while (true)
            {
                string a = _serialPort.ReadExisting();
                Console.WriteLine(a);
                Thread.Sleep(200);
            }
        }
    }
}
