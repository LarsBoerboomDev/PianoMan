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
            ((System.ComponentModel.ISupportInitialize)(this.timeNummeric)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(97, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Voeg noot toe:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Rust";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(40, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Noot:";
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
            this.timeNummeric.Location = new System.Drawing.Point(93, 100);
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
            // nootCombo
            // 
            this.nootCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.nootCombo.Location = new System.Drawing.Point(94, 49);
            this.nootCombo.Name = "nootCombo";
            this.nootCombo.Size = new System.Drawing.Size(69, 32);
            this.nootCombo.TabIndex = 4;
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 24;
            this.listBox1.Location = new System.Drawing.Point(400, 52);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(235, 532);
            this.listBox1.TabIndex = 11;
            this.listBox1.DoubleClick += new System.EventHandler(this.listBox1_DoubleClick);
            // 
            // addnoteButton
            // 
            this.addnoteButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.addnoteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addnoteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addnoteButton.ForeColor = System.Drawing.Color.White;
            this.addnoteButton.Location = new System.Drawing.Point(169, 47);
            this.addnoteButton.Name = "addnoteButton";
            this.addnoteButton.Size = new System.Drawing.Size(156, 40);
            this.addnoteButton.TabIndex = 5;
            this.addnoteButton.Text = "Voeg noot toe";
            this.addnoteButton.UseVisualStyleBackColor = false;
            this.addnoteButton.Click += new System.EventHandler(this.addnoteButton_Click);
            // 
            // removenoteButton
            // 
            this.removenoteButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.removenoteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removenoteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removenoteButton.ForeColor = System.Drawing.Color.White;
            this.removenoteButton.Location = new System.Drawing.Point(94, 181);
            this.removenoteButton.Name = "removenoteButton";
            this.removenoteButton.Size = new System.Drawing.Size(200, 61);
            this.removenoteButton.TabIndex = 6;
            this.removenoteButton.Text = "Verwijder noot";
            this.removenoteButton.UseVisualStyleBackColor = false;
            this.removenoteButton.Click += new System.EventHandler(this.removenoteButton_Click);
            // 
            // savesongButton
            // 
            this.savesongButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.savesongButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.savesongButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savesongButton.ForeColor = System.Drawing.Color.White;
            this.savesongButton.Location = new System.Drawing.Point(94, 248);
            this.savesongButton.Name = "savesongButton";
            this.savesongButton.Size = new System.Drawing.Size(199, 61);
            this.savesongButton.TabIndex = 7;
            this.savesongButton.Text = "Opslaan liedje";
            this.savesongButton.UseVisualStyleBackColor = false;
            this.savesongButton.Click += new System.EventHandler(this.savesongButton_Click);
            // 
            // loadsongButton
            // 
            this.loadsongButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.loadsongButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loadsongButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadsongButton.ForeColor = System.Drawing.Color.White;
            this.loadsongButton.Location = new System.Drawing.Point(94, 315);
            this.loadsongButton.Name = "loadsongButton";
            this.loadsongButton.Size = new System.Drawing.Size(199, 61);
            this.loadsongButton.TabIndex = 8;
            this.loadsongButton.Text = "Liedje laden";
            this.loadsongButton.UseVisualStyleBackColor = false;
            this.loadsongButton.Click += new System.EventHandler(this.loadsongButton_Click);
            // 
            // clearsongButton
            // 
            this.clearsongButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.clearsongButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearsongButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearsongButton.ForeColor = System.Drawing.Color.White;
            this.clearsongButton.Location = new System.Drawing.Point(94, 382);
            this.clearsongButton.Name = "clearsongButton";
            this.clearsongButton.Size = new System.Drawing.Size(199, 61);
            this.clearsongButton.TabIndex = 9;
            this.clearsongButton.Text = "Verwijder song";
            this.clearsongButton.UseVisualStyleBackColor = false;
            this.clearsongButton.Click += new System.EventHandler(this.clearsongButton_Click);
            // 
            // playsongButton
            // 
            this.playsongButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.playsongButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.playsongButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playsongButton.ForeColor = System.Drawing.Color.White;
            this.playsongButton.Location = new System.Drawing.Point(95, 449);
            this.playsongButton.Name = "playsongButton";
            this.playsongButton.Size = new System.Drawing.Size(198, 61);
            this.playsongButton.TabIndex = 10;
            this.playsongButton.Text = "Speel voorbeeld af";
            this.playsongButton.UseVisualStyleBackColor = false;
            this.playsongButton.Click += new System.EventHandler(this.playsongButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(396, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 24);
            this.label4.TabIndex = 12;
            this.label4.Text = "Liedje";
            // 
            // songNameTextbox
            // 
            this.songNameTextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.songNameTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.songNameTextbox.Location = new System.Drawing.Point(169, 146);
            this.songNameTextbox.Name = "songNameTextbox";
            this.songNameTextbox.Size = new System.Drawing.Size(156, 29);
            this.songNameTextbox.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(40, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 24);
            this.label5.TabIndex = 14;
            this.label5.Text = "Naam liedje:";
            // 
            // playSongRobot
            // 
            this.playSongRobot.BackColor = System.Drawing.SystemColors.Highlight;
            this.playSongRobot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.playSongRobot.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playSongRobot.ForeColor = System.Drawing.Color.White;
            this.playSongRobot.Location = new System.Drawing.Point(95, 516);
            this.playSongRobot.Name = "playSongRobot";
            this.playSongRobot.Size = new System.Drawing.Size(198, 61);
            this.playSongRobot.TabIndex = 15;
            this.playSongRobot.Text = "Speel liedje";
            this.playSongRobot.UseVisualStyleBackColor = false;
            this.playSongRobot.Click += new System.EventHandler(this.playSongRobot_Click);
            // 
            // intervalButton
            // 
            this.intervalButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.intervalButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.intervalButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.intervalButton.ForeColor = System.Drawing.Color.White;
            this.intervalButton.Location = new System.Drawing.Point(169, 93);
            this.intervalButton.Name = "intervalButton";
            this.intervalButton.Size = new System.Drawing.Size(156, 40);
            this.intervalButton.TabIndex = 16;
            this.intervalButton.Text = "Voeg rust toe";
            this.intervalButton.UseVisualStyleBackColor = false;
            this.intervalButton.Click += new System.EventHandler(this.intervalButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(851, 607);
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
    }
}

