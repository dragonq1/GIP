namespace GIP
{
    partial class ProductManager
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.btnPToevoegen = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.productManagerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productManagerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProducts
            // 
            this.dgvProducts.AllowUserToAddRows = false;
            this.dgvProducts.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvProducts.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProducts.Anchor = System.Windows.Forms.AnchorStyles.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Location = new System.Drawing.Point(23, 63);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.ReadOnly = true;
            this.dgvProducts.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvProducts.RowTemplate.Height = 30;
            this.dgvProducts.Size = new System.Drawing.Size(950, 610);
            this.dgvProducts.TabIndex = 0;
            this.dgvProducts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProducts_CellContentClick);
            // 
            // btnPToevoegen
            // 
            this.btnPToevoegen.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPToevoegen.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPToevoegen.Location = new System.Drawing.Point(980, 63);
            this.btnPToevoegen.Margin = new System.Windows.Forms.Padding(4);
            this.btnPToevoegen.Name = "btnPToevoegen";
            this.btnPToevoegen.Size = new System.Drawing.Size(238, 46);
            this.btnPToevoegen.TabIndex = 2;
            this.btnPToevoegen.Text = "Product toevoegen";
            this.btnPToevoegen.UseVisualStyleBackColor = true;
            this.btnPToevoegen.Click += new System.EventHandler(this.btnPToevoegen_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnMenu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.Location = new System.Drawing.Point(980, 626);
            this.btnMenu.Margin = new System.Windows.Forms.Padding(4);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(238, 46);
            this.btnMenu.TabIndex = 3;
            this.btnMenu.Text = "Menu";
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // productManagerBindingSource
            // 
            this.productManagerBindingSource.DataSource = typeof(Business.ProductManager);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Location = new System.Drawing.Point(980, 117);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(4);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(238, 46);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.Text = "Opnieuw inladen";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // ProductManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1230, 696);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.btnPToevoegen);
            this.Controls.Add(this.dgvProducts);
            this.Name = "ProductManager";
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "ProductManager";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ProductManager_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productManagerBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.BindingSource productManagerBindingSource;
        private System.Windows.Forms.Button btnPToevoegen;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Button btnRefresh;
    }
}