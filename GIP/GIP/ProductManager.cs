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
        //Nakijken of gebruiker applicatie sluit
        private void ProductManager_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (MessageBox.Show("Ben je zeker dat je applicatie wilt sluiten?", "Afsluiten", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Environment.Exit(1);
            }
            else
            {
                e.Cancel = true;
            }
        }


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
                String strOSV = dgvProducts.Rows[rowIndex].Cells["Omschrijving"].Value.ToString();
                double prijs = Double.Parse(dgvProducts.Rows[rowIndex].Cells["Prijs"].Value.ToString());

                //Aanpas button
                if (e.ColumnIndex == 3)
                {
                    ProductAanpassen PA = new ProductAanpassen(strIDNaam, strOSV, prijs);

                    PA.Show();

                    //Verwijder button
                }
                else
                {
                    if(MessageBox.Show("Ben je zeker dat je dit product wilt verwijderen", "Waarschwuing!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                    {
                        String strResult = PMB.delProduct(strIDNaam);
                        if (strResult.Equals("success"))
                        {

                            loadProducts();
                        }
                        else
                        {
                            MessageBox.Show("Er ging iets fout! " + strResult, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }else
                    {
                        //niets
                    }
                }
            }
        }


        public void loadProducts()
        {
            try
            {
                //DGV clearen en kolommen aanmaken
                dgvProducts.Rows.Clear();
                dgvProducts.Columns.Clear();

                dgvProducts.Columns.Add("Naam", "Naam");
                dgvProducts.Columns.Add("Prijs", "Prijs");
                dgvProducts.Columns.Add("Omschrijving", "Omschrijving");
                dgvProducts.Columns["Omschrijving"].Width = 317;
                dgvProducts.Columns["Prijs"].Width = 50;
                dgvProducts.Columns["Naam"].Width = 150;

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

                //Data uit lijst lezen en in tabel zetten
                foreach (Business.Product product in listProducts)
                {
                    String strNaam = product.getNaam();
                    String strOm = product.getOmschrijving();
                    String strPrijs = product.getPrijs().ToString();
                    dgvProducts.Rows.Add(strNaam, strPrijs, strOm);
                }
            }
            catch (Exception e)
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

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            loadProducts();
        }
    }
}
