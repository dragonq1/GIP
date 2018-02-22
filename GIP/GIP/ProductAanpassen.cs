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
    public partial class ProductAanpassen : MetroForm
    {
        Business.ProductManager PMB = new Business.ProductManager();

        public ProductAanpassen()
        {
            InitializeComponent();
            loadInfo();
        }



        public String Naam { get; set; }
        public String OSV { get; set; }
        public double Prijs { get; set; }

        private ProductManager PM = null;

        public ProductAanpassen(String naam, String omschrijving, double prijs, ProductManager productManager)
        {
            Naam = naam;
            OSV = omschrijving;
            Prijs = prijs;

            InitializeComponent();
            loadInfo();
            PM = productManager;
        }

        public void loadInfo()
        {
            txtNaam.Text = Naam;
            txtOmschrijving.Text = OSV;
            txtPrijs.Text = Prijs.ToString();
        }



        private void btnAnnuleren_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAanpassen_Click(object sender, EventArgs e)
        {
            if(!(txtNaam.Equals("") || txtOmschrijving.Equals("") || txtPrijs.Equals(""))) 
            {
                String strOudeNaam = Naam;

                String strNaam = txtNaam.Text.ToString();
                String strOSV = txtOmschrijving.Text.ToString();

                double dblPrijs;

                if(double.TryParse(txtPrijs.Text.ToString(), out dblPrijs ))
                {
                    String resultD = PMB.delProduct(Naam);
                    if(resultD.Equals("success"))
                    {
                        String resultA = PMB.addProduct(strNaam, strOSV, dblPrijs);
                        if(resultA.Equals("success"))
                        {
                            this.Close();
                            PM.loadProducts();
                        }
                        else if(resultA.Equals("excists"))
                        {
                            MessageBox.Show("Productnaam is al in gebruik!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        else
                        {
                            MessageBox.Show("Fout: " + resultA, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Fout: " + resultD, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    MessageBox.Show("Vul een geldige prijs in!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Vul alle velden in!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
