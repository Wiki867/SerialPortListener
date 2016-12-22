namespace SerialPortListener
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.settingsGb = new System.Windows.Forms.GroupBox();
            this.stopBitsCb = new System.Windows.Forms.ComboBox();
            this.parityCb = new System.Windows.Forms.ComboBox();
            this.dataBitsCb = new System.Windows.Forms.ComboBox();
            this.baudRateCb = new System.Windows.Forms.ComboBox();
            this.portNameCb = new System.Windows.Forms.ComboBox();
            this.listenBtn = new System.Windows.Forms.Button();
            this.stopBitsLbl = new System.Windows.Forms.Label();
            this.parityLbl = new System.Windows.Forms.Label();
            this.dataBitsLbl = new System.Windows.Forms.Label();
            this.baudRateLbl = new System.Windows.Forms.Label();
            this.portNameLbl = new System.Windows.Forms.Label();
            this.resultTb = new System.Windows.Forms.TextBox();
            this.serialSettingsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.settingsGb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.serialSettingsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // settingsGb
            // 
            this.settingsGb.Controls.Add(this.stopBitsCb);
            this.settingsGb.Controls.Add(this.parityCb);
            this.settingsGb.Controls.Add(this.dataBitsCb);
            this.settingsGb.Controls.Add(this.baudRateCb);
            this.settingsGb.Controls.Add(this.portNameCb);
            this.settingsGb.Controls.Add(this.listenBtn);
            this.settingsGb.Controls.Add(this.stopBitsLbl);
            this.settingsGb.Controls.Add(this.parityLbl);
            this.settingsGb.Controls.Add(this.dataBitsLbl);
            this.settingsGb.Controls.Add(this.baudRateLbl);
            this.settingsGb.Controls.Add(this.portNameLbl);
            this.settingsGb.Location = new System.Drawing.Point(12, 12);
            this.settingsGb.Name = "settingsGb";
            this.settingsGb.Size = new System.Drawing.Size(600, 96);
            this.settingsGb.TabIndex = 0;
            this.settingsGb.TabStop = false;
            this.settingsGb.Text = "Serial Port Settings";
            // 
            // stopBitsCb
            //
            this.stopBitsCb.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.serialSettingsBindingSource, "StopBits", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.stopBitsCb.FormattingEnabled = true;
            this.stopBitsCb.Location = new System.Drawing.Point(463, 22);
            this.stopBitsCb.Name = "stopBitsCb";
            this.stopBitsCb.Size = new System.Drawing.Size(121, 21);
            this.stopBitsCb.TabIndex = 10;
            // 
            // parityCb
            // 
            this.parityCb.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.serialSettingsBindingSource, "Parity", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.parityCb.FormattingEnabled = true;
            this.parityCb.Location = new System.Drawing.Point(269, 62);
            this.parityCb.Name = "parityCb";
            this.parityCb.Size = new System.Drawing.Size(121, 21);
            this.parityCb.TabIndex = 8;
            // 
            // dataBitsCb
            //
            this.dataBitsCb.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.serialSettingsBindingSource, "DataBits", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.dataBitsCb.FormattingEnabled = true;
            this.dataBitsCb.Location = new System.Drawing.Point(269, 22);
            this.dataBitsCb.Name = "dataBitsCb";
            this.dataBitsCb.Size = new System.Drawing.Size(121, 21);
            this.dataBitsCb.TabIndex = 6;
            // 
            // baudRateCb
            // 
            this.baudRateCb.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.serialSettingsBindingSource, "BaudRate", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.baudRateCb.FormattingEnabled = true;
            this.baudRateCb.Location = new System.Drawing.Point(74, 62);
            this.baudRateCb.Name = "baudRateCb";
            this.baudRateCb.Size = new System.Drawing.Size(121, 21);
            this.baudRateCb.TabIndex = 4;
            // 
            // portNameCb
            //
            this.portNameCb.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.serialSettingsBindingSource, "PortName", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.portNameCb.FormattingEnabled = true;
            this.portNameCb.Location = new System.Drawing.Point(74, 22);
            this.portNameCb.Name = "portNameCb";
            this.portNameCb.Size = new System.Drawing.Size(121, 21);
            this.portNameCb.TabIndex = 2;
            // 
            // listenBtn
            //
            this.listenBtn.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listenBtn.Location = new System.Drawing.Point(463, 49);
            this.listenBtn.Name = "listenBtn";
            this.listenBtn.Size = new System.Drawing.Size(121, 36);
            this.listenBtn.TabIndex = 11;
            this.listenBtn.Text = "Start Listening";
            this.listenBtn.UseVisualStyleBackColor = true;
            this.listenBtn.Click += new System.EventHandler(this.listenBtn_Click);
            // 
            // stopBitsLbl
            // 
            this.stopBitsLbl.AutoSize = true;
            this.stopBitsLbl.Location = new System.Drawing.Point(405, 25);
            this.stopBitsLbl.Name = "stopBitsLbl";
            this.stopBitsLbl.Size = new System.Drawing.Size(52, 13);
            this.stopBitsLbl.TabIndex = 9;
            this.stopBitsLbl.Text = "Stop Bits:";
            // 
            // parityLbl
            // 
            this.parityLbl.AutoSize = true;
            this.parityLbl.Location = new System.Drawing.Point(210, 65);
            this.parityLbl.Name = "parityLbl";
            this.parityLbl.Size = new System.Drawing.Size(36, 13);
            this.parityLbl.TabIndex = 7;
            this.parityLbl.Text = "Parity:";
            // 
            // dataBitsLbl
            // 
            this.dataBitsLbl.AutoSize = true;
            this.dataBitsLbl.Location = new System.Drawing.Point(210, 25);
            this.dataBitsLbl.Name = "dataBitsLbl";
            this.dataBitsLbl.Size = new System.Drawing.Size(53, 13);
            this.dataBitsLbl.TabIndex = 5;
            this.dataBitsLbl.Text = "Data Bits:";
            // 
            // baudRateLbl
            // 
            this.baudRateLbl.AutoSize = true;
            this.baudRateLbl.Location = new System.Drawing.Point(8, 65);
            this.baudRateLbl.Name = "baudRateLbl";
            this.baudRateLbl.Size = new System.Drawing.Size(61, 13);
            this.baudRateLbl.TabIndex = 3;
            this.baudRateLbl.Text = "Baud Rate:";
            // 
            // portNameLbl
            // 
            this.portNameLbl.AutoSize = true;
            this.portNameLbl.Location = new System.Drawing.Point(8, 25);
            this.portNameLbl.Name = "portNameLbl";
            this.portNameLbl.Size = new System.Drawing.Size(60, 13);
            this.portNameLbl.TabIndex = 1;
            this.portNameLbl.Text = "Port Name:";
            // 
            // resultTb
            // 
            this.resultTb.Location = new System.Drawing.Point(12, 123);
            this.resultTb.Multiline = true;
            this.resultTb.Name = "resultTb";
            this.resultTb.Size = new System.Drawing.Size(600, 186);
            this.resultTb.TabIndex = 12;
            // 
            // serialSettingsBindingSource
            // 
            this.serialSettingsBindingSource.DataSource = typeof(SerialPortListener.Serial.SerialSettings);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 321);
            this.Controls.Add(this.resultTb);
            this.Controls.Add(this.settingsGb);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "Serial Port Listener";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.settingsGb.ResumeLayout(false);
            this.settingsGb.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.serialSettingsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox settingsGb;
        private System.Windows.Forms.TextBox resultTb;
        private System.Windows.Forms.Button listenBtn;
        private System.Windows.Forms.Label stopBitsLbl;
        private System.Windows.Forms.Label parityLbl;
        private System.Windows.Forms.Label dataBitsLbl;
        private System.Windows.Forms.Label baudRateLbl;
        private System.Windows.Forms.Label portNameLbl;
        private System.Windows.Forms.ComboBox portNameCb;
        private System.Windows.Forms.ComboBox baudRateCb;
        private System.Windows.Forms.ComboBox parityCb;
        private System.Windows.Forms.ComboBox dataBitsCb;
        private System.Windows.Forms.ComboBox stopBitsCb;
        private System.Windows.Forms.BindingSource serialSettingsBindingSource;
    }
}

