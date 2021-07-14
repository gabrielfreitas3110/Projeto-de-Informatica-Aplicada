
namespace Projeto_Infap
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.controlOff = new System.Windows.Forms.PictureBox();
            this.pnlMsg = new System.Windows.Forms.Panel();
            this.lb7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnAbrir = new System.Windows.Forms.Button();
            this.cbBoxParity = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbBoxStop = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbBoxData = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbBoxBaud = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbBoxPort = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.controlOn = new System.Windows.Forms.PictureBox();
            this.sP1 = new System.IO.Ports.SerialPort(this.components);
            this.tbControl1 = new System.Windows.Forms.TabControl();
            this.tbPage1 = new System.Windows.Forms.TabPage();
            this.gpBox2 = new System.Windows.Forms.GroupBox();
            this.txtRecp = new System.Windows.Forms.TextBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.gpBox1 = new System.Windows.Forms.GroupBox();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.txtEnviar = new System.Windows.Forms.TextBox();
            this.tbPage2 = new System.Windows.Forms.TabPage();
            this.gbBox3 = new System.Windows.Forms.GroupBox();
            this.lbsensorUA = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.bombaOn = new System.Windows.Forms.PictureBox();
            this.bombaOff = new System.Windows.Forms.PictureBox();
            this.lbBomba = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lbSensorF = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbSensorU = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.tbPage3 = new System.Windows.Forms.TabPage();
            this.ledNivelGreenOn = new System.Windows.Forms.PictureBox();
            this.ledNivelGreenOff = new System.Windows.Forms.PictureBox();
            this.ledNivelYellowOn = new System.Windows.Forms.PictureBox();
            this.ledNivelRedOn = new System.Windows.Forms.PictureBox();
            this.ledNivelYellowOff = new System.Windows.Forms.PictureBox();
            this.ledNivelRedOff = new System.Windows.Forms.PictureBox();
            this.lbLedsNivel = new System.Windows.Forms.Label();
            this.ledSensorYellowOn = new System.Windows.Forms.PictureBox();
            this.ledSensorRedOn = new System.Windows.Forms.PictureBox();
            this.ledSensorYellowOff = new System.Windows.Forms.PictureBox();
            this.ledSensorRedOff = new System.Windows.Forms.PictureBox();
            this.lbLedsSensores = new System.Windows.Forms.Label();
            this.tbPage4 = new System.Windows.Forms.TabPage();
            this.gfSensores = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.controlOff)).BeginInit();
            this.pnlMsg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.controlOn)).BeginInit();
            this.tbControl1.SuspendLayout();
            this.tbPage1.SuspendLayout();
            this.gpBox2.SuspendLayout();
            this.gpBox1.SuspendLayout();
            this.tbPage2.SuspendLayout();
            this.gbBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bombaOn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bombaOff)).BeginInit();
            this.tbPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ledNivelGreenOn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ledNivelGreenOff)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ledNivelYellowOn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ledNivelRedOn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ledNivelYellowOff)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ledNivelRedOff)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ledSensorYellowOn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ledSensorRedOn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ledSensorYellowOff)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ledSensorRedOff)).BeginInit();
            this.tbPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gfSensores)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.controlOff);
            this.panel1.Controls.Add(this.pnlMsg);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.btnSair);
            this.panel1.Controls.Add(this.btnFechar);
            this.panel1.Controls.Add(this.btnAbrir);
            this.panel1.Controls.Add(this.cbBoxParity);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.cbBoxStop);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.cbBoxData);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cbBoxBaud);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cbBoxPort);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.controlOn);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(275, 525);
            this.panel1.TabIndex = 1;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(15, 362);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(109, 22);
            this.label14.TabIndex = 1000;
            this.label14.Text = "Controle:";
            // 
            // controlOff
            // 
            this.controlOff.Image = ((System.Drawing.Image)(resources.GetObject("controlOff.Image")));
            this.controlOff.Location = new System.Drawing.Point(140, 359);
            this.controlOff.Name = "controlOff";
            this.controlOff.Size = new System.Drawing.Size(110, 55);
            this.controlOff.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.controlOff.TabIndex = 13;
            this.controlOff.TabStop = false;
            this.controlOff.Click += new System.EventHandler(this.controlOff_Click);
            // 
            // pnlMsg
            // 
            this.pnlMsg.BackColor = System.Drawing.Color.Red;
            this.pnlMsg.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlMsg.Controls.Add(this.lb7);
            this.pnlMsg.Location = new System.Drawing.Point(19, 450);
            this.pnlMsg.Name = "pnlMsg";
            this.pnlMsg.Size = new System.Drawing.Size(232, 49);
            this.pnlMsg.TabIndex = 999;
            // 
            // lb7
            // 
            this.lb7.AutoSize = true;
            this.lb7.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold);
            this.lb7.Location = new System.Drawing.Point(47, 12);
            this.lb7.Name = "lb7";
            this.lb7.Size = new System.Drawing.Size(142, 22);
            this.lb7.TabIndex = 0;
            this.lb7.Text = "Desconectado";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(16, 431);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(152, 16);
            this.label6.TabIndex = 999;
            this.label6.Text = "Connection Status:";
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.White;
            this.btnSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSair.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(19, 296);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(232, 50);
            this.btnSair.TabIndex = 7;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            this.btnSair.MouseEnter += new System.EventHandler(this.btnSair_MouseEnter);
            this.btnSair.MouseLeave += new System.EventHandler(this.btnSair_MouseLeave);
            // 
            // btnFechar
            // 
            this.btnFechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFechar.Enabled = false;
            this.btnFechar.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.Location = new System.Drawing.Point(166, 240);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(85, 50);
            this.btnFechar.TabIndex = 6;
            this.btnFechar.Text = "Fechar Porta";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.BtnFechar_Click);
            this.btnFechar.MouseEnter += new System.EventHandler(this.btnFechar_MouseEnter);
            this.btnFechar.MouseLeave += new System.EventHandler(this.btnFechar_MouseLeave);
            // 
            // btnAbrir
            // 
            this.btnAbrir.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnAbrir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAbrir.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbrir.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAbrir.Location = new System.Drawing.Point(19, 240);
            this.btnAbrir.Name = "btnAbrir";
            this.btnAbrir.Size = new System.Drawing.Size(75, 50);
            this.btnAbrir.TabIndex = 5;
            this.btnAbrir.Text = "Abrir Porta";
            this.btnAbrir.UseVisualStyleBackColor = false;
            this.btnAbrir.Click += new System.EventHandler(this.BtnAbrir_Click);
            this.btnAbrir.MouseEnter += new System.EventHandler(this.btnAbrir_MouseEnter);
            this.btnAbrir.MouseLeave += new System.EventHandler(this.btnAbrir_MouseLeave);
            // 
            // cbBoxParity
            // 
            this.cbBoxParity.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBoxParity.FormattingEnabled = true;
            this.cbBoxParity.Location = new System.Drawing.Point(130, 191);
            this.cbBoxParity.Name = "cbBoxParity";
            this.cbBoxParity.Size = new System.Drawing.Size(121, 26);
            this.cbBoxParity.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 22);
            this.label5.TabIndex = 999;
            this.label5.Text = "Parity:";
            // 
            // cbBoxStop
            // 
            this.cbBoxStop.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBoxStop.FormattingEnabled = true;
            this.cbBoxStop.Location = new System.Drawing.Point(130, 146);
            this.cbBoxStop.Name = "cbBoxStop";
            this.cbBoxStop.Size = new System.Drawing.Size(121, 26);
            this.cbBoxStop.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 22);
            this.label4.TabIndex = 999;
            this.label4.Text = "Stop Bits:";
            // 
            // cbBoxData
            // 
            this.cbBoxData.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBoxData.FormattingEnabled = true;
            this.cbBoxData.Location = new System.Drawing.Point(130, 101);
            this.cbBoxData.Name = "cbBoxData";
            this.cbBoxData.Size = new System.Drawing.Size(121, 26);
            this.cbBoxData.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 22);
            this.label3.TabIndex = 999;
            this.label3.Text = "Data Bits:";
            // 
            // cbBoxBaud
            // 
            this.cbBoxBaud.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBoxBaud.FormattingEnabled = true;
            this.cbBoxBaud.Location = new System.Drawing.Point(130, 61);
            this.cbBoxBaud.Name = "cbBoxBaud";
            this.cbBoxBaud.Size = new System.Drawing.Size(121, 26);
            this.cbBoxBaud.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 22);
            this.label2.TabIndex = 999;
            this.label2.Text = "Baud Rate:";
            // 
            // cbBoxPort
            // 
            this.cbBoxPort.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBoxPort.FormattingEnabled = true;
            this.cbBoxPort.Location = new System.Drawing.Point(130, 16);
            this.cbBoxPort.Name = "cbBoxPort";
            this.cbBoxPort.Size = new System.Drawing.Size(121, 26);
            this.cbBoxPort.TabIndex = 0;
            this.cbBoxPort.Click += new System.EventHandler(this.cbBoxPort_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 22);
            this.label1.TabIndex = 999;
            this.label1.Text = "COM Port:";
            // 
            // controlOn
            // 
            this.controlOn.Image = ((System.Drawing.Image)(resources.GetObject("controlOn.Image")));
            this.controlOn.Location = new System.Drawing.Point(128, 354);
            this.controlOn.Name = "controlOn";
            this.controlOn.Size = new System.Drawing.Size(134, 67);
            this.controlOn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.controlOn.TabIndex = 1001;
            this.controlOn.TabStop = false;
            this.controlOn.Visible = false;
            this.controlOn.Click += new System.EventHandler(this.controlOn_Click);
            // 
            // tbControl1
            // 
            this.tbControl1.Controls.Add(this.tbPage1);
            this.tbControl1.Controls.Add(this.tbPage2);
            this.tbControl1.Controls.Add(this.tbPage3);
            this.tbControl1.Controls.Add(this.tbPage4);
            this.tbControl1.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbControl1.Location = new System.Drawing.Point(293, 12);
            this.tbControl1.Name = "tbControl1";
            this.tbControl1.SelectedIndex = 0;
            this.tbControl1.Size = new System.Drawing.Size(600, 525);
            this.tbControl1.TabIndex = 8;
            // 
            // tbPage1
            // 
            this.tbPage1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.tbPage1.Controls.Add(this.gpBox2);
            this.tbPage1.Controls.Add(this.gpBox1);
            this.tbPage1.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold);
            this.tbPage1.Location = new System.Drawing.Point(4, 31);
            this.tbPage1.Name = "tbPage1";
            this.tbPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tbPage1.Size = new System.Drawing.Size(592, 490);
            this.tbPage1.TabIndex = 0;
            this.tbPage1.Text = "Monitor Serial";
            // 
            // gpBox2
            // 
            this.gpBox2.Controls.Add(this.txtRecp);
            this.gpBox2.Controls.Add(this.btnLimpar);
            this.gpBox2.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpBox2.ForeColor = System.Drawing.Color.Black;
            this.gpBox2.Location = new System.Drawing.Point(7, 92);
            this.gpBox2.Name = "gpBox2";
            this.gpBox2.Size = new System.Drawing.Size(579, 396);
            this.gpBox2.TabIndex = 1;
            this.gpBox2.TabStop = false;
            this.gpBox2.Text = "Recepção";
            // 
            // txtRecp
            // 
            this.txtRecp.Enabled = false;
            this.txtRecp.Location = new System.Drawing.Point(5, 55);
            this.txtRecp.Multiline = true;
            this.txtRecp.Name = "txtRecp";
            this.txtRecp.Size = new System.Drawing.Size(568, 335);
            this.txtRecp.TabIndex = 12;
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.White;
            this.btnLimpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpar.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.ForeColor = System.Drawing.Color.Black;
            this.btnLimpar.Location = new System.Drawing.Point(493, 20);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(80, 29);
            this.btnLimpar.TabIndex = 11;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            this.btnLimpar.MouseEnter += new System.EventHandler(this.btnLimpar_MouseEnter);
            this.btnLimpar.MouseLeave += new System.EventHandler(this.btnLimpar_MouseLeave);
            // 
            // gpBox1
            // 
            this.gpBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.gpBox1.Controls.Add(this.btnEnviar);
            this.gpBox1.Controls.Add(this.txtEnviar);
            this.gpBox1.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpBox1.Location = new System.Drawing.Point(6, 6);
            this.gpBox1.Name = "gpBox1";
            this.gpBox1.Size = new System.Drawing.Size(580, 80);
            this.gpBox1.TabIndex = 0;
            this.gpBox1.TabStop = false;
            this.gpBox1.Text = "Transmissão";
            // 
            // btnEnviar
            // 
            this.btnEnviar.BackColor = System.Drawing.Color.White;
            this.btnEnviar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEnviar.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviar.Location = new System.Drawing.Point(494, 25);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(80, 29);
            this.btnEnviar.TabIndex = 10;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = false;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            this.btnEnviar.MouseEnter += new System.EventHandler(this.btnEviar_MouseEnter);
            this.btnEnviar.MouseLeave += new System.EventHandler(this.btnEnviar_MouseLeave);
            // 
            // txtEnviar
            // 
            this.txtEnviar.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEnviar.Location = new System.Drawing.Point(6, 25);
            this.txtEnviar.Name = "txtEnviar";
            this.txtEnviar.Size = new System.Drawing.Size(480, 26);
            this.txtEnviar.TabIndex = 9;
            // 
            // tbPage2
            // 
            this.tbPage2.Controls.Add(this.gbBox3);
            this.tbPage2.Location = new System.Drawing.Point(4, 31);
            this.tbPage2.Name = "tbPage2";
            this.tbPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tbPage2.Size = new System.Drawing.Size(592, 490);
            this.tbPage2.TabIndex = 1;
            this.tbPage2.Text = "Sensores/Relés";
            this.tbPage2.UseVisualStyleBackColor = true;
            // 
            // gbBox3
            // 
            this.gbBox3.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.gbBox3.Controls.Add(this.lbsensorUA);
            this.gbBox3.Controls.Add(this.label12);
            this.gbBox3.Controls.Add(this.bombaOn);
            this.gbBox3.Controls.Add(this.bombaOff);
            this.gbBox3.Controls.Add(this.lbBomba);
            this.gbBox3.Controls.Add(this.label11);
            this.gbBox3.Controls.Add(this.label10);
            this.gbBox3.Controls.Add(this.lbSensorF);
            this.gbBox3.Controls.Add(this.label9);
            this.gbBox3.Controls.Add(this.label7);
            this.gbBox3.Controls.Add(this.lbSensorU);
            this.gbBox3.Controls.Add(this.label8);
            this.gbBox3.Controls.Add(this.label13);
            this.gbBox3.Location = new System.Drawing.Point(7, 7);
            this.gbBox3.Name = "gbBox3";
            this.gbBox3.Size = new System.Drawing.Size(579, 262);
            this.gbBox3.TabIndex = 0;
            this.gbBox3.TabStop = false;
            // 
            // lbsensorUA
            // 
            this.lbsensorUA.AutoSize = true;
            this.lbsensorUA.Location = new System.Drawing.Point(365, 63);
            this.lbsensorUA.Name = "lbsensorUA";
            this.lbsensorUA.Size = new System.Drawing.Size(76, 22);
            this.lbsensorUA.TabIndex = 13;
            this.lbsensorUA.Text = "000,00";
            this.lbsensorUA.Visible = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(327, 63);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(32, 22);
            this.label12.TabIndex = 12;
            this.label12.Text = "ou";
            this.label12.Visible = false;
            // 
            // bombaOn
            // 
            this.bombaOn.Image = ((System.Drawing.Image)(resources.GetObject("bombaOn.Image")));
            this.bombaOn.Location = new System.Drawing.Point(10, 129);
            this.bombaOn.Name = "bombaOn";
            this.bombaOn.Size = new System.Drawing.Size(127, 127);
            this.bombaOn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bombaOn.TabIndex = 11;
            this.bombaOn.TabStop = false;
            this.bombaOn.Visible = false;
            this.bombaOn.Click += new System.EventHandler(this.bombaOn_Click);
            // 
            // bombaOff
            // 
            this.bombaOff.Image = ((System.Drawing.Image)(resources.GetObject("bombaOff.Image")));
            this.bombaOff.Location = new System.Drawing.Point(10, 129);
            this.bombaOff.Name = "bombaOff";
            this.bombaOff.Size = new System.Drawing.Size(127, 127);
            this.bombaOff.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bombaOff.TabIndex = 10;
            this.bombaOff.TabStop = false;
            this.bombaOff.Click += new System.EventHandler(this.bombaOff_Click);
            // 
            // lbBomba
            // 
            this.lbBomba.AutoSize = true;
            this.lbBomba.Location = new System.Drawing.Point(88, 103);
            this.lbBomba.Name = "lbBomba";
            this.lbBomba.Size = new System.Drawing.Size(120, 22);
            this.lbBomba.TabIndex = 9;
            this.lbBomba.Text = "Desativada";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 103);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(76, 22);
            this.label11.TabIndex = 8;
            this.label11.Text = "Bomba:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(237, 23);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 22);
            this.label10.TabIndex = 7;
            this.label10.Text = "ppm";
            // 
            // lbSensorF
            // 
            this.lbSensorF.AutoSize = true;
            this.lbSensorF.Location = new System.Drawing.Point(199, 23);
            this.lbSensorF.Name = "lbSensorF";
            this.lbSensorF.Size = new System.Drawing.Size(43, 22);
            this.lbSensorF.TabIndex = 5;
            this.lbSensorF.Text = "000";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(197, 22);
            this.label9.TabIndex = 4;
            this.label9.Text = "Sensor de fumaça:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(230, 22);
            this.label7.TabIndex = 2;
            this.label7.Text = "Sensor Ultrassonico:";
            // 
            // lbSensorU
            // 
            this.lbSensorU.AutoSize = true;
            this.lbSensorU.Location = new System.Drawing.Point(234, 63);
            this.lbSensorU.Name = "lbSensorU";
            this.lbSensorU.Size = new System.Drawing.Size(54, 22);
            this.lbSensorU.TabIndex = 3;
            this.lbSensorU.Text = "0,00";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(283, 63);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 22);
            this.label8.TabIndex = 6;
            this.label8.Text = "cm";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(438, 63);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(32, 22);
            this.label13.TabIndex = 14;
            this.label13.Text = "ml";
            this.label13.Visible = false;
            // 
            // tbPage3
            // 
            this.tbPage3.Controls.Add(this.ledNivelGreenOn);
            this.tbPage3.Controls.Add(this.ledNivelGreenOff);
            this.tbPage3.Controls.Add(this.ledNivelYellowOn);
            this.tbPage3.Controls.Add(this.ledNivelRedOn);
            this.tbPage3.Controls.Add(this.ledNivelYellowOff);
            this.tbPage3.Controls.Add(this.ledNivelRedOff);
            this.tbPage3.Controls.Add(this.lbLedsNivel);
            this.tbPage3.Controls.Add(this.ledSensorYellowOn);
            this.tbPage3.Controls.Add(this.ledSensorRedOn);
            this.tbPage3.Controls.Add(this.ledSensorYellowOff);
            this.tbPage3.Controls.Add(this.ledSensorRedOff);
            this.tbPage3.Controls.Add(this.lbLedsSensores);
            this.tbPage3.Location = new System.Drawing.Point(4, 31);
            this.tbPage3.Name = "tbPage3";
            this.tbPage3.Size = new System.Drawing.Size(592, 490);
            this.tbPage3.TabIndex = 3;
            this.tbPage3.Text = "Leds";
            this.tbPage3.UseVisualStyleBackColor = true;
            // 
            // ledNivelGreenOn
            // 
            this.ledNivelGreenOn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ledNivelGreenOn.Image = ((System.Drawing.Image)(resources.GetObject("ledNivelGreenOn.Image")));
            this.ledNivelGreenOn.Location = new System.Drawing.Point(8, 233);
            this.ledNivelGreenOn.Name = "ledNivelGreenOn";
            this.ledNivelGreenOn.Size = new System.Drawing.Size(75, 75);
            this.ledNivelGreenOn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ledNivelGreenOn.TabIndex = 12;
            this.ledNivelGreenOn.TabStop = false;
            this.ledNivelGreenOn.Visible = false;
            this.ledNivelGreenOn.Click += new System.EventHandler(this.ledNivelGreenOn_Click);
            // 
            // ledNivelGreenOff
            // 
            this.ledNivelGreenOff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ledNivelGreenOff.Image = ((System.Drawing.Image)(resources.GetObject("ledNivelGreenOff.Image")));
            this.ledNivelGreenOff.Location = new System.Drawing.Point(8, 233);
            this.ledNivelGreenOff.Name = "ledNivelGreenOff";
            this.ledNivelGreenOff.Size = new System.Drawing.Size(75, 75);
            this.ledNivelGreenOff.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ledNivelGreenOff.TabIndex = 11;
            this.ledNivelGreenOff.TabStop = false;
            this.ledNivelGreenOff.Click += new System.EventHandler(this.ledNivelGreenOff_Click);
            // 
            // ledNivelYellowOn
            // 
            this.ledNivelYellowOn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ledNivelYellowOn.Image = ((System.Drawing.Image)(resources.GetObject("ledNivelYellowOn.Image")));
            this.ledNivelYellowOn.Location = new System.Drawing.Point(8, 314);
            this.ledNivelYellowOn.Name = "ledNivelYellowOn";
            this.ledNivelYellowOn.Size = new System.Drawing.Size(75, 75);
            this.ledNivelYellowOn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ledNivelYellowOn.TabIndex = 10;
            this.ledNivelYellowOn.TabStop = false;
            this.ledNivelYellowOn.Visible = false;
            this.ledNivelYellowOn.Click += new System.EventHandler(this.ledNivelYellowOn_Click);
            // 
            // ledNivelRedOn
            // 
            this.ledNivelRedOn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ledNivelRedOn.Image = ((System.Drawing.Image)(resources.GetObject("ledNivelRedOn.Image")));
            this.ledNivelRedOn.Location = new System.Drawing.Point(8, 395);
            this.ledNivelRedOn.Name = "ledNivelRedOn";
            this.ledNivelRedOn.Size = new System.Drawing.Size(75, 75);
            this.ledNivelRedOn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ledNivelRedOn.TabIndex = 9;
            this.ledNivelRedOn.TabStop = false;
            this.ledNivelRedOn.Visible = false;
            this.ledNivelRedOn.Click += new System.EventHandler(this.ledNivelRedOn_Click);
            // 
            // ledNivelYellowOff
            // 
            this.ledNivelYellowOff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ledNivelYellowOff.Image = ((System.Drawing.Image)(resources.GetObject("ledNivelYellowOff.Image")));
            this.ledNivelYellowOff.Location = new System.Drawing.Point(8, 314);
            this.ledNivelYellowOff.Name = "ledNivelYellowOff";
            this.ledNivelYellowOff.Size = new System.Drawing.Size(75, 75);
            this.ledNivelYellowOff.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ledNivelYellowOff.TabIndex = 8;
            this.ledNivelYellowOff.TabStop = false;
            this.ledNivelYellowOff.Click += new System.EventHandler(this.ledNivelYellowOff_Click);
            // 
            // ledNivelRedOff
            // 
            this.ledNivelRedOff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ledNivelRedOff.Image = ((System.Drawing.Image)(resources.GetObject("ledNivelRedOff.Image")));
            this.ledNivelRedOff.Location = new System.Drawing.Point(8, 395);
            this.ledNivelRedOff.Name = "ledNivelRedOff";
            this.ledNivelRedOff.Size = new System.Drawing.Size(75, 75);
            this.ledNivelRedOff.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ledNivelRedOff.TabIndex = 7;
            this.ledNivelRedOff.TabStop = false;
            this.ledNivelRedOff.Click += new System.EventHandler(this.ledNivelRedOff_Click);
            // 
            // lbLedsNivel
            // 
            this.lbLedsNivel.AutoSize = true;
            this.lbLedsNivel.Location = new System.Drawing.Point(4, 207);
            this.lbLedsNivel.Name = "lbLedsNivel";
            this.lbLedsNivel.Size = new System.Drawing.Size(241, 22);
            this.lbLedsNivel.TabIndex = 6;
            this.lbLedsNivel.Text = "Leds do Nivel de água";
            // 
            // ledSensorYellowOn
            // 
            this.ledSensorYellowOn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ledSensorYellowOn.Image = ((System.Drawing.Image)(resources.GetObject("ledSensorYellowOn.Image")));
            this.ledSensorYellowOn.Location = new System.Drawing.Point(89, 30);
            this.ledSensorYellowOn.Name = "ledSensorYellowOn";
            this.ledSensorYellowOn.Size = new System.Drawing.Size(75, 75);
            this.ledSensorYellowOn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ledSensorYellowOn.TabIndex = 5;
            this.ledSensorYellowOn.TabStop = false;
            this.ledSensorYellowOn.Visible = false;
            this.ledSensorYellowOn.Click += new System.EventHandler(this.ledSensorYellowOn_Click);
            // 
            // ledSensorRedOn
            // 
            this.ledSensorRedOn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ledSensorRedOn.Image = ((System.Drawing.Image)(resources.GetObject("ledSensorRedOn.Image")));
            this.ledSensorRedOn.Location = new System.Drawing.Point(8, 30);
            this.ledSensorRedOn.Name = "ledSensorRedOn";
            this.ledSensorRedOn.Size = new System.Drawing.Size(75, 75);
            this.ledSensorRedOn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ledSensorRedOn.TabIndex = 4;
            this.ledSensorRedOn.TabStop = false;
            this.ledSensorRedOn.Visible = false;
            this.ledSensorRedOn.Click += new System.EventHandler(this.ledSensorRedOn_Click);
            // 
            // ledSensorYellowOff
            // 
            this.ledSensorYellowOff.Image = ((System.Drawing.Image)(resources.GetObject("ledSensorYellowOff.Image")));
            this.ledSensorYellowOff.Location = new System.Drawing.Point(89, 30);
            this.ledSensorYellowOff.Name = "ledSensorYellowOff";
            this.ledSensorYellowOff.Size = new System.Drawing.Size(75, 75);
            this.ledSensorYellowOff.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ledSensorYellowOff.TabIndex = 3;
            this.ledSensorYellowOff.TabStop = false;
            this.ledSensorYellowOff.Click += new System.EventHandler(this.ledSensorYellowOff_Click);
            // 
            // ledSensorRedOff
            // 
            this.ledSensorRedOff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ledSensorRedOff.Image = ((System.Drawing.Image)(resources.GetObject("ledSensorRedOff.Image")));
            this.ledSensorRedOff.Location = new System.Drawing.Point(8, 30);
            this.ledSensorRedOff.Name = "ledSensorRedOff";
            this.ledSensorRedOff.Size = new System.Drawing.Size(75, 75);
            this.ledSensorRedOff.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ledSensorRedOff.TabIndex = 2;
            this.ledSensorRedOff.TabStop = false;
            this.ledSensorRedOff.Click += new System.EventHandler(this.ledSensorRedOff_Click);
            // 
            // lbLedsSensores
            // 
            this.lbLedsSensores.AutoSize = true;
            this.lbLedsSensores.Location = new System.Drawing.Point(4, 4);
            this.lbLedsSensores.Name = "lbLedsSensores";
            this.lbLedsSensores.Size = new System.Drawing.Size(164, 22);
            this.lbLedsSensores.TabIndex = 1;
            this.lbLedsSensores.Text = "Leds do Alarme";
            // 
            // tbPage4
            // 
            this.tbPage4.Controls.Add(this.gfSensores);
            this.tbPage4.Location = new System.Drawing.Point(4, 31);
            this.tbPage4.Name = "tbPage4";
            this.tbPage4.Size = new System.Drawing.Size(592, 490);
            this.tbPage4.TabIndex = 4;
            this.tbPage4.Text = "Gráficos";
            this.tbPage4.UseVisualStyleBackColor = true;
            // 
            // gfSensores
            // 
            chartArea4.Name = "ChartArea1";
            this.gfSensores.ChartAreas.Add(chartArea4);
            legend4.Alignment = System.Drawing.StringAlignment.Center;
            legend4.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend4.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend4.IsTextAutoFit = false;
            legend4.Name = "Legend1";
            legend4.TitleFont = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gfSensores.Legends.Add(legend4);
            this.gfSensores.Location = new System.Drawing.Point(0, 3);
            this.gfSensores.Name = "gfSensores";
            this.gfSensores.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series7.Legend = "Legend1";
            series7.LegendText = "Sensor de fumça(ppm)";
            series7.Name = "Sensor de Fumaça";
            series7.YValuesPerPoint = 6;
            series8.ChartArea = "ChartArea1";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series8.Legend = "Legend1";
            series8.LegendText = "Sensor Ultrassonico";
            series8.Name = "Sensor Ultrassonico";
            this.gfSensores.Series.Add(series7);
            this.gfSensores.Series.Add(series8);
            this.gfSensores.Size = new System.Drawing.Size(592, 487);
            this.gfSensores.TabIndex = 0;
            this.gfSensores.Text = "chart1";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.Timer2_Tick);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(904, 561);
            this.Controls.Add(this.tbControl1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Repositório";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.controlOff)).EndInit();
            this.pnlMsg.ResumeLayout(false);
            this.pnlMsg.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.controlOn)).EndInit();
            this.tbControl1.ResumeLayout(false);
            this.tbPage1.ResumeLayout(false);
            this.gpBox2.ResumeLayout(false);
            this.gpBox2.PerformLayout();
            this.gpBox1.ResumeLayout(false);
            this.gpBox1.PerformLayout();
            this.tbPage2.ResumeLayout(false);
            this.gbBox3.ResumeLayout(false);
            this.gbBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bombaOn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bombaOff)).EndInit();
            this.tbPage3.ResumeLayout(false);
            this.tbPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ledNivelGreenOn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ledNivelGreenOff)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ledNivelYellowOn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ledNivelRedOn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ledNivelYellowOff)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ledNivelRedOff)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ledSensorYellowOn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ledSensorRedOn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ledSensorYellowOff)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ledSensorRedOff)).EndInit();
            this.tbPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gfSensores)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlMsg;
        private System.Windows.Forms.Label lb7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnAbrir;
        private System.Windows.Forms.ComboBox cbBoxStop;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbBoxPort;
        private System.Windows.Forms.Label label1;
        private System.IO.Ports.SerialPort sP1;
        private System.Windows.Forms.TabControl tbControl1;
        private System.Windows.Forms.TabPage tbPage1;
        private System.Windows.Forms.TabPage tbPage2;
        private System.Windows.Forms.TabPage tbPage3;
        private System.Windows.Forms.GroupBox gpBox1;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.TextBox txtEnviar;
        private System.Windows.Forms.GroupBox gpBox2;
        private System.Windows.Forms.TextBox txtRecp;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.PictureBox ledSensorYellowOff;
        private System.Windows.Forms.PictureBox ledSensorRedOff;
        private System.Windows.Forms.Label lbLedsSensores;
        private System.Windows.Forms.PictureBox ledSensorYellowOn;
        private System.Windows.Forms.PictureBox ledSensorRedOn;
        private System.Windows.Forms.PictureBox ledNivelGreenOn;
        private System.Windows.Forms.PictureBox ledNivelGreenOff;
        private System.Windows.Forms.PictureBox ledNivelYellowOn;
        private System.Windows.Forms.PictureBox ledNivelRedOn;
        private System.Windows.Forms.PictureBox ledNivelYellowOff;
        private System.Windows.Forms.PictureBox ledNivelRedOff;
        private System.Windows.Forms.Label lbLedsNivel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox gbBox3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbSensorF;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbSensorU;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbBoxParity;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbBoxData;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbBoxBaud;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tbPage4;
        private System.Windows.Forms.DataVisualization.Charting.Chart gfSensores;
        private System.Windows.Forms.Label lbBomba;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.PictureBox bombaOn;
        private System.Windows.Forms.PictureBox bombaOff;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lbsensorUA;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.PictureBox controlOff;
        private System.Windows.Forms.PictureBox controlOn;
    }
}

