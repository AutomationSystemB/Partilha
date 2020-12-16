namespace _192168 {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.labelInterface = new System.Windows.Forms.Label();
            this.buttonPing = new System.Windows.Forms.Button();
            this.buttonConf = new System.Windows.Forms.Button();
            this.textBoxIP = new System.Windows.Forms.TextBox();
            this.buttonDHCP = new System.Windows.Forms.Button();
            this.labelIP = new System.Windows.Forms.Label();
            this.labelMsg = new System.Windows.Forms.Label();
            this.comboBoxInterface = new System.Windows.Forms.ComboBox();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelInterface
            // 
            this.labelInterface.AutoSize = true;
            this.labelInterface.Location = new System.Drawing.Point(12, 9);
            this.labelInterface.Name = "labelInterface";
            this.labelInterface.Size = new System.Drawing.Size(63, 17);
            this.labelInterface.TabIndex = 19;
            this.labelInterface.Text = "Interface";
            // 
            // buttonPing
            // 
            this.buttonPing.AutoSize = true;
            this.buttonPing.Location = new System.Drawing.Point(210, 37);
            this.buttonPing.Name = "buttonPing";
            this.buttonPing.Size = new System.Drawing.Size(84, 27);
            this.buttonPing.TabIndex = 23;
            this.buttonPing.Text = "Ping";
            this.buttonPing.UseVisualStyleBackColor = true;
            this.buttonPing.Click += new System.EventHandler(this.buttonPing_Click);
            // 
            // buttonConf
            // 
            this.buttonConf.AutoSize = true;
            this.buttonConf.Location = new System.Drawing.Point(81, 67);
            this.buttonConf.Name = "buttonConf";
            this.buttonConf.Size = new System.Drawing.Size(84, 27);
            this.buttonConf.TabIndex = 25;
            this.buttonConf.Text = "Configurar";
            this.buttonConf.UseVisualStyleBackColor = true;
            this.buttonConf.Click += new System.EventHandler(this.buttonConf_Click);
            // 
            // textBoxIP
            // 
            this.textBoxIP.Location = new System.Drawing.Point(81, 39);
            this.textBoxIP.Name = "textBoxIP";
            this.textBoxIP.Size = new System.Drawing.Size(120, 22);
            this.textBoxIP.TabIndex = 22;
            this.textBoxIP.Text = "192.168.0.250";
            this.textBoxIP.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxIP_KeyUp);
            // 
            // buttonDHCP
            // 
            this.buttonDHCP.AutoSize = true;
            this.buttonDHCP.Location = new System.Drawing.Point(81, 100);
            this.buttonDHCP.Name = "buttonDHCP";
            this.buttonDHCP.Size = new System.Drawing.Size(84, 27);
            this.buttonDHCP.TabIndex = 24;
            this.buttonDHCP.Text = "DHCP";
            this.buttonDHCP.UseVisualStyleBackColor = true;
            this.buttonDHCP.Click += new System.EventHandler(this.buttonDHCP_Click);
            // 
            // labelIP
            // 
            this.labelIP.AutoSize = true;
            this.labelIP.Location = new System.Drawing.Point(55, 42);
            this.labelIP.Name = "labelIP";
            this.labelIP.Size = new System.Drawing.Size(20, 17);
            this.labelIP.TabIndex = 21;
            this.labelIP.Text = "IP";
            // 
            // labelMsg
            // 
            this.labelMsg.Location = new System.Drawing.Point(12, 141);
            this.labelMsg.Name = "labelMsg";
            this.labelMsg.Size = new System.Drawing.Size(278, 23);
            this.labelMsg.TabIndex = 26;
            this.labelMsg.Text = "Feito por André Correia";
            this.labelMsg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBoxInterface
            // 
            this.comboBoxInterface.FormattingEnabled = true;
            this.comboBoxInterface.Location = new System.Drawing.Point(81, 9);
            this.comboBoxInterface.Name = "comboBoxInterface";
            this.comboBoxInterface.Size = new System.Drawing.Size(180, 24);
            this.comboBoxInterface.TabIndex = 27;
            this.comboBoxInterface.SelectedIndexChanged += new System.EventHandler(this.comboBoxInterface_SelectedIndexChanged);
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.BackgroundImage = global::_192168.Properties.Resources.refresh;
            this.buttonRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonRefresh.Location = new System.Drawing.Point(267, 9);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(27, 27);
            this.buttonRefresh.TabIndex = 28;
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 173);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.comboBoxInterface);
            this.Controls.Add(this.labelMsg);
            this.Controls.Add(this.labelInterface);
            this.Controls.Add(this.buttonPing);
            this.Controls.Add(this.buttonConf);
            this.Controls.Add(this.textBoxIP);
            this.Controls.Add(this.buttonDHCP);
            this.Controls.Add(this.labelIP);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "192168";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelInterface;
        private System.Windows.Forms.Button buttonPing;
        private System.Windows.Forms.Button buttonConf;
        private System.Windows.Forms.TextBox textBoxIP;
        private System.Windows.Forms.Button buttonDHCP;
        private System.Windows.Forms.Label labelIP;
        private System.Windows.Forms.Label labelMsg;
        private System.Windows.Forms.ComboBox comboBoxInterface;
        private System.Windows.Forms.Button buttonRefresh;
    }
}

