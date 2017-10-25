namespace pianoman
{
    partial class replaceForm
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
            this.timeNummeric = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.replaceButton = new MetroFramework.Controls.MetroButton();
            this.nootCombo = new MetroFramework.Controls.MetroComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.timeNummeric)).BeginInit();
            this.SuspendLayout();
            // 
            // timeNummeric
            // 
            this.timeNummeric.DecimalPlaces = 1;
            this.timeNummeric.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeNummeric.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.timeNummeric.Location = new System.Drawing.Point(72, 35);
            this.timeNummeric.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.timeNummeric.Name = "timeNummeric";
            this.timeNummeric.Size = new System.Drawing.Size(120, 29);
            this.timeNummeric.TabIndex = 7;
            this.timeNummeric.Value = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "Note:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Time:";
            // 
            // replaceButton
            // 
            this.replaceButton.Location = new System.Drawing.Point(13, 110);
            this.replaceButton.Name = "replaceButton";
            this.replaceButton.Size = new System.Drawing.Size(179, 59);
            this.replaceButton.TabIndex = 9;
            this.replaceButton.Text = "Vervang";
            this.replaceButton.UseCustomBackColor = true;
            this.replaceButton.UseSelectable = true;
            this.replaceButton.Click += new System.EventHandler(this.replaceButton_Click);
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
            "C2",
            "RUST"});
            this.nootCombo.Location = new System.Drawing.Point(72, 73);
            this.nootCombo.Name = "nootCombo";
            this.nootCombo.Size = new System.Drawing.Size(120, 29);
            this.nootCombo.TabIndex = 10;
            this.nootCombo.UseSelectable = true;
            // 
            // replaceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(212, 178);
            this.Controls.Add(this.nootCombo);
            this.Controls.Add(this.replaceButton);
            this.Controls.Add(this.timeNummeric);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.DisplayHeader = false;
            this.MaximizeBox = false;
            this.Name = "replaceForm";
            this.Padding = new System.Windows.Forms.Padding(20, 30, 20, 20);
            this.Text = "replaceForm";
            ((System.ComponentModel.ISupportInitialize)(this.timeNummeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.NumericUpDown timeNummeric;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private MetroFramework.Controls.MetroButton replaceButton;
        private MetroFramework.Controls.MetroComboBox nootCombo;
    }
}