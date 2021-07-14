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
    public partial class FrmPrincipal : Form
    {
        delegate void funcRecp();

        public FrmPrincipal()
        {
            InitializeComponent();
            sP1.DataReceived += new SerialDataReceivedEventHandler(SP1_DataReceived);
            timer1.Interval = 300;
            str = "";
        }

        private void SP1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            funcRecp recpDelegate = new funcRecp(RecepSerial);
            Invoke(recpDelegate);
        }

        String chtxt = null, str = null;
        long xGraph = 0;
        bool flagT = false;
        public void RecepSerial()
        {
            chtxt += sP1.ReadExisting();

            txtRecp.Text += chtxt;
            str += chtxt;
            chtxt = null;

            if (txtRecp.Text.Length > 776) txtRecp.Clear();
            if (str.Substring(0, 1).Equals("["))
            {
                if(str.Length >= 7)
                {
                    if(str.Substring(1,1).Equals("A") &&
                        str.Substring(2,1).Equals("L") &&
                        str.Substring(3, 1).Equals("R") &&
                        str.Substring(4, 1).Equals("M") &&
                        str.Substring(6, 1).Equals("]"))
                    {
                        switch (str.Substring(5, 1))
                        {
                            case "0":
                                timer1.Enabled = false;
                                timer2.Interval = 100;
                                if (controlOff.Visible == true)
                                {
                                    ledSensorYellowOn.Visible = false;
                                    ledSensorYellowOff.Visible = true;
                                    ledSensorRedOn.Visible = false;
                                    ledSensorRedOff.Visible = true;
                                    bombaOn.Visible = false;
                                    bombaOff.Visible = true;
                                }
                                break;
                            case "1":
                                timer2.Interval = 500;
                                timer1.Enabled = true;
                                bombaOff.Visible = false;
                                bombaOn.Visible = true;
                                break;
                        }
                    } else
                    if (str.Substring(1, 1).Equals("F") &&
                        str.Substring(2, 1).Equals("0") &&
                        str.Substring(6, 1).Equals("]"))
                    {
                        if (gfSensores.Series[0].Points.Count > 11)
                        {
                            gfSensores.Series[0].Points.RemoveAt(0);
                            gfSensores.Update();
                        }
                        lbSensorF.Text = str.Substring(3, 3);
                        gfSensores.Series[0].Points.AddXY(xGraph, int.Parse(str.Substring(3, 3)));
                        xGraph++;
                    } else
                    if (str.Substring(1, 1).Equals("U") &&
                        str.Substring(6, 1).Equals("]"))
                        {
                        double aux;
                        if (gfSensores.Series[1].Points.Count > 11)
                        {
                            gfSensores.Series[1].Points.RemoveAt(0);
                            gfSensores.Update();
                        }
                        aux = double.Parse(str.Substring(2, 2)) + double.Parse(str.Substring(4, 2)) / 100;
                        if (aux > 9.99)
                            label8.Location = new Point(294, 63);
                        else
                            label8.Location = new Point(283, 63);
                        if(aux*81 > 999)
                            label13.Location = new Point(449, 63);
                        else
                            label13.Location = new Point(438, 63);
                        
                        if(controlOff.Visible == true)
                        {
                            if (aux > 15.00)
                            {
                                ledNivelRedOn.Visible = true;
                                ledNivelYellowOn.Visible = false;
                                ledNivelGreenOn.Visible = false;
                            }
                            else if (aux > 10.00)
                            {
                                ledNivelYellowOn.Visible = true;
                                ledNivelRedOn.Visible = false;
                                ledNivelGreenOn.Visible = false;
                            }
                            else
                            {
                                ledNivelGreenOn.Visible = true;
                                ledNivelRedOn.Visible = false;
                                ledNivelYellowOn.Visible = false;
                            }
                        }
                        lbSensorU.Text = aux.ToString();
                        //aux*81
                        lbsensorUA.Text = (aux).ToString();
                        gfSensores.Series[1].Points.AddXY(xGraph, aux );
                        xGraph++;
                    } else
                    if (str.Substring(1, 1).Equals("T") &&
                       str.Substring(2, 1).Equals("I") &&
                       str.Substring(3, 1).Equals("M") &&
                       str.Substring(4, 1).Equals("E") &&
                       str.Substring(5, 1).Equals("R") &&
                       str.Substring(6, 1).Equals("]"))
                    {
                        flagT = false;
                    }
                    str = null;
                }
            }        
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            gfSensores.Series[0].Color = Color.Red;
            gfSensores.Series[1].Color = Color.Blue;
            #region Config_Port
            String[] valoresPort = SerialPort.GetPortNames();
            for (int i = 0; i < valoresPort.Length; i++)
            {
                cbBoxPort.Items.Add(valoresPort[i]);
            }
            #endregion

            #region Config_Baud
            int[] valoresBaud = { 2400, 4800, 9600, 19200, 57600, 115200 };
            for (int i = 0; i < valoresBaud.Length; i++)
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

            btnAbrir.BackColor = Color.White;
            btnFechar.BackColor = Color.DarkGray;
            btnSair.BackColor = Color.White;
            btnEnviar.BackColor = Color.White;

        }

        private void BtnAbrir_Click(object sender, EventArgs e)
        {

            if (sP1.IsOpen == true) sP1.Close();
            else
            {
                if (cbBoxPort.Text == "")
                {
                    MessageBox.Show("COM Port vazia.");
                    return;
                }
                sP1.PortName = cbBoxPort.Text;
                sP1.BaudRate = int.Parse(cbBoxBaud.Text);
                sP1.DataBits = int.Parse(cbBoxData.Text);
                sP1.StopBits = (StopBits)(cbBoxStop.SelectedIndex);
                sP1.Parity = (Parity)(cbBoxParity.SelectedIndex);
            }

            try
            {
                sP1.Open();
                btnAbrir.Enabled = false;
                cbBoxPort.Enabled = false;
                cbBoxBaud.Enabled = false;
                cbBoxData.Enabled = false;
                cbBoxStop.Enabled = false;
                cbBoxParity.Enabled = false;
                btnFechar.Enabled = true;
                btnSair.Enabled = false;
                lb7.Text = "Conectado!";
                pnlMsg.BackColor = Color.Green;
                btnSair.BackColor = Color.DarkGray;
                btnAbrir.BackColor = Color.DarkGray;
                btnFechar.BackColor = Color.White;
                MessageBox.Show("Conectado com sucesso!");
                timer2.Start();
                sP1.Write("[START]");
            }
            catch
            {
                MessageBox.Show("Erro de comunicação com a porta.");
                btnAbrir.Enabled = true;
                cbBoxPort.Enabled = true;
                cbBoxBaud.Enabled = true;
                cbBoxData.Enabled = true;
                cbBoxStop.Enabled = true;
                cbBoxParity.Enabled = true;
                btnFechar.Enabled = false;
                btnSair.Enabled = true;
                lb7.Text = "Desconectado!";
                pnlMsg.BackColor = Color.Red;
                btnSair.BackColor = Color.White;
                btnAbrir.BackColor = Color.White;
                btnFechar.BackColor = Color.DarkGray;
            }
        }

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled)
            {
                timer1.Enabled = false;
                ledSensorRedOn.Visible = false;
                ledSensorYellowOn.Visible = false;
                ledSensorRedOff.Visible = true;
                ledSensorYellowOff.Visible = true;
            }
            try
            {
                //STOP
                sP1.Write("[STOPX]");
                sP1.Close();
                timer2.Stop();
                btnAbrir.Enabled = true;
                cbBoxPort.Enabled = true;
                cbBoxBaud.Enabled = true;
                cbBoxData.Enabled = true;
                cbBoxStop.Enabled = true;
                cbBoxParity.Enabled = true;
                btnFechar.Enabled = false;
                btnSair.Enabled = true;
                ledNivelGreenOn.Visible = false;
                ledNivelGreenOff.Visible = true;
                ledNivelYellowOn.Visible = false;
                ledNivelYellowOff.Visible = true;
                ledNivelRedOn.Visible = false;
                ledNivelRedOff.Visible = true;
                ledSensorYellowOn.Visible = false;
                ledSensorYellowOff.Visible = true;
                ledSensorRedOn.Visible = false;
                ledSensorRedOff.Visible = true;
                bombaOn.Visible = false;
                bombaOff.Visible = true;
                controlOn.Visible = false;
                controlOff.Visible = true;
                lb7.Text = "Desconectado.";
                MessageBox.Show("Desconectado com sucesso!");
                pnlMsg.BackColor = Color.Red;
                btnSair.BackColor = Color.White;
                btnAbrir.BackColor = Color.White;
                btnFechar.BackColor = Color.DarkGray;
                gfSensores.Series[0].Points.Clear();
                gfSensores.Series[1].Points.Clear();
                lbBomba.Text = "Desativada";
                lbSensorF.Text = "000";
                lbSensorU.Text = "000.00";
                flagT = false;
                contT = 0;
                xGraph = 0;
            }
            catch
            {
                MessageBox.Show("Erro de comunicação com a porta.");
                btnAbrir.Enabled = false;
                cbBoxPort.Enabled = false;
                cbBoxBaud.Enabled = false;
                cbBoxData.Enabled = false;
                cbBoxStop.Enabled = false;
                cbBoxParity.Enabled = false;
                btnFechar.Enabled = true;
                btnSair.Enabled = false;
                lb7.Text = "Conectado.";
                pnlMsg.BackColor = Color.Green;
                btnSair.BackColor = Color.DarkGray;
                btnAbrir.BackColor = Color.DarkGray;
                btnFechar.BackColor = Color.White;
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        #region MudarCorBotao
        private void btnAbrir_MouseEnter(object sender, EventArgs e)
        {
            btnAbrir.BackColor = Color.LightBlue;
        }

        private void btnAbrir_MouseLeave(object sender, EventArgs e)
        {
            if(btnAbrir.Enabled) btnAbrir.BackColor = Color.White;
        }

        private void btnFechar_MouseEnter(object sender, EventArgs e)
        {
            btnFechar.BackColor = Color.LightBlue;
        }

        private void btnFechar_MouseLeave(object sender, EventArgs e)
        {
            btnFechar.BackColor = Color.White;
        }

        private void btnSair_MouseEnter(object sender, EventArgs e)
        {
            btnSair.BackColor = Color.LightBlue;
        }

        private void btnSair_MouseLeave(object sender, EventArgs e)
        {
            btnSair.BackColor = Color.White;
        }

        private void btnEviar_MouseEnter(object sender, EventArgs e)
        {
            btnEnviar.BackColor = Color.LightBlue;
        }

        private void btnEnviar_MouseLeave(object sender, EventArgs e)
        {
            btnEnviar.BackColor = Color.White;
        }

        #endregion
       
        private void btnEnviar_Click(object sender, EventArgs e)
        {
            if (sP1.IsOpen)
            {
                sP1.Write(txtEnviar.Text);
                txtEnviar.Text = "";
            }
            else MessageBox.Show("Erro de comunicação, a porta está fechada!");
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtRecp.Text = "";
        }

        private void ledSensorRedOff_Click(object sender, EventArgs e)
        {
            if(controlOff.Visible == true)
            {
                MessageBox.Show("Erro, controle manual desativado!");
                return;
            }
            if (sP1.IsOpen) sP1.Write("[LEDFR]");
            ledSensorRedOff.Visible = false;
            ledSensorRedOn.Visible = true;
        }
        private void ledSensorRedOn_Click(object sender, EventArgs e)
        {
            if (controlOff.Visible == true)
            {
                MessageBox.Show("Erro, controle manual desativado!");
                return;
            }
            if (sP1.IsOpen) sP1.Write("[LEDFR]");
            ledSensorRedOn.Visible = false;
                ledSensorRedOff.Visible = true;
        }
        private void ledSensorYellowOff_Click(object sender, EventArgs e)
        {
            if (controlOff.Visible == true)
            {
                MessageBox.Show("Erro, controle manual desativado!");
                return;
            }
            if (sP1.IsOpen) sP1.Write("[LEDFY]");
            ledSensorYellowOn.Visible = false;
            ledSensorYellowOff.Visible = true;
            ledSensorYellowOff.Visible = false;
            ledSensorYellowOn.Visible = true;
        }
        private void ledSensorYellowOn_Click(object sender, EventArgs e)
        {
            if (controlOff.Visible == true)
            {
                MessageBox.Show("Erro, controle manual desativado!");
                return;
            }
            if (sP1.IsOpen) sP1.Write("[LEDFY]");
            ledSensorYellowOn.Visible = false;
            ledSensorYellowOff.Visible = true;
        }
        private void ledNivelGreenOff_Click(object sender, EventArgs e)
        {
            if (controlOff.Visible == true)
            {
                MessageBox.Show("Erro, controle manual desativado!");
                return;
            }
            if (sP1.IsOpen) sP1.Write("[LEDUG]");
            ledNivelGreenOff.Visible = false;
            ledNivelGreenOn.Visible = true;
        }
        private void ledNivelGreenOn_Click(object sender, EventArgs e)
        {
            if (controlOff.Visible == true)
            {
                MessageBox.Show("Erro, controle manual desativado!");
                return;
            }
            if (sP1.IsOpen) sP1.Write("[LEDUG]");
            ledNivelGreenOn.Visible = false;
            ledNivelGreenOff.Visible = true;
        }
        private void ledNivelYellowOff_Click(object sender, EventArgs e)
        {
            if (controlOff.Visible == true)
            {
                MessageBox.Show("Erro, controle manual desativado!");
                return;
            }
            if (sP1.IsOpen) sP1.Write("[LEDUY]");
            ledNivelYellowOff.Visible = false;
            ledNivelYellowOn.Visible = true;
        }
        private void ledNivelYellowOn_Click(object sender, EventArgs e)
        {
            if (controlOff.Visible == true)
            {
                MessageBox.Show("Erro, controle manual desativado!");
                return;
            }
            if (sP1.IsOpen) sP1.Write("[LEDUY]");
            ledNivelYellowOn.Visible = false;
            ledNivelYellowOff.Visible = true;
        }
        private void ledNivelRedOff_Click(object sender, EventArgs e)
        {
            if (controlOff.Visible == true)
            {
                MessageBox.Show("Erro, controle manual desativado!");
                return;
            }
            if (sP1.IsOpen) sP1.Write("[LEDUR]");
            ledNivelRedOff.Visible = false;
            ledNivelRedOn.Visible = true;
        }
        private void ledNivelRedOn_Click(object sender, EventArgs e)
        {
            if (controlOff.Visible == true)
            {
                MessageBox.Show("Erro, controle manual desativado!");
                return;
            }
            if (sP1.IsOpen) sP1.Write("[LEDUR]");
            ledNivelRedOn.Visible = false;
            ledNivelRedOff.Visible = true;
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if(ledSensorRedOff.Visible == true)
            {
                ledSensorRedOn.Visible = true;
                ledSensorRedOff.Visible = false;
                ledSensorYellowOn.Visible = false;
                ledSensorYellowOff.Visible = true;
            }
            else
            {
                ledSensorRedOn.Visible = false;
                ledSensorRedOff.Visible = true;
                ledSensorYellowOn.Visible = true;
                ledSensorYellowOff.Visible = false;
            }
        }
        
        private void cbBoxPort_Click(object sender, EventArgs e)
        {
            cbBoxPort.Items.Clear();
            String[] valoresPort = SerialPort.GetPortNames();
            for (int i = 0; i < valoresPort.Length; i++)
            {
                cbBoxPort.Items.Add(valoresPort[i]);
            }
        }

        private void bombaOff_Click(object sender, EventArgs e)
        {
            if (controlOff.Visible == true)
            {
                MessageBox.Show("Erro, controle manual desativado!");
                return;
            }
            if (sP1.IsOpen) sP1.Write("[BOMBA]");
            lbBomba.Text = "Ativada";
            bombaOff.Visible = false;
            bombaOn.Visible = true;
        }

        private void bombaOn_Click(object sender, EventArgs e)
        {
            if (controlOff.Visible == true)
            {
                MessageBox.Show("Erro, controle manual desativado!");
                return;
            }
            if (sP1.IsOpen) sP1.Write("[BOMBA]");
            lbBomba.Text = "Desativada";
            bombaOff.Visible = true;
            bombaOn.Visible = false;
        }

        int contT = 0;
        private void btnLimpar_MouseEnter(object sender, EventArgs e)
        {
            btnLimpar.BackColor = Color.Aqua;
        }

        private void btnLimpar_MouseLeave(object sender, EventArgs e)
        {
            btnLimpar.BackColor = Color.White;
        }

        private void controlOff_Click(object sender, EventArgs e)
        {
            if (sP1.IsOpen)
            {
                sP1.Write("[CTROL]");
                ledNivelGreenOn.Visible = false;
                ledNivelGreenOff.Visible = true;
                ledNivelYellowOn.Visible = false;
                ledNivelYellowOff.Visible = true;
                ledNivelRedOn.Visible = false;
                ledNivelRedOff.Visible = true;
                ledSensorYellowOn.Visible = false;
                ledSensorYellowOff.Visible = true;
                ledSensorRedOn.Visible = false;
                ledSensorRedOff.Visible = true;
                bombaOn.Visible = false;
                bombaOff.Visible = true;
                controlOff.Visible = false;
                controlOn.Visible = true;
                if (!timer1.Enabled)
                {
                    ledSensorRedOn.Visible = false;
                    ledSensorRedOff.Visible = true;
                    ledSensorYellowOn.Visible = false;
                    ledSensorYellowOff.Visible = true;
                }
            }
        }

        private void controlOn_Click(object sender, EventArgs e)
        {
            if (sP1.IsOpen) sP1.Write("[CTROL]");
            ledNivelGreenOn.Visible = false;
            ledNivelGreenOff.Visible = true;
            ledNivelYellowOn.Visible = false;
            ledNivelYellowOff.Visible = true;
            ledNivelRedOn.Visible = false;
            ledNivelRedOff.Visible = true;
            ledSensorYellowOn.Visible = false;
            ledSensorYellowOff.Visible = true;
            ledSensorRedOn.Visible = false;
            ledSensorRedOff.Visible = true;
            bombaOn.Visible = false;
            bombaOff.Visible = true;
            controlOn.Visible = false;
            controlOff.Visible = true;
        }

        private void Timer2_Tick(object sender, EventArgs e)
        {
            contT++;
            if(contT >= 40)
            {
                if(flagT == false)
                {
                    //TIMER
                    if(sP1.IsOpen) sP1.Write("[TIMER]");
                    contT = 0;
                }
                else
                {
                    //STOP
                    if (sP1.IsOpen) sP1.Write("[STOPX]");
                    timer2.Stop();
                    sP1.Close();
                    btnAbrir.Enabled = true;
                    cbBoxPort.Enabled = true;
                    cbBoxBaud.Enabled = true;
                    cbBoxData.Enabled = true;
                    cbBoxStop.Enabled = true;
                    cbBoxParity.Enabled = true;
                    btnFechar.Enabled = false;
                    btnSair.Enabled = true;
                    controlOn.Visible = false;
                    controlOff.Visible = true;
                    lb7.Text = "Desconectado.";
                    pnlMsg.BackColor = Color.Red;
                    btnSair.BackColor = Color.White;
                    btnAbrir.BackColor = Color.White;
                    btnFechar.BackColor = Color.DarkGray;
                    gfSensores.Series[0].Points.Clear();
                    gfSensores.Series[1].Points.Clear();
                    flagT = false;
                    contT = 0;
                    xGraph = 0;
                    MessageBox.Show("Erro de comunicação com o arduino.");
                }
            }
            else
            {
                if(contT == 10)
                {
                    //TIME
                    if (sP1.IsOpen) sP1.Write("[TIMER]");
                    flagT = true;
                }
            }
        }
    }
}