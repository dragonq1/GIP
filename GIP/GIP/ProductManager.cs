using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace GIP
{
    public partial class ProductManager : MetroForm
    {
        
        //Vars
        Business.ProductManager PMB = new Business.ProductManager();
        

        public ProductManager()
        {
            InitializeComponent();
            loadProducts();
        }

        private void btnPToevoegen_Click(object sender, EventArgs e)
        {
            ProductToevoegen PT = new ProductToevoegen();
            PT.Show();
        }

        private void dgvProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                int rowIndex = e.RowIndex;
                String strIDNaam = dgvProducts.Rows[rowIndex].Cells["Naam"].Value.ToString();

                //Aanpas button
                if(e.ColumnIndex == 3)
                {
                    MessageBox.Show(strIDNaam, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    //Verwijder button
                }
                else{

                }
            }
        }


        public void loadProducts()
        {
            try
            {
                List<Business.Product> listProducts = PMB.getAllProducts();
                int Aantal = listProducts.Count;
                //Aanpas button
                DataGridViewButtonColumn aButton = new DataGridViewButtonColumn();
                aButton.Name = "aButton";
                aButton.Text = "Aanpassen";
                aButton.HeaderText = "Aanpassen";
                aButton.UseColumnTextForButtonValue = true;
                //Verwijderd Button
                DataGridViewButtonColumn dButton = new DataGridViewButtonColumn();
                dButton.Name = "dButton";
                dButton.Text = "Verwijderen";
                dButton.HeaderText = "Verwijderen";
                dButton.UseColumnTextForButtonValue = true;

                //Buttons toevoegen
                dgvProducts.Columns.Add(aButton);
                dgvProducts.Columns.Add(dButton);

                //int Teller = 0; 
                foreach (Business.Product product in listProducts)
                {
                    String strNaam = product.getNaam();
                    String strOm = product.getOmschrijving();
                    String strPrijs = product.getPrijs().ToString();
                    dgvProducts.Rows.Add(strNaam, strPrijs, strOm);
                }            
            }catch(Exception e)
            {
                MessageBox.Show("Fout: " + e.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
       

        private void btnMenu_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Menu menu = new Menu();
            menu.Show();
        }
    }
}
