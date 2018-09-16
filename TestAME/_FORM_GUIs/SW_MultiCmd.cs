using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TestAME
{
    public partial class SW_MultiCmd : Form
    {
        ISerialComport m_ComPort = null;

        public SW_MultiCmd(ISerialComport ComPort)
        {
            m_ComPort = ComPort;
            InitializeComponent();
        }
        
    }
}
