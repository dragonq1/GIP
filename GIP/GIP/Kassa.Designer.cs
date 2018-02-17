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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.btnTest = new System.Windows.Forms.Button();
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
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProducten.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgvProducten.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgvProducten.Location = new System.Drawing.Point(3, 39);
            this.dgvProducten.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvProducten.Name = "dgvProducten";
            this.dgvProducten.ReadOnly = true;
            this.dgvProducten.RowHeadersVisible = false;
            this.dgvProducten.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvProducten.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvProducten.RowTemplate.DefaultCellStyle.NullValue = null;
            this.dgvProducten.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProducten.RowTemplate.Height = 49;
            this.dgvProducten.Size = new System.Drawing.Size(828, 866);
            this.dgvProducten.TabIndex = 0;
            this.dgvProducten.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgProducten_CellContentClick);
            // 
            // btnMenu
            // 
            this.btnMenu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.Location = new System.Drawing.Point(1796, 146);
            this.btnMenu.Margin = new System.Windows.Forms.Padding(4);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(193, 46);
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
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvgFactuur.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dvgFactuur.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgFactuur.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Product,
            this.Prijs_pp,
            this.Aantal,
            this.Prijs_totaal});
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dvgFactuur.DefaultCellStyle = dataGridViewCellStyle15;
            this.dvgFactuur.Location = new System.Drawing.Point(836, 39);
            this.dvgFactuur.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dvgFactuur.MultiSelect = false;
            this.dvgFactuur.Name = "dvgFactuur";
            this.dvgFactuur.ReadOnly = true;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvgFactuur.RowHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.dvgFactuur.RowHeadersVisible = false;
            this.dvgFactuur.RowTemplate.Height = 30;
            this.dvgFactuur.Size = new System.Drawing.Size(953, 866);
            this.dvgFactuur.TabIndex = 5;
            this.dvgFactuur.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgFactuur_CellContentClick);
            // 
            // Product
            // 
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Product.DefaultCellStyle = dataGridViewCellStyle11;
            this.Product.HeaderText = "Product";
            this.Product.Name = "Product";
            this.Product.ReadOnly = true;
            this.Product.Width = 190;
            // 
            // Prijs_pp
            // 
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.Format = "C2";
            dataGridViewCellStyle12.NullValue = null;
            this.Prijs_pp.DefaultCellStyle = dataGridViewCellStyle12;
            this.Prijs_pp.HeaderText = "Prijs p.s.";
            this.Prijs_pp.Name = "Prijs_pp";
            this.Prijs_pp.ReadOnly = true;
            // 
            // Aantal
            // 
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Aantal.DefaultCellStyle = dataGridViewCellStyle13;
            this.Aantal.HeaderText = "Aantal";
            this.Aantal.Name = "Aantal";
            this.Aantal.ReadOnly = true;
            // 
            // Prijs_totaal
            // 
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.Format = "C2";
            dataGridViewCellStyle14.NullValue = null;
            this.Prijs_totaal.DefaultCellStyle = dataGridViewCellStyle14;
            this.Prijs_totaal.HeaderText = "Prijs totaal";
            this.Prijs_totaal.Name = "Prijs_totaal";
            this.Prijs_totaal.ReadOnly = true;
            this.Prijs_totaal.Width = 110;
            // 
            // lblTPrijs
            // 
            this.lblTPrijs.AutoSize = true;
            this.lblTPrijs.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTPrijs.Location = new System.Drawing.Point(827, 908);
            this.lblTPrijs.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTPrijs.Name = "lblTPrijs";
            this.lblTPrijs.Size = new System.Drawing.Size(292, 46);
            this.lblTPrijs.TabIndex = 6;
            this.lblTPrijs.Text = "Totaal prijs: 0 euro";
            // 
            // btnNieuw
            // 
            this.btnNieuw.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNieuw.Location = new System.Drawing.Point(1796, 41);
            this.btnNieuw.Margin = new System.Windows.Forms.Padding(4);
            this.btnNieuw.Name = "btnNieuw";
            this.btnNieuw.Size = new System.Drawing.Size(193, 46);
            this.btnNieuw.TabIndex = 7;
            this.btnNieuw.Text = "Nieuw";
            this.btnNieuw.UseVisualStyleBackColor = true;
            this.btnNieuw.Click += new System.EventHandler(this.btnNieuw_Click);
            // 
            // btnBetalen
            // 
            this.btnBetalen.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBetalen.Location = new System.Drawing.Point(1796, 94);
            this.btnBetalen.Margin = new System.Windows.Forms.Padding(4);
            this.btnBetalen.Name = "btnBetalen";
            this.btnBetalen.Size = new System.Drawing.Size(193, 46);
            this.btnBetalen.TabIndex = 8;
            this.btnBetalen.Text = "Betalen";
            this.btnBetalen.UseVisualStyleBackColor = true;
            this.btnBetalen.Click += new System.EventHandler(this.btnBetalen_Click);
            // 
            // btnTest
            // 
            this.btnTest.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTest.Location = new System.Drawing.Point(1796, 200);
            this.btnTest.Margin = new System.Windows.Forms.Padding(4);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(193, 46);
            this.btnTest.TabIndex = 9;
            this.btnTest.Text = "Test QR-Code";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // Kassa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2093, 1056);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.btnBetalen);
            this.Controls.Add(this.btnNieuw);
            this.Controls.Add(this.lblTPrijs);
            this.Controls.Add(this.dvgFactuur);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.dgvProducten);
            this.DisplayHeader = false;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Kassa";
            this.Padding = new System.Windows.Forms.Padding(20, 37, 20, 20);
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
        private System.Windows.Forms.Button btnTest;
    }
}