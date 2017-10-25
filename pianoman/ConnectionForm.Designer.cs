namespace pianoman
{
    partial class ConnectionForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.disconnectPortButton = new MetroFramework.Controls.MetroButton();
            this.rescanPortsButton = new MetroFramework.Controls.MetroButton();
            this.serialPortSelectionBox = new MetroFramework.Controls.MetroComboBox();
            this.connectedDeviceLabel = new MetroFramework.Controls.MetroLabel();
            this.button1 = new MetroFramework.Controls.MetroButton();
            this.connectPortButton = new MetroFramework.Controls.MetroButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.connectPortButton);
            this.groupBox1.Controls.Add(this.connectedDeviceLabel);
            this.groupBox1.Controls.Add(this.serialPortSelectionBox);
            this.groupBox1.Controls.Add(this.rescanPortsButton);
            this.groupBox1.Controls.Add(this.disconnectPortButton);
            this.groupBox1.Location = new System.Drawing.Point(37, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(402, 100);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Connectie maken";
            // 
            // disconnectPortButton
            // 
            this.disconnectPortButton.Location = new System.Drawing.Point(133, 57);
            this.disconnectPortButton.Name = "disconnectPortButton";
            this.disconnectPortButton.Size = new System.Drawing.Size(175, 37);
            this.disconnectPortButton.TabIndex = 7;
            this.disconnectPortButton.Text = "Verbinding verbreken";
            this.disconnectPortButton.UseCustomBackColor = true;
            this.disconnectPortButton.UseSelectable = true;
            this.disconnectPortButton.Click += new System.EventHandler(this.disconnectPortButton_Click);
            // 
            // rescanPortsButton
            // 
            this.rescanPortsButton.Location = new System.Drawing.Point(134, 19);
            this.rescanPortsButton.Name = "rescanPortsButton";
            this.rescanPortsButton.Size = new System.Drawing.Size(84, 30);
            this.rescanPortsButton.TabIndex = 8;
            this.rescanPortsButton.Text = "Rescan";
            this.rescanPortsButton.UseCustomBackColor = true;
            this.rescanPortsButton.UseSelectable = true;
            this.rescanPortsButton.Click += new System.EventHandler(this.rescanPortsButton_Click);
            // 
            // serialPortSelectionBox
            // 
            this.serialPortSelectionBox.FormattingEnabled = true;
            this.serialPortSelectionBox.ItemHeight = 23;
            this.serialPortSelectionBox.Location = new System.Drawing.Point(7, 20);
            this.serialPortSelectionBox.Name = "serialPortSelectionBox";
            this.serialPortSelectionBox.Size = new System.Drawing.Size(121, 29);
            this.serialPortSelectionBox.TabIndex = 9;
            this.serialPortSelectionBox.UseSelectable = true;
            // 
            // connectedDeviceLabel
            // 
            this.connectedDeviceLabel.AutoSize = true;
            this.connectedDeviceLabel.Location = new System.Drawing.Point(314, 20);
            this.connectedDeviceLabel.Name = "connectedDeviceLabel";
            this.connectedDeviceLabel.Size = new System.Drawing.Size(0, 0);
            this.connectedDeviceLabel.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(446, 51);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 100);
            this.button1.TabIndex = 6;
            this.button1.Text = "Start Pianoman";
            this.button1.UseCustomBackColor = true;
            this.button1.UseSelectable = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // connectPortButton
            // 
            this.connectPortButton.Location = new System.Drawing.Point(224, 19);
            this.connectPortButton.Name = "connectPortButton";
            this.connectPortButton.Size = new System.Drawing.Size(84, 30);
            this.connectPortButton.TabIndex = 9;
            this.connectPortButton.Text = "Verbind";
            this.connectPortButton.UseCustomBackColor = true;
            this.connectPortButton.UseSelectable = true;
            this.connectPortButton.Click += new System.EventHandler(this.connectPortButton_Click);
            // 
            // ConnectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 186);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.DisplayHeader = false;
            this.Name = "ConnectionForm";
            this.Padding = new System.Windows.Forms.Padding(20, 30, 20, 20);
            this.Text = "Robot connection";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroLabel connectedDeviceLabel;
        private MetroFramework.Controls.MetroComboBox serialPortSelectionBox;
        private MetroFramework.Controls.MetroButton rescanPortsButton;
        private MetroFramework.Controls.MetroButton disconnectPortButton;
        private MetroFramework.Controls.MetroButton button1;
        private MetroFramework.Controls.MetroButton connectPortButton;
    }
}