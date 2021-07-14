using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace Projeto_Infap
{
    public partial class frm2 : Form
    {
        public frm2()
        {
            InitializeComponent();
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frm2_Load(object sender, EventArgs e)
        {
            #region Config_Port
            String[] valoresPort = SerialPort.GetPortNames();
            for(int i=0; i<valoresPort.Length; i++)
            {
                cbBoxPort.Items.Add(valoresPort[i]);
            }
            #endregion

            #region Config_Baud
            int[] valoresBaud = { 2400, 4800, 9600, 19200, 57600, 115200};
            for(int i=0; i<valoresBaud.Length; i++)
            {
                cbBoxBaud.Items.Add(valoresBaud[i]);
            }
            cbBoxBaud.Text = "9600";
            #endregion

            #region Config_Data
            cbBoxData.Items.Add("7");
            cbBoxData.Items.Add("8");
            cbBoxData.Text = "8";
            #endregion

            #region Config_Stop
            cbBoxStop.Items.Add("None");
            cbBoxStop.Items.Add("One");
            cbBoxStop.Items.Add("Two");
            cbBoxStop.Text = "One";
            #endregion

            #region Config_Parity
            cbBoxParity.Items.Add("NONE");
            cbBoxParity.Items.Add("EVEN");
            cbBoxParity.Items.Add("ODD");
            cbBoxParity.Items.Add("MARK");
            cbBoxParity.Items.Add("SPACE");
            cbBoxParity.Text = "NONE";
            #endregion
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
        }
    }
}
