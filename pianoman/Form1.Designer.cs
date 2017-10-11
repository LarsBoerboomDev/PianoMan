namespace pianoman
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.timeNummeric = new System.Windows.Forms.NumericUpDown();
            this.nootCombo = new System.Windows.Forms.ComboBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.addnoteButton = new System.Windows.Forms.Button();
            this.removenoteButton = new System.Windows.Forms.Button();
            this.savesongButton = new System.Windows.Forms.Button();
            this.loadsongButton = new System.Windows.Forms.Button();
            this.clearsongButton = new System.Windows.Forms.Button();
            this.playsongButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.songNameTextbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.playSongRobot = new System.Windows.Forms.Button();
            this.intervalButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.timeNummeric)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add note:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Rust";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Note:";
            // 
            // timeNummeric
            // 
            this.timeNummeric.DecimalPlaces = 1;
            this.timeNummeric.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.timeNummeric.Location = new System.Drawing.Point(52, 73);
            this.timeNummeric.Name = "timeNummeric";
            this.timeNummeric.Size = new System.Drawing.Size(51, 20);
            this.timeNummeric.TabIndex = 3;
            this.timeNummeric.Value = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            // 
            // nootCombo
            // 
            this.nootCombo.FormattingEnabled = true;
            this.nootCombo.Items.AddRange(new object[] {
            "C",
            "D",
            "E",
            "F",
            "G",
            "A",
            "B",
            "C2"});
            this.nootCombo.Location = new System.Drawing.Point(52, 46);
            this.nootCombo.Name = "nootCombo";
            this.nootCombo.Size = new System.Drawing.Size(121, 21);
            this.nootCombo.TabIndex = 4;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(325, 42);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(200, 290);
            this.listBox1.TabIndex = 11;
            this.listBox1.DoubleClick += new System.EventHandler(this.listBox1_DoubleClick);
            // 
            // addnoteButton
            // 
            this.addnoteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addnoteButton.Location = new System.Drawing.Point(16, 138);
            this.addnoteButton.Name = "addnoteButton";
            this.addnoteButton.Size = new System.Drawing.Size(156, 23);
            this.addnoteButton.TabIndex = 5;
            this.addnoteButton.Text = "Add note";
            this.addnoteButton.UseVisualStyleBackColor = true;
            this.addnoteButton.Click += new System.EventHandler(this.addnoteButton_Click);
            // 
            // removenoteButton
            // 
            this.removenoteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removenoteButton.Location = new System.Drawing.Point(16, 167);
            this.removenoteButton.Name = "removenoteButton";
            this.removenoteButton.Size = new System.Drawing.Size(156, 23);
            this.removenoteButton.TabIndex = 6;
            this.removenoteButton.Text = "Remove note";
            this.removenoteButton.UseVisualStyleBackColor = true;
            this.removenoteButton.Click += new System.EventHandler(this.removenoteButton_Click);
            // 
            // savesongButton
            // 
            this.savesongButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.savesongButton.Location = new System.Drawing.Point(16, 196);
            this.savesongButton.Name = "savesongButton";
            this.savesongButton.Size = new System.Drawing.Size(156, 23);
            this.savesongButton.TabIndex = 7;
            this.savesongButton.Text = "Save song";
            this.savesongButton.UseVisualStyleBackColor = true;
            this.savesongButton.Click += new System.EventHandler(this.savesongButton_Click);
            // 
            // loadsongButton
            // 
            this.loadsongButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loadsongButton.Location = new System.Drawing.Point(16, 225);
            this.loadsongButton.Name = "loadsongButton";
            this.loadsongButton.Size = new System.Drawing.Size(156, 23);
            this.loadsongButton.TabIndex = 8;
            this.loadsongButton.Text = "Load song";
            this.loadsongButton.UseVisualStyleBackColor = true;
            this.loadsongButton.Click += new System.EventHandler(this.loadsongButton_Click);
            // 
            // clearsongButton
            // 
            this.clearsongButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearsongButton.Location = new System.Drawing.Point(16, 254);
            this.clearsongButton.Name = "clearsongButton";
            this.clearsongButton.Size = new System.Drawing.Size(156, 23);
            this.clearsongButton.TabIndex = 9;
            this.clearsongButton.Text = "Clear song";
            this.clearsongButton.UseVisualStyleBackColor = true;
            this.clearsongButton.Click += new System.EventHandler(this.clearsongButton_Click);
            // 
            // playsongButton
            // 
            this.playsongButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.playsongButton.Location = new System.Drawing.Point(16, 283);
            this.playsongButton.Name = "playsongButton";
            this.playsongButton.Size = new System.Drawing.Size(156, 23);
            this.playsongButton.TabIndex = 10;
            this.playsongButton.Text = "Play song preview";
            this.playsongButton.UseVisualStyleBackColor = true;
            this.playsongButton.Click += new System.EventHandler(this.playsongButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(322, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Song:";
            // 
            // songNameTextbox
            // 
            this.songNameTextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.songNameTextbox.Location = new System.Drawing.Point(16, 112);
            this.songNameTextbox.Name = "songNameTextbox";
            this.songNameTextbox.Size = new System.Drawing.Size(156, 20);
            this.songNameTextbox.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Naam liedje";
            // 
            // playSongRobot
            // 
            this.playSongRobot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.playSongRobot.Location = new System.Drawing.Point(16, 312);
            this.playSongRobot.Name = "playSongRobot";
            this.playSongRobot.Size = new System.Drawing.Size(156, 23);
            this.playSongRobot.TabIndex = 15;
            this.playSongRobot.Text = "Play song";
            this.playSongRobot.UseVisualStyleBackColor = true;
            this.playSongRobot.Click += new System.EventHandler(this.playSongRobot_Click);
            // 
            // intervalButton
            // 
            this.intervalButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.intervalButton.Location = new System.Drawing.Point(109, 73);
            this.intervalButton.Name = "intervalButton";
            this.intervalButton.Size = new System.Drawing.Size(64, 23);
            this.intervalButton.TabIndex = 16;
            this.intervalButton.Text = "Add rust";
            this.intervalButton.UseVisualStyleBackColor = true;
            this.intervalButton.Click += new System.EventHandler(this.intervalButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(235, 283);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(629, 399);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.intervalButton);
            this.Controls.Add(this.playSongRobot);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.songNameTextbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.playsongButton);
            this.Controls.Add(this.clearsongButton);
            this.Controls.Add(this.loadsongButton);
            this.Controls.Add(this.savesongButton);
            this.Controls.Add(this.removenoteButton);
            this.Controls.Add(this.addnoteButton);
            this.Controls.Add(this.nootCombo);
            this.Controls.Add(this.timeNummeric);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Pianoman";
            ((System.ComponentModel.ISupportInitialize)(this.timeNummeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown timeNummeric;
        private System.Windows.Forms.ComboBox nootCombo;
        private System.Windows.Forms.Button addnoteButton;
        private System.Windows.Forms.Button removenoteButton;
        private System.Windows.Forms.Button savesongButton;
        private System.Windows.Forms.Button loadsongButton;
        private System.Windows.Forms.Button clearsongButton;
        private System.Windows.Forms.Button playsongButton;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox songNameTextbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button playSongRobot;
        private System.Windows.Forms.Button intervalButton;
        private System.Windows.Forms.Button button1;
    }
}

