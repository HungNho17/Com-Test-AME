using System;
using System.IO.Ports;
using System.Data;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace TestAME
{
    public class CSerialComPort : ISerialComport
    {
        int[] AssciiDecimalList = 
        { 
            0   ,1   ,2   ,3   ,4   ,5   ,6   ,7   ,8   ,9   ,10  ,
            11  ,12  ,13  ,14  ,15  ,16  ,17  ,18  ,19  ,20  ,21  ,
            22  ,23  ,24  ,25  ,26  ,27  ,28  ,29  ,30  ,31  ,32  ,
            33  ,34  ,35  ,36  ,37  ,38  ,39  ,40  ,41  ,42  ,43  ,
            44  ,45  ,46  ,47  ,48  ,49  ,50  ,51  ,52  ,53  ,54  ,
            55  ,56  ,57  ,58  ,59  ,60  ,61  ,62  ,63  ,64  ,65  ,
            66  ,67  ,68  ,69  ,70  ,71  ,72  ,73  ,74  ,75  ,76  ,
            77  ,78  ,79  ,80  ,81  ,82  ,83  ,84  ,85  ,86  ,87  ,
            88  ,89  ,90  ,91  ,92  ,93  ,94  ,95  ,96  ,97  ,98  ,
            99  ,100 ,101 ,102 ,103 ,104 ,105 ,106 ,107 ,108 ,109 ,
            110 ,111 ,112 ,113 ,114 ,115 ,116 ,117 ,118 ,119 ,120 ,
            121 ,122 ,123 ,124 ,125 ,126 ,127 ,128 ,129 ,130 ,131 ,
            132 ,133 ,134 ,135 ,136 ,137 ,138 ,139 ,140 ,141 ,142 ,
            143 ,144 ,145 ,146 ,147 ,148 ,149 ,150 ,151 ,152 ,153 ,
            154 ,155 ,156 ,157 ,158 ,159 ,160 ,161 ,162 ,163 ,164 ,
            165 ,166 ,167 ,168 ,169 ,170 ,171 ,172 ,173 ,174 ,175 ,
            176 ,177 ,178 ,179 ,180 ,181 ,182 ,183 ,184 ,185 ,186 ,
            187 ,188 ,189 ,190 ,191 ,192 ,193 ,194 ,195 ,196 ,197 ,
            198 ,199 ,200 ,201 ,202 ,203 ,204 ,205 ,206 ,207 ,208 ,
            209 ,210 ,211 ,212 ,213 ,214 ,215 ,216 ,217 ,218 ,219 ,
            220 ,221 ,222 ,223 ,224 ,225 ,226 ,227 ,228 ,229 ,230 ,
            231 ,232 ,233 ,234 ,235 ,236 ,237 ,238 ,239 ,240 ,241 ,
            242 ,243 ,244 ,245 ,246 ,247 ,248 ,249 ,250 ,251 ,252 ,
            253 ,254 ,255 
        };

        string[] AssciiHexList = 
        { 
            "\\x00", "\\x01", "\\x02", "\\x03", "\\x04", "\\x05", "\\x06", "\\x07", "\\x08",
            "\\x09", "\\x0A", "\\x0B", "\\x0C", "\\x0D", "\\x0E", "\\x0F", "\\x10", "\\x11",
            "\\x12", "\\x13", "\\x14", "\\x15", "\\x16", "\\x17", "\\x18", "\\x19", "\\x1A",
            "\\x1B", "\\x1C", "\\x1D", "\\x1E", "\\x1F", "\\x20", "\\x21", "\\x22", "\\x23",
            "\\x24", "\\x25", "\\x26", "\\x27", "\\x28", "\\x29", "\\x2A", "\\x2B", "\\x2C",
            "\\x2D", "\\x2E", "\\x2F", "\\x30", "\\x31", "\\x32", "\\x33", "\\x34", "\\x35",
            "\\x36", "\\x37", "\\x38", "\\x39", "\\x3A", "\\x3B", "\\x3C", "\\x3D", "\\x3E",
            "\\x3F", "\\x40", "\\x41", "\\x42", "\\x43", "\\x44", "\\x45", "\\x46", "\\x47",
            "\\x48", "\\x49", "\\x4A", "\\x4B", "\\x4C", "\\x4D", "\\x4E", "\\x4F", "\\x50",
            "\\x51", "\\x52", "\\x53", "\\x54", "\\x55", "\\x56", "\\x57", "\\x58", "\\x59",
            "\\x5A", "\\x5B", "\\x5C", "\\x5D", "\\x5E", "\\x5F", "\\x60", "\\x61", "\\x62",
            "\\x63", "\\x64", "\\x65", "\\x66", "\\x67", "\\x68", "\\x69", "\\x6A", "\\x6B",
            "\\x6C", "\\x6D", "\\x6E", "\\x6F", "\\x70", "\\x71", "\\x72", "\\x73", "\\x74",
            "\\x75", "\\x76", "\\x77", "\\x78", "\\x79", "\\x7A", "\\x7B", "\\x7C", "\\x7D",
            "\\x7E", "\\x7F", "\\x80", "\\x81", "\\x82", "\\x83", "\\x84", "\\x85", "\\x86",
            "\\x87", "\\x88", "\\x89", "\\x8A", "\\x8B", "\\x8C", "\\x8D", "\\x8E", "\\x8F",
            "\\x90", "\\x91", "\\x92", "\\x93", "\\x94", "\\x95", "\\x96", "\\x97", "\\x98",
            "\\x99", "\\x9A", "\\x9B", "\\x9C", "\\x9D", "\\x9E", "\\x9F", "\\xA0", "\\xA1",
            "\\xA2", "\\xA3", "\\xA4", "\\xA5", "\\xA6", "\\xA7", "\\xA8", "\\xA9", "\\xAA",
            "\\xAB", "\\xAC", "\\xAD", "\\xAE", "\\xAF", "\\xB0", "\\xB1", "\\xB2", "\\xB3",
            "\\xB4", "\\xB5", "\\xB6", "\\xB7", "\\xB8", "\\xB9", "\\xBA", "\\xBB", "\\xBC",
            "\\xBD", "\\xBE", "\\xBF", "\\xC0", "\\xC1", "\\xC2", "\\xC3", "\\xC4", "\\xC5",
            "\\xC6", "\\xC7", "\\xC8", "\\xC9", "\\xCA", "\\xCB", "\\xCC", "\\xCD", "\\xCE",
            "\\xCF", "\\xD0", "\\xD1", "\\xD2", "\\xD3", "\\xD4", "\\xD5", "\\xD6", "\\xD7",
            "\\xD8", "\\xD9", "\\xDA", "\\xDB", "\\xDC", "\\xDD", "\\xDE", "\\xDF", "\\xE0",
            "\\xE1", "\\xE2", "\\xE3", "\\xE4", "\\xE5", "\\xE6", "\\xE7", "\\xE8", "\\xE9",
            "\\xEA", "\\xEB", "\\xEC", "\\xED", "\\xEE", "\\xEF", "\\xF0", "\\xF1", "\\xF2",
            "\\xF3", "\\xF4", "\\xF5", "\\xF6", "\\xF7", "\\xF8", "\\xF9", "\\xFA", "\\xFB",
            "\\xFC", "\\xFD", "\\xFE", "\\xFF" 
        };

        string[] AssciiCharList =
        {
            "NUL"    ,"SOH"    ,"STX"    ,"ETX"    ,"EOT"    ,"ENQ"    ,"ACK"    ,"BEL"   ,
            "BkSp"   ,"Tab"    ,"LF"     ,"VT"     ,"FF"     ,"CR"     ,"SO"     ,"SI"    ,
            "DLE"    ,"XON"    ,"DC2"    ,"XOFF"   ,"DC4"    ,"NAK"    ,"SYN"    ,"ETB"   ,
            "CAN"    ,"EM"     ,"EOF"    ,"ESC"    ,"FS"     ,"GS"     ,"RS"     ,"US"    ,
            "Space"  ,"!"      ,"\""     ,"#"      ,"$"      ,"%"      ,"&"      ,"'"     ,
            "("      ,")"      ,"*"      ,"+"      ,"Comma"  ,"-"      ,"Period" ,"/"     ,
            "0"      ,"1"      ,"2"      ,"3"      ,"4"      ,"5"      ,"6"      ,"7"     ,
            "8"      ,"9"      ,":"      ,";"      ,"<"      ,"="      ,">"      ,"?"     ,
            "@"      ,"A"      ,"B"      ,"C"      ,"D"      ,"E"      ,"F"      ,"G"     ,
            "H"      ,"I"      ,"J"      ,"K"      ,"L"      ,"M"      ,"N"      ,"O"     ,
            "P"      ,"Q"      ,"R"      ,"S"      ,"T"      ,"U"      ,"V"      ,"W"     ,
            "X"      ,"Y"      ,"Z"      ,"["      ,"\\"     ,"]"      ,"^"      ,"_"     ,
            "`"      ,"a"      ,"b"      ,"c"      ,"d"      ,"e"      ,"f"      ,"g"     ,
            "h"      ,"i"      ,"j"      ,"k"      ,"l"      ,"m"      ,"n"      ,"o"     ,
            "p"      ,"q"      ,"r"      ,"s"      ,"t"      ,"u"      ,"v"      ,"w"     ,
            "x"      ,"y"      ,"z"      ,"{"      ,"|"      ,"}"      ,"~"      ," "     ,
            " "      ," "      ," "      ," "      ," "      ," "      ," "      ," "     ,
            " "      ," "      ," "      ," "      ," "      ," "      ," "      ," "     ,
            " "      ," "      ," "      ," "      ," "      ," "      ," "      ," "     ,
            " "      ," "      ," "      ," "      ," "      ," "      ," "      ," "     ,
            " "      ," "      ," "      ," "      ," "      ," "      ," "      ," "     ,
            " "      ," "      ," "      ," "      ," "      ," "      ," "      ," "     ,
            " "      ," "      ," "      ," "      ," "      ," "      ," "      ," "     ,
            " "      ," "      ," "      ," "      ," "      ," "      ," "      ," "     ,
            " "      ," "      ," "      ," "      ," "      ," "      ," "      ," "     ,
            " "      ," "      ," "      ," "      ," "      ," "      ," "      ," "     ,
            " "      ," "      ," "      ," "      ," "      ," "      ," "      ," "     ,
            " "      ," "      ," "      ," "      ," "      ," "      ," "      ," "     ,
            " "      ," "      ," "      ," "      ," "      ," "      ," "      ," "     ,
            " "      ," "      ," "      ," "      ," "      ," "      ," "      ," "     ,
            " "      ," "      ," "      ," "      ," "      ," "      ," "      ," "     ,
            " "      ," "      ," "      ," "      ," "      ," "      ," "      ," "     
        };

        string[] AssciiDisplayList = 
        { 
            "{NUL}"    ,"{SOH}"    ,"{STX}"    ,"{ETX}"    ,"{EOT}"    ,"{ENQ}"    ,"{ACK}"    ,"{BEL}"    ,
            "{BkSp}"   ,"{Tab}"    ,"{LF}"     ,"{VT}"     ,"{FF}"     ,"{CR}"     ,"{SO}"     ,"{SI}"     ,
            "{DLE}"    ,"{XON}"    ,"{DC2}"    ,"{XOFF}"   ,"{DC4}"    ,"{NAK}"    ,"{SYN}"    ,"{ETB}"    ,
            "{CAN}"    ,"{EM}"     ,"{EOF}"    ,"{ESC}"    ,"{FS}"     ,"{GS}"     ,"{RS}"     ,"{US}"     ,
            "{Space}"  ,"!"        ,"\""       ,"#"        ,"$"        ,"%"        ,"&"        ,"'"        ,
            "("        ,")"        ,"*"        ,"+"        ,","        ,"-"        ,"."        ,"/"        ,
            "0"        ,"1"        ,"2"        ,"3"        ,"4"        ,"5"        ,"6"        ,"7"        ,
            "8"        ,"9"        ,":"        ,";"        ,"<"        ,"="        ,">"        ,"?"        ,
            "@"        ,"A"        ,"B"        ,"C"        ,"D"        ,"E"        ,"F"        ,"G"        ,
            "H"        ,"I"        ,"J"        ,"K"        ,"L"        ,"M"        ,"N"        ,"O"        ,
            "P"        ,"Q"        ,"R"        ,"S"        ,"T"        ,"U"        ,"V"        ,"W"        ,
            "X"        ,"Y"        ,"Z"        ,"["        ,"\\"       ,"]"        ,"^"        ,"_"        ,
            "`"        ,"a"        ,"b"        ,"c"        ,"d"        ,"e"        ,"f"        ,"g"        ,
            "h"        ,"i"        ,"j"        ,"k"        ,"l"        ,"m"        ,"n"        ,"o"        ,
            "p"        ,"q"        ,"r"        ,"s"        ,"t"        ,"u"        ,"v"        ,"w"        ,
            "x"        ,"y"        ,"z"        ,"{"        ,"|"        ,"}"        ,"~"        ,"{\\x7F}"  ,
            "{\\x80}"  ,"{\\x81}"  ,"{\\x82}"  ,"{\\x83}"  ,"{\\x84}"  ,"{\\x85}"  ,"{\\x86}"  ,"{\\x87}"  ,
            "{\\x88}"  ,"{\\x89}"  ,"{\\x8A}"  ,"{\\x8B}"  ,"{\\x8C}"  ,"{\\x8D}"  ,"{\\x8E}"  ,"{\\x8F}"  ,
            "{\\x90}"  ,"{\\x91}"  ,"{\\x92}"  ,"{\\x93}"  ,"{\\x94}"  ,"{\\x95}"  ,"{\\x96}"  ,"{\\x97}"  ,
            "{\\x98}"  ,"{\\x99}"  ,"{\\x9A}"  ,"{\\x9B}"  ,"{\\x9C}"  ,"{\\x9D}"  ,"{\\x9E}"  ,"{\\x9F}"  ,
            "{\\xA0}"  ,"{\\xA1}"  ,"{\\xA2}"  ,"{\\xA3}"  ,"{\\xA4}"  ,"{\\xA5}"  ,"{\\xA6}"  ,"{\\xA7}"  ,
            "{\\xA8}"  ,"{\\xA9}"  ,"{\\xAA}"  ,"{\\xAB}"  ,"{\\xAC}"  ,"{\\xAD}"  ,"{\\xAE}"  ,"{\\xAF}"  ,
            "{\\xB0}"  ,"{\\xB1}"  ,"{\\xB2}"  ,"{\\xB3}"  ,"{\\xB4}"  ,"{\\xB5}"  ,"{\\xB6}"  ,"{\\xB7}"  ,
            "{\\xB8}"  ,"{\\xB9}"  ,"{\\xBA}"  ,"{\\xBB}"  ,"{\\xBC}"  ,"{\\xBD}"  ,"{\\xBE}"  ,"{\\xBF}"  ,
            "{\\xC0}"  ,"{\\xC1}"  ,"{\\xC2}"  ,"{\\xC3}"  ,"{\\xC4}"  ,"{\\xC5}"  ,"{\\xC6}"  ,"{\\xC7}"  ,
            "{\\xC8}"  ,"{\\xC9}"  ,"{\\xCA}"  ,"{\\xCB}"  ,"{\\xCC}"  ,"{\\xCD}"  ,"{\\xCE}"  ,"{\\xCF}"  ,
            "{\\xD0}"  ,"{\\xD1}"  ,"{\\xD2}"  ,"{\\xD3}"  ,"{\\xD4}"  ,"{\\xD5}"  ,"{\\xD6}"  ,"{\\xD7}"  ,
            "{\\xD8}"  ,"{\\xD9}"  ,"{\\xDA}"  ,"{\\xDB}"  ,"{\\xDC}"  ,"{\\xDD}"  ,"{\\xDE}"  ,"{\\xDF}"  ,
            "{\\xE0}"  ,"{\\xE1}"  ,"{\\xE2}"  ,"{\\xE3}"  ,"{\\xE4}"  ,"{\\xE5}"  ,"{\\xE6}"  ,"{\\xE7}"  ,
            "{\\xE8}"  ,"{\\xE9}"  ,"{\\xEA}"  ,"{\\xEB}"  ,"{\\xEC}"  ,"{\\xED}"  ,"{\\xEE}"  ,"{\\xEF}"  ,
            "{\\xF0}"  ,"{\\xF1}"  ,"{\\xF2}"  ,"{\\xF3}"  ,"{\\xF4}"  ,"{\\xF5}"  ,"{\\xF6}"  ,"{\\xF7}"  ,
            "{\\xF8}"  ,"{\\xF9}"  ,"{\\xFA}"  ,"{\\xFB}"  ,"{\\xFC}"  ,"{\\xFD}"  ,"{\\xFE}"  ,"{\\xFF}"   
        };
        
        private static SerialPort               m_SPCurrent             = null;
        private static Thread                   m_SPProcessing          = null;
        private static Queue<string>            m_SPReceiveQueue        = null;
        private static bool                     m_SPFlagNewData         = false;
        
        private static Queue<string>            m_SPWritenQueue         = null;
        private static bool                     m_SPFlagWritenData      = false;

        private SerialDataReceivedEventHandler  m_SPReceiveHandler      = null;
        private List<DataReceiveUpdate>         m_ClientReadHandlers    = null;
        private List<DataWritenUpdate>          m_ClientWritenHandlers  = null;

        public CSerialComPort(SerialPort a)
        {
            string[] port = null;

            m_SPCurrent     = a;
            m_SPReceiveHandler   = new SerialDataReceivedEventHandler(DataReceiverHandler);
            m_SPReceiveQueue     = new Queue<string>();
            m_ClientReadHandlers = new List<DataReceiveUpdate>();
            m_ClientWritenHandlers = new List<DataWritenUpdate>();

            // common setting for serial port
            m_SPCurrent.NewLine = "\n";
            m_SPCurrent.DataReceived += m_SPReceiveHandler;

            port = SerialPort.GetPortNames();
            if(port.Length > 0)
                m_SPCurrent.PortName = port[0];
        }

        public void RegisterReceiveRealTime(DataReceiveUpdate Read)
        {
            m_ClientReadHandlers.Add(Read);
        }

        public void RegisterReceiveWritenData(DataWritenUpdate Writen)
        {
            m_ClientWritenHandlers.Add(Writen);
        }

        public bool OpenSPort()
        {
            bool bRet = false;
            if (m_SPCurrent != null)
            {
                bRet = true;
                if (m_SPCurrent.IsOpen == false)
                {
                    try
                    {
                        m_SPCurrent.Open();
                        if (m_SPCurrent.IsOpen == true)
                        {
                            m_SPProcessing = new Thread(new ThreadStart(Processing));
                            m_SPProcessing.Start();
                        }
                    }
                    catch {bRet = false;}
                }
            }
             
            return bRet;
        }

        public bool CloseSPort()
        {
            if (m_SPCurrent.PortName == null)
                return false;

            if (m_SPCurrent != null)
            {
                if (m_SPCurrent.IsOpen == true)
                {
                    try
                    {
                        m_SPCurrent.Close();
                        if (m_SPCurrent.IsOpen == true)
                        {
                            return false;
                        }
                    }
                    catch
                    {
                        return false;
                    }

                }
            }
            return true;
        }

        public bool CheckSport()
        {
            bool bRet = true;
            if (m_SPCurrent != null)
            {
                if (m_SPCurrent.IsOpen == true)
                {
                    string[] port = null;
                    port = SerialPort.GetPortNames();
                    if (port.Length > 0)
                    { 
                        foreach (string element in port)
                        {
                            if (element == m_SPCurrent.PortName)
                            {
                                return bRet;
                            }
                        }
                        bRet = false;
                    }
                }
            }
            return bRet;
        }

        public bool HandshakeSetting(HANDSHAKE_TYPE iMode)
        {
            bool bRet = false;
            try
            {
                switch ((int)iMode)
                {
                    case 0:
                        m_SPCurrent.Handshake = Handshake.RequestToSend;
                        break;

                    case 1:
                        m_SPCurrent.Handshake = Handshake.XOnXOff;
                        break;

                    case 2:
                        m_SPCurrent.Handshake = Handshake.RequestToSendXOnXOff;
                        break;

                    case 3:
                    default:
                        m_SPCurrent.Handshake = Handshake.None;
                        break;
                }
                bRet = true;
            }
            catch { }

            return bRet;
        }

        public bool DTRSetting(bool FlagEnable)
        {
            bool bRet = false;
            if (m_SPCurrent.IsOpen)
            {
                m_SPCurrent.DtrEnable = FlagEnable;
                bRet = true;
            }
            return bRet;
        }

        public bool RTSSetting(bool FlagEnable)
        {
            bool bRet = false;
            if (m_SPCurrent.IsOpen)
            {
                if (FlagEnable == false) m_SPCurrent.BaseStream.Flush();
                m_SPCurrent.RtsEnable = FlagEnable;
                bRet = true;
            }
            return bRet;
        }

        public bool CTSGetting()
        {
            bool bRet = false;
            if (m_SPCurrent.IsOpen)
            {
                bRet = m_SPCurrent.CtsHolding;
            }
            return bRet;
        }

        public bool DSRGetting()
        {
            bool bRet = false;
            if (m_SPCurrent.IsOpen)
            {
                bRet = m_SPCurrent.DsrHolding;
            }
            return bRet;
        }

        public string IntToAssciiStr(int dataIn, bool flagShowLF, bool flagShowSpace)
        {
            string sResult = null;

            int idx = 0;
            foreach (var element in AssciiDecimalList)
            {
                if (dataIn == element)
                {
                    sResult = AssciiDisplayList[idx];
                    break;
                }
                idx++;
            }

            if (!flagShowLF)
            {
                if (dataIn == '\n') sResult = "\n";
                if (dataIn == '\r') sResult = "\r";
            }
            if (!flagShowSpace)
            {
                if (dataIn == ' ') sResult = " ";
            }

            return sResult;
        }

        public string ProcessPureString(string dataIn, bool flagShowLF, bool flagShowSpace)
        {
            string sResult = null;
            string sTemp = null;

            foreach (var element in dataIn)
            {
                int iTemp = (int)element;
                int idx = 0;
                foreach (var element1 in AssciiDecimalList)
                {
                    if (iTemp == element1)
                    {
                        sTemp = AssciiDisplayList[idx];
                        break;
                    }
                    idx++;
                }

                if (!flagShowLF)
                {
                    if (iTemp == '\n') sTemp = "\n";
                    if (iTemp == '\r') sTemp = "\r";
                }

                if (!flagShowSpace)
                {
                    if (iTemp == ' ') sTemp = " ";
                }

                sResult += sTemp;
            }
            
            return sResult;
        }

        public bool Write(int dataOut, bool flagSendLF)
        {
            bool bRet = true;

            if (m_SPCurrent.PortName == null)
                return false;

            if (m_SPCurrent.IsOpen == true)
            {
                try
                {
                    byte[] dataBytes = new byte[2];
                    dataBytes[0] = (byte)dataOut;
                    m_SPCurrent.Write(dataBytes, 0, 1);

                    if (flagSendLF)
                    {
                        dataBytes[0] = 13;
                        m_SPCurrent.Write(dataBytes, 0, 1);
                    }
                }
                catch
                {
                    m_SPCurrent.Close();
                    return false;
                }
            }

            return bRet;
        }

        public bool Write(string dataOut, bool flagSendLF)
        {
            bool bRet = true;

            if (m_SPCurrent.PortName == null)
                return false;

            if (m_SPCurrent.IsOpen == true)
            {
                try
                {
                    dataOut = dataOut.Replace("\n", string.Empty);

                    if (flagSendLF)
                    {
                        if (dataOut.Contains("\n") == false)
                        {
                            dataOut += "\n";
                        }
                    }

                    byte[] dataBytes = null;
                    dataBytes = Encoding.ASCII.GetBytes(dataOut);

                    if (dataBytes.Length > 0)
                        m_SPCurrent.Write(dataBytes, 0, dataBytes.Length);
                }
                catch
                {
                    m_SPCurrent.Close();
                    return false;
                }
            }

            m_SPWritenQueue.Enqueue(dataOut);
            m_SPFlagWritenData = true;

            return bRet;
        }

        public string Read()
        {
            string sRet = null;

            if (m_SPCurrent.IsOpen == true)
            {
                while (m_SPReceiveQueue.Count > 0)
                {
                    sRet += m_SPReceiveQueue.Dequeue();
                }
                m_SPFlagNewData = false;
            }

            return sRet;
        }

        public DataTable ProcessCharSetTable()
        {
            DataTable dtResult = null;
            DataRow dtRow = null;

            dtResult = new DataTable();
            dtResult.Columns.Add("Char", typeof(string));
            dtResult.Columns.Add("Decimal", typeof(int));
            dtResult.Columns.Add("Hex", typeof(string));

            int idx = 0;
            foreach (int element in AssciiDecimalList)
            {
                dtRow = dtResult.NewRow();
                dtRow["Char"] = AssciiCharList[idx];
                dtRow["Decimal"] = AssciiDecimalList[idx];
                dtRow["Hex"] = AssciiHexList[idx];

                dtResult.Rows.Add(dtRow);
                idx++;
            }

            return dtResult;
        }

        public bool SaveComPort()
        {
            bool bRet = false;
            if (m_SPCurrent.IsOpen)
            {
                Properties.Settings.Default.PortName        = m_SPCurrent.PortName;
                Properties.Settings.Default.PortBaudrate    = m_SPCurrent.BaudRate;
                Properties.Settings.Default.PortDataBit     = m_SPCurrent.DataBits;
                Properties.Settings.Default.PortStopBit     = m_SPCurrent.StopBits;
                Properties.Settings.Default.Save();
                bRet = true;
            }
            return bRet;
        }

        public bool LoadOldComPort()
        {
            bool bRet = false;
            if (m_SPCurrent.IsOpen == false)
            {
                if (Properties.Settings.Default.PortName != null)
                {
                    string[] port = SerialPort.GetPortNames();

                    foreach (string element in port)
                    {
                        if(element == Properties.Settings.Default.PortName)
                        {
                            m_SPCurrent.PortName = Properties.Settings.Default.PortName;
                            m_SPCurrent.BaudRate = Properties.Settings.Default.PortBaudrate;
                            m_SPCurrent.DataBits = Properties.Settings.Default.PortDataBit;
                            m_SPCurrent.StopBits = Properties.Settings.Default.PortStopBit;
                            bRet = true;
                        }
                    }
                    
                }
            }
            return bRet;
        }

        
        private static void DataReceiverHandler(object sender, EventArgs e)
        {
            SerialPort sp = (SerialPort)sender;
            m_SPReceiveQueue.Enqueue(sp.ReadExisting());
            m_SPFlagNewData = true;
        }

        private void Processing()
        {
            for (;;)
            {
                UpdateDataReceiveForClients();
                UpdateWritenDataForClients();

                //UpdateHandsakeStatusForClients();
            }
        }

        private void UpdateDataReceiveForClients()
        {
            if (m_SPFlagNewData == true)
            {
                string sData = m_SPReceiveQueue.Dequeue();

                if (m_ClientReadHandlers.Count > 0)
                {
                    foreach (DataReceiveUpdate ClientHandler in m_ClientReadHandlers)
                    {
                        ClientHandler(sData);
                    }
                }

                if (m_SPReceiveQueue.Count == 0)
                {
                    m_SPFlagNewData = false;
                }
            }
        }

        private void UpdateWritenDataForClients()
        {
            if (m_SPFlagWritenData == true)
            {
                string sData = m_SPWritenQueue.Dequeue();

                if (m_ClientWritenHandlers.Count > 0)
                {
                    foreach (DataWritenUpdate ClientHandler in m_ClientWritenHandlers)
                    {
                        ClientHandler(sData);
                    }
                }

                if (m_SPWritenQueue.Count == 0)
                {
                    m_SPFlagWritenData = false;
                }
            }
        }

    }
}