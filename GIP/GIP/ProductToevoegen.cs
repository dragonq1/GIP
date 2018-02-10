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
        Business.ProductManager PM = new Business.ProductManager();

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
                    String strResult = PM.addProduct(strNaam, strOmSc, dblPrijs);

                    if(strResult.Equals("success")) {

                    }else
                    {
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
    }
}
