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
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.nootCombo = new MetroFramework.Controls.MetroComboBox();
            this.addnoteButton = new MetroFramework.Controls.MetroButton();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.timeNummeric = new System.Windows.Forms.NumericUpDown();
            this.intervalButton = new MetroFramework.Controls.MetroButton();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.songNameTextbox = new MetroFramework.Controls.MetroTextBox();
            this.removenoteButton = new MetroFramework.Controls.MetroButton();
            this.savesongButton = new MetroFramework.Controls.MetroButton();
            this.loadsongButton = new MetroFramework.Controls.MetroButton();
            this.clearsongButton = new MetroFramework.Controls.MetroButton();
            this.playsongButton = new MetroFramework.Controls.MetroButton();
            this.playSongRobot = new MetroFramework.Controls.MetroButton();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.listBox1 = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.timeNummeric)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(28, 55);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(96, 19);
            this.metroLabel1.TabIndex = 17;
            this.metroLabel1.Text = "Voeg noot toe:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(30, 85);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(42, 19);
            this.metroLabel2.TabIndex = 18;
            this.metroLabel2.Text = "Noot:";
            // 
            // nootCombo
            // 
            this.nootCombo.FormattingEnabled = true;
            this.nootCombo.ItemHeight = 23;
            this.nootCombo.Items.AddRange(new object[] {
            "C",
            "D",
            "E",
            "F",
            "G",
            "A",
            "B",
            "C2"});
            this.nootCombo.Location = new System.Drawing.Point(72, 81);
            this.nootCombo.Name = "nootCombo";
            this.nootCombo.Size = new System.Drawing.Size(70, 29);
            this.nootCombo.TabIndex = 19;
            this.nootCombo.UseSelectable = true;
            // 
            // addnoteButton
            // 
            this.addnoteButton.BackColor = System.Drawing.Color.White;
            this.addnoteButton.Location = new System.Drawing.Point(153, 81);
            this.addnoteButton.Name = "addnoteButton";
            this.addnoteButton.Size = new System.Drawing.Size(101, 29);
            this.addnoteButton.TabIndex = 20;
            this.addnoteButton.Text = "Voeg noot toe";
            this.addnoteButton.UseCustomBackColor = true;
            this.addnoteButton.UseSelectable = true;
            this.addnoteButton.Click += new System.EventHandler(this.addnoteButton_Click);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(30, 118);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(36, 19);
            this.metroLabel3.TabIndex = 21;
            this.metroLabel3.Text = "Rust:";
            // 
            // timeNummeric
            // 
            this.timeNummeric.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.timeNummeric.DecimalPlaces = 2;
            this.timeNummeric.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeNummeric.ForeColor = System.Drawing.SystemColors.WindowText;
            this.timeNummeric.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.timeNummeric.Location = new System.Drawing.Point(72, 116);
            this.timeNummeric.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.timeNummeric.Name = "timeNummeric";
            this.timeNummeric.Size = new System.Drawing.Size(70, 29);
            this.timeNummeric.TabIndex = 3;
            this.timeNummeric.Value = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            // 
            // intervalButton
            // 
            this.intervalButton.Location = new System.Drawing.Point(153, 116);
            this.intervalButton.Name = "intervalButton";
            this.intervalButton.Size = new System.Drawing.Size(101, 29);
            this.intervalButton.TabIndex = 22;
            this.intervalButton.Text = "Voeg rust toe";
            this.intervalButton.UseCustomBackColor = true;
            this.intervalButton.UseSelectable = true;
            this.intervalButton.Click += new System.EventHandler(this.intervalButton_Click);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(30, 161);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(83, 19);
            this.metroLabel4.TabIndex = 23;
            this.metroLabel4.Text = "Naam liedje:";
            // 
            // songNameTextbox
            // 
            // 
            // 
            // 
            this.songNameTextbox.CustomButton.Image = null;
            this.songNameTextbox.CustomButton.Location = new System.Drawing.Point(113, 1);
            this.songNameTextbox.CustomButton.Name = "";
            this.songNameTextbox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.songNameTextbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.songNameTextbox.CustomButton.TabIndex = 1;
            this.songNameTextbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.songNameTextbox.CustomButton.UseSelectable = true;
            this.songNameTextbox.CustomButton.Visible = false;
            this.songNameTextbox.Lines = new string[0];
            this.songNameTextbox.Location = new System.Drawing.Point(119, 161);
            this.songNameTextbox.MaxLength = 32767;
            this.songNameTextbox.Name = "songNameTextbox";
            this.songNameTextbox.PasswordChar = '\0';
            this.songNameTextbox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.songNameTextbox.SelectedText = "";
            this.songNameTextbox.SelectionLength = 0;
            this.songNameTextbox.SelectionStart = 0;
            this.songNameTextbox.ShortcutsEnabled = true;
            this.songNameTextbox.Size = new System.Drawing.Size(135, 23);
            this.songNameTextbox.TabIndex = 24;
            this.songNameTextbox.UseSelectable = true;
            this.songNameTextbox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.songNameTextbox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // removenoteButton
            // 
            this.removenoteButton.Location = new System.Drawing.Point(23, 204);
            this.removenoteButton.Name = "removenoteButton";
            this.removenoteButton.Size = new System.Drawing.Size(231, 47);
            this.removenoteButton.TabIndex = 25;
            this.removenoteButton.Text = "Verwijder noot";
            this.removenoteButton.UseCustomBackColor = true;
            this.removenoteButton.UseSelectable = true;
            this.removenoteButton.Click += new System.EventHandler(this.removenoteButton_Click);
            // 
            // savesongButton
            // 
            this.savesongButton.Location = new System.Drawing.Point(22, 257);
            this.savesongButton.Name = "savesongButton";
            this.savesongButton.Size = new System.Drawing.Size(232, 47);
            this.savesongButton.TabIndex = 26;
            this.savesongButton.Text = "Lied opslaan";
            this.savesongButton.UseCustomBackColor = true;
            this.savesongButton.UseSelectable = true;
            this.savesongButton.Click += new System.EventHandler(this.savesongButton_Click);
            // 
            // loadsongButton
            // 
            this.loadsongButton.Location = new System.Drawing.Point(22, 310);
            this.loadsongButton.Name = "loadsongButton";
            this.loadsongButton.Size = new System.Drawing.Size(232, 47);
            this.loadsongButton.TabIndex = 27;
            this.loadsongButton.Text = "Laad liedje";
            this.loadsongButton.UseCustomBackColor = true;
            this.loadsongButton.UseSelectable = true;
            this.loadsongButton.Click += new System.EventHandler(this.loadsongButton_Click);
            // 
            // clearsongButton
            // 
            this.clearsongButton.Location = new System.Drawing.Point(22, 363);
            this.clearsongButton.Name = "clearsongButton";
            this.clearsongButton.Size = new System.Drawing.Size(232, 47);
            this.clearsongButton.TabIndex = 28;
            this.clearsongButton.Text = "Verwijder alle noten";
            this.clearsongButton.UseCustomBackColor = true;
            this.clearsongButton.UseSelectable = true;
            this.clearsongButton.Click += new System.EventHandler(this.clearsongButton_Click);
            // 
            // playsongButton
            // 
            this.playsongButton.Location = new System.Drawing.Point(22, 416);
            this.playsongButton.Name = "playsongButton";
            this.playsongButton.Size = new System.Drawing.Size(232, 47);
            this.playsongButton.TabIndex = 29;
            this.playsongButton.Text = "Speel voorbeeld";
            this.playsongButton.UseCustomBackColor = true;
            this.playsongButton.UseSelectable = true;
            this.playsongButton.Click += new System.EventHandler(this.playsongButton_Click);
            // 
            // playSongRobot
            // 
            this.playSongRobot.Location = new System.Drawing.Point(22, 469);
            this.playSongRobot.Name = "playSongRobot";
            this.playSongRobot.Size = new System.Drawing.Size(232, 47);
            this.playSongRobot.TabIndex = 30;
            this.playSongRobot.Text = "Stuur naar robot";
            this.playSongRobot.UseCustomBackColor = true;
            this.playSongRobot.UseSelectable = true;
            this.playSongRobot.Click += new System.EventHandler(this.playSongRobot_Click);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(357, 55);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(46, 19);
            this.metroLabel5.TabIndex = 31;
            this.metroLabel5.Text = "Liedje:";
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 24;
            this.listBox1.Location = new System.Drawing.Point(357, 85);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(235, 436);
            this.listBox1.TabIndex = 11;
            this.listBox1.DoubleClick += new System.EventHandler(this.listBox1_DoubleClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 538);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.playSongRobot);
            this.Controls.Add(this.playsongButton);
            this.Controls.Add(this.clearsongButton);
            this.Controls.Add(this.loadsongButton);
            this.Controls.Add(this.savesongButton);
            this.Controls.Add(this.removenoteButton);
            this.Controls.Add(this.songNameTextbox);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.intervalButton);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.addnoteButton);
            this.Controls.Add(this.nootCombo);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.timeNummeric);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Resizable = false;
            this.Text = "Pianoman";
            ((System.ComponentModel.ISupportInitialize)(this.timeNummeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroComboBox nootCombo;
        private MetroFramework.Controls.MetroButton addnoteButton;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private System.Windows.Forms.NumericUpDown timeNummeric;
        private MetroFramework.Controls.MetroButton intervalButton;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox songNameTextbox;
        private MetroFramework.Controls.MetroButton removenoteButton;
        private MetroFramework.Controls.MetroButton savesongButton;
        private MetroFramework.Controls.MetroButton loadsongButton;
        private MetroFramework.Controls.MetroButton clearsongButton;
        private MetroFramework.Controls.MetroButton playsongButton;
        private MetroFramework.Controls.MetroButton playSongRobot;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private System.Windows.Forms.ListBox listBox1;
    }
}

