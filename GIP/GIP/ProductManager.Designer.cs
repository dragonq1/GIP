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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Naam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prijs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Omschrijving = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Aanpassen = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Verwijderen = new System.Windows.Forms.DataGridViewButtonColumn();
            this.productManagerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productManagerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Naam,
            this.Prijs,
            this.Omschrijving,
            this.Aanpassen,
            this.Verwijderen});
            this.dataGridView1.Location = new System.Drawing.Point(23, 63);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(544, 434);
            this.dataGridView1.TabIndex = 0;
            // 
            // Naam
            // 
            this.Naam.HeaderText = "Naam";
            this.Naam.Name = "Naam";
            this.Naam.ReadOnly = true;
            // 
            // Prijs
            // 
            this.Prijs.HeaderText = "Prijs";
            this.Prijs.Name = "Prijs";
            this.Prijs.ReadOnly = true;
            // 
            // Omschrijving
            // 
            this.Omschrijving.HeaderText = "Omschrijving";
            this.Omschrijving.Name = "Omschrijving";
            this.Omschrijving.ReadOnly = true;
            // 
            // Aanpassen
            // 
            this.Aanpassen.HeaderText = "Aanpassen";
            this.Aanpassen.Name = "Aanpassen";
            this.Aanpassen.ReadOnly = true;
            // 
            // Verwijderen
            // 
            this.Verwijderen.HeaderText = "Verwijderen";
            this.Verwijderen.Name = "Verwijderen";
            this.Verwijderen.ReadOnly = true;
            // 
            // productManagerBindingSource
            // 
            this.productManagerBindingSource.DataSource = typeof(Business.ProductManager);
            // 
            // ProductManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 566);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ProductManager";
            this.Text = "ProductManager";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productManagerBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naam;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prijs;
        private System.Windows.Forms.DataGridViewTextBoxColumn Omschrijving;
        private System.Windows.Forms.DataGridViewButtonColumn Aanpassen;
        private System.Windows.Forms.DataGridViewButtonColumn Verwijderen;
        private System.Windows.Forms.BindingSource productManagerBindingSource;
    }
}