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
            this.serialPortSelectionBox = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.rescanPortsButton = new System.Windows.Forms.Button();
            this.disconnectPortButton = new System.Windows.Forms.Button();
            this.connectPortButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.connectedDeviceLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // serialPortSelectionBox
            // 
            this.serialPortSelectionBox.FormattingEnabled = true;
            this.serialPortSelectionBox.Location = new System.Drawing.Point(6, 19);
            this.serialPortSelectionBox.Name = "serialPortSelectionBox";
            this.serialPortSelectionBox.Size = new System.Drawing.Size(121, 21);
            this.serialPortSelectionBox.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(370, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Start Pianoman";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // rescanPortsButton
            // 
            this.rescanPortsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rescanPortsButton.Location = new System.Drawing.Point(133, 19);
            this.rescanPortsButton.Name = "rescanPortsButton";
            this.rescanPortsButton.Size = new System.Drawing.Size(75, 23);
            this.rescanPortsButton.TabIndex = 2;
            this.rescanPortsButton.Text = "Rescan";
            this.rescanPortsButton.UseVisualStyleBackColor = true;
            this.rescanPortsButton.Click += new System.EventHandler(this.rescanPortsButton_Click);
            // 
            // disconnectPortButton
            // 
            this.disconnectPortButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.disconnectPortButton.Location = new System.Drawing.Point(224, 46);
            this.disconnectPortButton.Name = "disconnectPortButton";
            this.disconnectPortButton.Size = new System.Drawing.Size(75, 23);
            this.disconnectPortButton.TabIndex = 3;
            this.disconnectPortButton.Text = "Disconnect";
            this.disconnectPortButton.UseVisualStyleBackColor = true;
            this.disconnectPortButton.Click += new System.EventHandler(this.disconnectPortButton_Click);
            // 
            // connectPortButton
            // 
            this.connectPortButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.connectPortButton.Location = new System.Drawing.Point(224, 17);
            this.connectPortButton.Name = "connectPortButton";
            this.connectPortButton.Size = new System.Drawing.Size(75, 23);
            this.connectPortButton.TabIndex = 4;
            this.connectPortButton.Text = "Connect";
            this.connectPortButton.UseVisualStyleBackColor = true;
            this.connectPortButton.Click += new System.EventHandler(this.connectPortButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.connectedDeviceLabel);
            this.groupBox1.Controls.Add(this.serialPortSelectionBox);
            this.groupBox1.Controls.Add(this.disconnectPortButton);
            this.groupBox1.Controls.Add(this.connectPortButton);
            this.groupBox1.Controls.Add(this.rescanPortsButton);
            this.groupBox1.Location = new System.Drawing.Point(37, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(408, 100);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "port Connection";
            // 
            // connectedDeviceLabel
            // 
            this.connectedDeviceLabel.Location = new System.Drawing.Point(305, 22);
            this.connectedDeviceLabel.Name = "connectedDeviceLabel";
            this.connectedDeviceLabel.Size = new System.Drawing.Size(97, 42);
            this.connectedDeviceLabel.TabIndex = 5;
            this.connectedDeviceLabel.Text = "label1";
            // 
            // ConnectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(692, 343);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ConnectionForm";
            this.Text = "Robot connection";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox serialPortSelectionBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button rescanPortsButton;
        private System.Windows.Forms.Button disconnectPortButton;
        private System.Windows.Forms.Button connectPortButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label connectedDeviceLabel;
    }
}