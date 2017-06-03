using System;
using System.IO.Ports;
using System.Data;
using System.Collections.Generic;
using System.Text;

namespace TestAME
{
    public class SerialComPort 
    {
        static SerialPort CurrentComPort = null;
        string RecieveData = null;
        string SendingData = null;

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


        public SerialComPort(SerialPort a)
        {
            string[] port = null;
            CurrentComPort = a;
            port = SerialPort.GetPortNames();
            if(port.Length > 0)
                CurrentComPort.PortName = port[0];
        }

        public bool OpenSPort()
        {
            if (CurrentComPort.PortName == null) 
                return false;

            if (CurrentComPort != null)
            {
                if (CurrentComPort.IsOpen != true)
                {
                    try
                    {
                        CurrentComPort.Open();
                        if (CurrentComPort.IsOpen == false)
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

        public bool CloseSPort()
        {
            if (CurrentComPort.PortName == null)
                return false;

            if (CurrentComPort != null)
            {
                if (CurrentComPort.IsOpen == true)
                {
                    try
                    {
                        CurrentComPort.Close();
                        if (CurrentComPort.IsOpen == true)
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
            if (CurrentComPort != null)
            {
                if (CurrentComPort.IsOpen == true)
                {
                    string[] port = null;
                    port = SerialPort.GetPortNames();
                    if (port.Length > 0)
                    { 
                        foreach (string element in port)
                        {
                            if (element == CurrentComPort.PortName)
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

        public bool SendData(int dataOut, bool flagSendLF)
        {
            bool bRet = true;

            if (CurrentComPort.PortName == null)
                return false;

            if (CurrentComPort.IsOpen == true)
            {
                try
                {
                    byte[] dataBytes = new byte[2];
                    dataBytes[0] = (byte)dataOut;
                    CurrentComPort.Write(dataBytes, 0, 1);

                    if (flagSendLF)
                    {
                        dataBytes[0] = 13;
                        CurrentComPort.Write(dataBytes, 0, 1);
                    }
                }
                catch
                {
                    CurrentComPort.Close();
                    return false;
                }
            }

            return bRet;
        }

        public bool SendData(string dataOut, bool flagSendLF)
        {
            bool bRet = true;

            if (CurrentComPort.PortName == null)
                return false;

            if (CurrentComPort.IsOpen == true)
            {
                try
                {
                    byte[] dataBytes = null;
                    dataBytes = Encoding.ASCII.GetBytes(dataOut);

                    if (dataBytes.Length > 0)
                        CurrentComPort.Write(dataBytes, 0, dataBytes.Length);

                    if (flagSendLF)
                    {
                        dataBytes[0] = 13;
                        CurrentComPort.Write(dataBytes, 0, 1);
                    }
                }
                catch
                {
                    CurrentComPort.Close();
                    return false;
                }
            }

            return bRet;
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
    }
}