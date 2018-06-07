namespace GIP
{
    partial class BetalingInfo
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BetalingInfo));
            this.lblWelkom = new System.Windows.Forms.Label();
            this.dgvProducten = new System.Windows.Forms.DataGridView();
            this.Product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Aantal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prijs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTPrijs = new System.Windows.Forms.Label();
            this.pbQR = new System.Windows.Forms.PictureBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.timerBetaling = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducten)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbQR)).BeginInit();
            this.SuspendLayout();
            // 
            // lblWelkom
            // 
            this.lblWelkom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblWelkom.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelkom.Location = new System.Drawing.Point(549, 481);
            this.lblWelkom.Name = "lblWelkom";
            this.lblWelkom.Size = new System.Drawing.Size(316, 97);
            this.lblWelkom.TabIndex = 0;
            this.lblWelkom.Text = "Welkom!";
            this.lblWelkom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvProducten
            // 
            this.dgvProducten.AllowUserToAddRows = false;
            this.dgvProducten.AllowUserToDeleteRows = false;
            this.dgvProducten.AllowUserToResizeColumns = false;
            this.dgvProducten.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvProducten.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProducten.BackgroundColor = System.Drawing.Color.White;
            this.dgvProducten.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvProducten.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvProducten.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducten.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Product,
            this.Aantal,
            this.Prijs});
            this.dgvProducten.Enabled = false;
            this.dgvProducten.EnableHeadersVisualStyles = false;
            this.dgvProducten.GridColor = System.Drawing.SystemColors.Window;
            this.dgvProducten.Location = new System.Drawing.Point(33, 70);
            this.dgvProducten.MultiSelect = false;
            this.dgvProducten.Name = "dgvProducten";
            this.dgvProducten.RowHeadersVisible = false;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvProducten.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvProducten.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvProducten.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProducten.RowTemplate.DividerHeight = 2;
            this.dgvProducten.RowTemplate.Height = 50;
            this.dgvProducten.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgvProducten.Size = new System.Drawing.Size(518, 733);
            this.dgvProducten.TabIndex = 1;
            this.dgvProducten.Visible = false;
            // 
            // Product
            // 
            this.Product.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Product.DefaultCellStyle = dataGridViewCellStyle2;
            this.Product.DividerWidth = 1;
            this.Product.HeaderText = "Product";
            this.Product.MinimumWidth = 300;
            this.Product.Name = "Product";
            this.Product.ReadOnly = true;
            // 
            // Aantal
            // 
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Aantal.DefaultCellStyle = dataGridViewCellStyle3;
            this.Aantal.DividerWidth = 1;
            this.Aantal.HeaderText = "Aantal";
            this.Aantal.Name = "Aantal";
            this.Aantal.ReadOnly = true;
            // 
            // Prijs
            // 
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.Format = "C2";
            dataGridViewCellStyle4.NullValue = "0";
            this.Prijs.DefaultCellStyle = dataGridViewCellStyle4;
            this.Prijs.HeaderText = "Prijs";
            this.Prijs.Name = "Prijs";
            this.Prijs.ReadOnly = true;
            // 
            // lblTPrijs
            // 
            this.lblTPrijs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTPrijs.AutoSize = true;
            this.lblTPrijs.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTPrijs.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.lblTPrijs.Location = new System.Drawing.Point(25, 940);
            this.lblTPrijs.Name = "lblTPrijs";
            this.lblTPrijs.Size = new System.Drawing.Size(280, 45);
            this.lblTPrijs.TabIndex = 7;
            this.lblTPrijs.Text = "Totaal prijs: 0 euro";
            this.lblTPrijs.Visible = false;
            // 
            // pbQR
            // 
            this.pbQR.BackColor = System.Drawing.Color.Transparent;
            this.pbQR.Location = new System.Drawing.Point(567, 70);
            this.pbQR.Name = "pbQR";
            this.pbQR.Size = new System.Drawing.Size(703, 703);
            this.pbQR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbQR.TabIndex = 8;
            this.pbQR.TabStop = false;
            this.pbQR.Visible = false;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.lblStatus.Location = new System.Drawing.Point(653, 776);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(568, 65);
            this.lblStatus.TabIndex = 9;
            this.lblStatus.Text = "Wachten op bevestiging...";
            this.lblStatus.Visible = false;
            // 
            // timerBetaling
            // 
            this.timerBetaling.Interval = 2000;
            this.timerBetaling.Tick += new System.EventHandler(this.timerBetaling_tick);
            // 
            // BetalingInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1557, 1017);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.pbQR);
            this.Controls.Add(this.lblTPrijs);
            this.Controls.Add(this.dgvProducten);
            this.Controls.Add(this.lblWelkom);
            this.DisplayHeader = false;
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "BetalingInfo";
            this.Padding = new System.Windows.Forms.Padding(30, 67, 30, 32);
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "BetalingInfo";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducten)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbQR)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelkom;
        private System.Windows.Forms.DataGridView dgvProducten;
        private System.Windows.Forms.Label lblTPrijs;
        private System.Windows.Forms.PictureBox pbQR;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Timer timerBetaling;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product;
        private System.Windows.Forms.DataGridViewTextBoxColumn Aantal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prijs;
    }
}