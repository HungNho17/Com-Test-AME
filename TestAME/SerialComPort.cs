using System;
using System.IO.Ports;

namespace TestAME
{
    public class SerialComPort
    {
        static SerialPort CurrentComPort = null;
        string RecieveData = null;
        string SendingData = null;

        public SerialComPort(SerialPort a)
        {
            string[] port;
            CurrentComPort = a;
            port = SerialPort.GetPortNames();
            CurrentComPort.PortName = port[0];
        }

        public bool OpenSPort()
        {
            if (CurrentComPort != null)
            {
                if (CurrentComPort.IsOpen != true)
                { 
                    CurrentComPort.Open();
                    if (CurrentComPort.IsOpen == false)
                    {
                        return false;
                    }

                }
            }
            return true;
        }

        public bool CloseSPort()
        {
            if (CurrentComPort != null)
            {
                if (CurrentComPort.IsOpen == true)
                {
                    CurrentComPort.Close();
                    if (CurrentComPort.IsOpen == true)
                    {
                        return false;
                    }

                }
            }
            return true;
        }
    }
}