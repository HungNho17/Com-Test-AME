using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace TestAME
{
    public enum HANDSHAKE_TYPE
    {
        REQUEST_TO_SEND = 1,
        XON_XOFF,
        BOTH,
        NONE
    }

    public delegate void DataReceiveUpdate(string sData);
    public delegate void DataWritenUpdate(string sData);

    public interface ISerialComport
    {
        bool OpenSPort();
        bool CloseSPort();

        bool CheckSport();
        bool SaveComPort();
        bool LoadOldComPort();

        bool HandshakeSetting(HANDSHAKE_TYPE iMode);
        bool DTRSetting(bool FlagEnable);
        bool RTSSetting(bool FlagEnable);
        bool CTSGetting();
        bool DSRGetting();

        void        RegisterReceiveRealTime(DataReceiveUpdate ReceiveHandler);
        void        RegisterReceiveWritenData(DataWritenUpdate ReceiveHandler);

        bool        Write(int dataOut, bool flagSendLF);
        bool        Write(string dataOut, bool flagSendLF);
        string      Read();

        string      IntToAssciiStr(int dataIn, bool flagShowLF, bool flagShowSpace);
        string      ProcessPureString(string dataIn, bool flagShowLF, bool flagShowSpace);
        DataTable   ProcessCharSetTable();
    }
}
