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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblWelkom = new System.Windows.Forms.Label();
            this.dgvProducten = new System.Windows.Forms.DataGridView();
            this.Product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Aantal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prijs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTPrijs = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducten)).BeginInit();
            this.SuspendLayout();
            // 
            // lblWelkom
            // 
            this.lblWelkom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblWelkom.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelkom.Location = new System.Drawing.Point(472, 451);
            this.lblWelkom.Name = "lblWelkom";
            this.lblWelkom.Size = new System.Drawing.Size(314, 97);
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
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvProducten.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvProducten.BackgroundColor = System.Drawing.Color.White;
            this.dgvProducten.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvProducten.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProducten.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvProducten.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducten.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Product,
            this.Aantal,
            this.Prijs});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProducten.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvProducten.Enabled = false;
            this.dgvProducten.EnableHeadersVisualStyles = false;
            this.dgvProducten.GridColor = System.Drawing.SystemColors.Window;
            this.dgvProducten.Location = new System.Drawing.Point(33, 70);
            this.dgvProducten.MultiSelect = false;
            this.dgvProducten.Name = "dgvProducten";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProducten.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvProducten.RowHeadersVisible = false;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvProducten.RowsDefaultCellStyle = dataGridViewCellStyle10;
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
            this.Product.DividerWidth = 1;
            this.Product.HeaderText = "Product";
            this.Product.MinimumWidth = 300;
            this.Product.Name = "Product";
            this.Product.ReadOnly = true;
            // 
            // Aantal
            // 
            this.Aantal.DividerWidth = 1;
            this.Aantal.HeaderText = "Aantal";
            this.Aantal.Name = "Aantal";
            this.Aantal.ReadOnly = true;
            // 
            // Prijs
            // 
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
            this.lblTPrijs.Location = new System.Drawing.Point(25, 881);
            this.lblTPrijs.Name = "lblTPrijs";
            this.lblTPrijs.Size = new System.Drawing.Size(280, 45);
            this.lblTPrijs.TabIndex = 7;
            this.lblTPrijs.Text = "Totaal prijs: 0 euro";
            this.lblTPrijs.Visible = false;
            // 
            // BetalingInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1398, 958);
            this.Controls.Add(this.lblTPrijs);
            this.Controls.Add(this.dgvProducten);
            this.Controls.Add(this.lblWelkom);
            this.DisplayHeader = false;
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "BetalingInfo";
            this.Padding = new System.Windows.Forms.Padding(30, 67, 30, 32);
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "BetalingInfo";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducten)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelkom;
        private System.Windows.Forms.DataGridView dgvProducten;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product;
        private System.Windows.Forms.DataGridViewTextBoxColumn Aantal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prijs;
        private System.Windows.Forms.Label lblTPrijs;
    }
}