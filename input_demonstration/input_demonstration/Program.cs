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
            string val = "0";
            int alignmentCheck = 0;
            _serialPort = new SerialPort(); //opens stream to arduino
            _serialPort.PortName = "COM5";
            _serialPort.BaudRate = 9600;
            _serialPort.Open();

            while (true)
            {
                Console.Clear(); //clears out the previous data
                _serialPort.DiscardInBuffer(); //clears the buffer

                Int32.TryParse(_serialPort.ReadLine(), out alignmentCheck);
                while (alignmentCheck != 9999)
                {
                    Int32.TryParse(_serialPort.ReadLine(), out alignmentCheck);
                    Thread.Sleep(200);
                }

                val = _serialPort.ReadLine(); //prints left click state
                Console.WriteLine("Left Click: " + val);
                Thread.Sleep(10);

                val = _serialPort.ReadLine(); //prints right click state
                Console.WriteLine("Right Click: " + val);
                Thread.Sleep(10);

                val = _serialPort.ReadLine(); //prints mouse x position
                Console.WriteLine("Mouse X Position: " + val);
                Thread.Sleep(10);

                val = _serialPort.ReadLine(); //prints mouse y position
                Console.WriteLine("Mouse Y Position: " + val);
                Thread.Sleep(10);

                Thread.Sleep(500);
            }
        }
    }
}
