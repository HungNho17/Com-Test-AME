using System;
using System.IO.Ports;

namespace TestAME
{
    public class SerialComPort
    {
        static SerialPort CurrentComPort = null;

        public SerialComPort(SerialPort a)
        {
            CurrentComPort = a;
        }

        public string[] GetNameAllSerialPortValid()
        {
            string[] port;
            port = SerialPort.GetPortNames();
            return port;
        }
    }
}