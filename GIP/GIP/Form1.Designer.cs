namespace GIP
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
            this.btnExport = new System.Windows.Forms.Button();
            this.tbTekst = new System.Windows.Forms.TextBox();
            this.pbBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbBox)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(158, 102);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(305, 67);
            this.btnExport.TabIndex = 0;
            this.btnExport.Text = "Export QRCODE";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // tbTekst
            // 
            this.tbTekst.Location = new System.Drawing.Point(158, 44);
            this.tbTekst.Name = "tbTekst";
            this.tbTekst.Size = new System.Drawing.Size(305, 22);
            this.tbTekst.TabIndex = 1;
            // 
            // pbBox
            // 
            this.pbBox.Location = new System.Drawing.Point(483, 12);
            this.pbBox.Name = "pbBox";
            this.pbBox.Size = new System.Drawing.Size(500, 500);
            this.pbBox.TabIndex = 2;
            this.pbBox.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 536);
            this.Controls.Add(this.pbBox);
            this.Controls.Add(this.tbTekst);
            this.Controls.Add(this.btnExport);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.TextBox tbTekst;
        private System.Windows.Forms.PictureBox pbBox;
    }
}

