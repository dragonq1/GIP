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
    public partial class ProductToevoegen : MetroForm
    {
        //Vars
        Business.ProductManager PMB = new Business.ProductManager();
        ProductManager PM = new ProductManager();

        public ProductToevoegen()
        {
            InitializeComponent();
        }

        private void btnToevoegen_Click(object sender, EventArgs e)
        {
            String strNaam = txtNaam.Text;
            String strPrijs = txtPrijs.Text;
            String strOmSc = txtOmschrijving.Text;

            if(!(strNaam.Equals("") || strPrijs.Equals("") || strOmSc.Equals("")))
            {
                try
                {
                    Double dblPrijs = Double.Parse(strPrijs);
                    String strResult = PMB.addProduct(strNaam, strOmSc, dblPrijs);

                    if(strResult.Equals("success"))
                    {
                        this.Close();
                        PM.loadProducts();
                    }
                    else if(strResult.Equals("excists"))
                    {
                        MessageBox.Show("Product naam is al in gebruik!","ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else {
                        MessageBox.Show("Fout: " + strResult, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Vul een geldig prijs in!","Fout", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Vul alle velden in!", "Fout", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnAnnuleren_Click(object sender, EventArgs e)
        {
            PM.loadProducts();
            this.Close();
        }
    }
}
