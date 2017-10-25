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
            this.nootCombo = new System.Windows.Forms.ComboBox();
            this.timeNummeric = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.replaceButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.timeNummeric)).BeginInit();
            this.SuspendLayout();
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
            "C2",
            "RUST"});
            this.nootCombo.Location = new System.Drawing.Point(73, 69);
            this.nootCombo.Name = "nootCombo";
            this.nootCombo.Size = new System.Drawing.Size(121, 32);
            this.nootCombo.TabIndex = 8;
            this.nootCombo.TextChanged += new System.EventHandler(this.nootCombo_TextChanged);
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
            this.timeNummeric.Location = new System.Drawing.Point(73, 12);
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
            this.label3.Location = new System.Drawing.Point(12, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "Note:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Time:";
            // 
            // replaceButton
            // 
            this.replaceButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.replaceButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.replaceButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.replaceButton.ForeColor = System.Drawing.Color.White;
            this.replaceButton.Location = new System.Drawing.Point(14, 110);
            this.replaceButton.Name = "replaceButton";
            this.replaceButton.Size = new System.Drawing.Size(179, 57);
            this.replaceButton.TabIndex = 9;
            this.replaceButton.Text = "Vervang";
            this.replaceButton.UseVisualStyleBackColor = false;
            this.replaceButton.Click += new System.EventHandler(this.replaceButton_Click);
            // 
            // replaceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(294, 206);
            this.Controls.Add(this.replaceButton);
            this.Controls.Add(this.nootCombo);
            this.Controls.Add(this.timeNummeric);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "replaceForm";
            this.Text = "replaceForm";
            ((System.ComponentModel.ISupportInitialize)(this.timeNummeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox nootCombo;
        private System.Windows.Forms.NumericUpDown timeNummeric;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button replaceButton;
    }
}