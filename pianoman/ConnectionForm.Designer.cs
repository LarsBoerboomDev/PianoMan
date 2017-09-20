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
            this.SuspendLayout();
            // 
            // serialPortSelectionBox
            // 
            this.serialPortSelectionBox.FormattingEnabled = true;
            this.serialPortSelectionBox.Location = new System.Drawing.Point(12, 12);
            this.serialPortSelectionBox.Name = "serialPortSelectionBox";
            this.serialPortSelectionBox.Size = new System.Drawing.Size(121, 21);
            this.serialPortSelectionBox.TabIndex = 0;
            // 
            // ConnectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.serialPortSelectionBox);
            this.Name = "ConnectionForm";
            this.Text = "ConnectionForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox serialPortSelectionBox;
    }
}