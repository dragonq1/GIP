namespace GIP
{
    partial class Kassa
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvProducten = new System.Windows.Forms.DataGridView();
            this.btnMenu = new System.Windows.Forms.Button();
            this.dvgFactuur = new System.Windows.Forms.DataGridView();
            this.Product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prijs_pp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Aantal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prijs_totaal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTPrijs = new System.Windows.Forms.Label();
            this.btnNieuw = new System.Windows.Forms.Button();
            this.btnBetalen = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducten)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgFactuur)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProducten
            // 
            this.dgvProducten.AllowUserToAddRows = false;
            this.dgvProducten.AllowUserToDeleteRows = false;
            this.dgvProducten.AllowUserToResizeColumns = false;
            this.dgvProducten.AllowUserToResizeRows = false;
            this.dgvProducten.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducten.ColumnHeadersVisible = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProducten.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProducten.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgvProducten.Location = new System.Drawing.Point(2, 32);
            this.dgvProducten.Margin = new System.Windows.Forms.Padding(2);
            this.dgvProducten.Name = "dgvProducten";
            this.dgvProducten.ReadOnly = true;
            this.dgvProducten.RowHeadersVisible = false;
            this.dgvProducten.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvProducten.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvProducten.RowTemplate.DefaultCellStyle.NullValue = null;
            this.dgvProducten.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProducten.RowTemplate.Height = 49;
            this.dgvProducten.Size = new System.Drawing.Size(621, 704);
            this.dgvProducten.TabIndex = 0;
            this.dgvProducten.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgProducten_CellContentClick);
            // 
            // btnMenu
            // 
            this.btnMenu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.Location = new System.Drawing.Point(1347, 119);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(145, 37);
            this.btnMenu.TabIndex = 4;
            this.btnMenu.Text = "Menu";
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // dvgFactuur
            // 
            this.dvgFactuur.AllowUserToAddRows = false;
            this.dvgFactuur.AllowUserToDeleteRows = false;
            this.dvgFactuur.AllowUserToResizeColumns = false;
            this.dvgFactuur.AllowUserToResizeRows = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvgFactuur.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dvgFactuur.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgFactuur.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Product,
            this.Prijs_pp,
            this.Aantal,
            this.Prijs_totaal});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dvgFactuur.DefaultCellStyle = dataGridViewCellStyle7;
            this.dvgFactuur.Location = new System.Drawing.Point(627, 32);
            this.dvgFactuur.Margin = new System.Windows.Forms.Padding(2);
            this.dvgFactuur.MultiSelect = false;
            this.dvgFactuur.Name = "dvgFactuur";
            this.dvgFactuur.ReadOnly = true;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvgFactuur.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dvgFactuur.RowHeadersVisible = false;
            this.dvgFactuur.RowTemplate.Height = 30;
            this.dvgFactuur.Size = new System.Drawing.Size(715, 704);
            this.dvgFactuur.TabIndex = 5;
            this.dvgFactuur.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgFactuur_CellContentClick);
            // 
            // Product
            // 
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Product.DefaultCellStyle = dataGridViewCellStyle3;
            this.Product.HeaderText = "Product";
            this.Product.Name = "Product";
            this.Product.ReadOnly = true;
            this.Product.Width = 190;
            // 
            // Prijs_pp
            // 
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.Format = "C2";
            dataGridViewCellStyle4.NullValue = null;
            this.Prijs_pp.DefaultCellStyle = dataGridViewCellStyle4;
            this.Prijs_pp.HeaderText = "Prijs p.s.";
            this.Prijs_pp.Name = "Prijs_pp";
            this.Prijs_pp.ReadOnly = true;
            // 
            // Aantal
            // 
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Aantal.DefaultCellStyle = dataGridViewCellStyle5;
            this.Aantal.HeaderText = "Aantal";
            this.Aantal.Name = "Aantal";
            this.Aantal.ReadOnly = true;
            // 
            // Prijs_totaal
            // 
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.Format = "C2";
            dataGridViewCellStyle6.NullValue = null;
            this.Prijs_totaal.DefaultCellStyle = dataGridViewCellStyle6;
            this.Prijs_totaal.HeaderText = "Prijs totaal";
            this.Prijs_totaal.Name = "Prijs_totaal";
            this.Prijs_totaal.ReadOnly = true;
            this.Prijs_totaal.Width = 110;
            // 
            // lblTPrijs
            // 
            this.lblTPrijs.AutoSize = true;
            this.lblTPrijs.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTPrijs.Location = new System.Drawing.Point(620, 738);
            this.lblTPrijs.Name = "lblTPrijs";
            this.lblTPrijs.Size = new System.Drawing.Size(234, 37);
            this.lblTPrijs.TabIndex = 6;
            this.lblTPrijs.Text = "Totaal prijs: 0 euro";
            // 
            // btnNieuw
            // 
            this.btnNieuw.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNieuw.Location = new System.Drawing.Point(1347, 33);
            this.btnNieuw.Name = "btnNieuw";
            this.btnNieuw.Size = new System.Drawing.Size(145, 37);
            this.btnNieuw.TabIndex = 7;
            this.btnNieuw.Text = "Nieuw";
            this.btnNieuw.UseVisualStyleBackColor = true;
            this.btnNieuw.Click += new System.EventHandler(this.btnNieuw_Click);
            // 
            // btnBetalen
            // 
            this.btnBetalen.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBetalen.Location = new System.Drawing.Point(1347, 76);
            this.btnBetalen.Name = "btnBetalen";
            this.btnBetalen.Size = new System.Drawing.Size(145, 37);
            this.btnBetalen.TabIndex = 8;
            this.btnBetalen.Text = "Betalen";
            this.btnBetalen.UseVisualStyleBackColor = true;
            // 
            // Kassa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1570, 858);
            this.Controls.Add(this.btnBetalen);
            this.Controls.Add(this.btnNieuw);
            this.Controls.Add(this.lblTPrijs);
            this.Controls.Add(this.dvgFactuur);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.dgvProducten);
            this.DisplayHeader = false;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Kassa";
            this.Padding = new System.Windows.Forms.Padding(15, 30, 15, 16);
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "Kassa";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Kassa_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducten)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgFactuur)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProducten;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.DataGridView dvgFactuur;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prijs_pp;
        private System.Windows.Forms.DataGridViewTextBoxColumn Aantal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prijs_totaal;
        private System.Windows.Forms.Label lblTPrijs;
        private System.Windows.Forms.Button btnNieuw;
        private System.Windows.Forms.Button btnBetalen;
    }
}