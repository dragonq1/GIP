namespace GIP
{
    partial class Menu
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
            this.lblMenu = new System.Windows.Forms.Label();
            this.btnKassa = new System.Windows.Forms.Button();
            this.btnPM = new System.Windows.Forms.Button();
            this.btnUitloggen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMenu
            // 
            this.lblMenu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMenu.AutoSize = true;
            this.lblMenu.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenu.Location = new System.Drawing.Point(569, 19);
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.Size = new System.Drawing.Size(251, 46);
            this.lblMenu.TabIndex = 1;
            this.lblMenu.Text = "Maak uw keuze";
            this.lblMenu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnKassa
            // 
            this.btnKassa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnKassa.BackColor = System.Drawing.Color.Transparent;
            this.btnKassa.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKassa.Location = new System.Drawing.Point(524, 202);
            this.btnKassa.Name = "btnKassa";
            this.btnKassa.Size = new System.Drawing.Size(340, 60);
            this.btnKassa.TabIndex = 2;
            this.btnKassa.Text = "Kassa";
            this.btnKassa.UseVisualStyleBackColor = false;
            // 
            // btnPM
            // 
            this.btnPM.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPM.BackColor = System.Drawing.Color.Transparent;
            this.btnPM.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPM.Location = new System.Drawing.Point(524, 282);
            this.btnPM.Name = "btnPM";
            this.btnPM.Size = new System.Drawing.Size(340, 60);
            this.btnPM.TabIndex = 3;
            this.btnPM.Text = "Product manager";
            this.btnPM.UseVisualStyleBackColor = false;
            // 
            // btnUitloggen
            // 
            this.btnUitloggen.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnUitloggen.BackColor = System.Drawing.Color.Transparent;
            this.btnUitloggen.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUitloggen.Location = new System.Drawing.Point(524, 367);
            this.btnUitloggen.Name = "btnUitloggen";
            this.btnUitloggen.Size = new System.Drawing.Size(340, 60);
            this.btnUitloggen.TabIndex = 4;
            this.btnUitloggen.Text = "Uitloggen";
            this.btnUitloggen.UseVisualStyleBackColor = false;
            this.btnUitloggen.Click += new System.EventHandler(this.btnUitloggen_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1388, 676);
            this.Controls.Add(this.btnUitloggen);
            this.Controls.Add(this.btnPM);
            this.Controls.Add(this.btnKassa);
            this.Controls.Add(this.lblMenu);
            this.DisplayHeader = false;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Menu";
            this.Padding = new System.Windows.Forms.Padding(15, 19, 15, 16);
            this.Text = "Menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMenu;
        private System.Windows.Forms.Button btnKassa;
        private System.Windows.Forms.Button btnPM;
        private System.Windows.Forms.Button btnUitloggen;
    }
}