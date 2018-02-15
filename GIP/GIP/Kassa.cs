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
    public partial class Kassa : MetroForm
    {
        Business.ProductManager PMB = new Business.ProductManager();

        public Kassa()
        {
            InitializeComponent();
            loadProducts();
        }

        //Nakijken of gebruiker applicatie sluit
        private void Kassa_FormClosing(object sender, FormClosingEventArgs e)
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

        public void loadProducts()
        {

            //Kolommen
            int intWidth = 150;
            dgvProducten.Columns.Add("Kolom1", "Kolom1");
            dgvProducten.Columns["Kolom1"].Width = intWidth;

            dgvProducten.Columns.Add("Kolom2", "Kolom2");
            dgvProducten.Columns["Kolom2"].Width = intWidth;

            dgvProducten.Columns.Add("Kolom3", "Kolom3");
            dgvProducten.Columns["Kolom3"].Width = intWidth;

            dgvProducten.Columns.Add("Kolom4", "Kolom4");
            dgvProducten.Columns["Kolom4"].Width = intWidth;

            dgvProducten.DefaultCellStyle.WrapMode = DataGridViewTriState.True;



            //Lijst ophalen
            List<Business.Product> listProducts = PMB.getAllProducts();

            int intTeller = 1;
            int intRow = 0;
            int intCell = 0;

            //Data uit lijst lezen en in tabel zetten
            foreach (Business.Product product in listProducts)
            {

                switch (intTeller)
                {
                    case 1:
                        String strNaam1 = product.getNaam();
                        String strPrijs1 = product.getPrijs().ToString();

                        DataGridViewButtonCell bp1 = new DataGridViewButtonCell()
                        {
                            Tag = strNaam1,
                            Value = strNaam1 + Environment.NewLine + "€" + strPrijs1
                        };

                        dgvProducten.Rows.Add("", "", "", "");
                        dgvProducten.Rows[intRow].Height = 159;
                        dgvProducten.Rows[intRow].Cells[intCell] = bp1;

                        intCell++;
                        intTeller++;
                        break;
                    case 2:
                        String strNaam2 = product.getNaam();
                        String strPrijs2 = product.getPrijs().ToString();
                        DataGridViewButtonCell bp2 = new DataGridViewButtonCell()
                        {
                            Tag = strNaam2,
                            Value = strNaam2 + Environment.NewLine + "€" + strPrijs2
                        };
                        dgvProducten.Rows[intRow].Cells[intCell] = bp2;

                        intCell++;
                        intTeller++;
                        break;
                    case 3:
                        String strNaam3 = product.getNaam();
                        String strPrijs3 = product.getPrijs().ToString();
                        DataGridViewButtonCell bp3 = new DataGridViewButtonCell()
                        {
                            Tag = strNaam3,
                            Value = strNaam3 + Environment.NewLine + "€" + strPrijs3
                        };
                        dgvProducten.Rows[intRow].Cells[intCell] = bp3;

                        intCell++;
                        intTeller++;
                        break;
                    case 4:
                        String strNaam4 = product.getNaam();
                        String strPrijs4 = product.getPrijs().ToString();
                        DataGridViewButtonCell bp4 = new DataGridViewButtonCell()
                        {
                            Tag = strNaam4,
                            Value = strNaam4 + Environment.NewLine + "€" + strPrijs4
                        };
                        dgvProducten.Rows[intRow].Cells[intCell] = bp4;

                        intRow++;
                        intCell = 0;
                        intTeller = 1;
                        break;
                }


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
