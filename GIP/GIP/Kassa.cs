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
        Business.FactuurItem FIE = new Business.FactuurItem();
        BetalingInfo BI;

        //Factuur lijst
        public List<Business.FactuurItem> FactuurList = new List<Business.FactuurItem>();

        public Kassa()
        {
            BI = new BetalingInfo(this);
            InitializeComponent();
            loadProducts();
            openInfoScreen();
            BI.clearInfo();
        }

        //Info scherm openen
        public void openInfoScreen()
        {
            if (Screen.AllScreens.Length > 1)
            {

                Form BIT = Application.OpenForms["BetalingInfo"];

                if (BIT != null)
                {
                    BI.Show();
                }
                else
                {
                    Screen screen = GetSecondaryScreen();

                    BI.Location = screen.WorkingArea.Location;

                    BI.Size = new Size(screen.WorkingArea.Width, screen.WorkingArea.Height);

                    BI.Show();
                }
            }
            else
            {
                BI.Show();
            }
        }

        public Screen GetSecondaryScreen()
        {
            if (Screen.AllScreens.Length == 1)
            {
                return null;
            }

            foreach (Screen screen in Screen.AllScreens)
            {
                if (screen.Primary == false)
                {
                    return screen;
                }
            }

            return null;
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


        //Buttons op factuur linken
        private void dvgFactuur_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                int rowIndex = e.RowIndex;
                String strPNaam = dvgFactuur.Rows[rowIndex].Cells[0].Value.ToString();
                var FI = FactuurList.Single(F => F.PNaam == strPNaam);

                //+1
                if (e.ColumnIndex == 4)
                {
                    FI.addOne();
                    loadFactuur();
                }

                //-1
                else if (e.ColumnIndex == 5)
                {
                    if (FI.Aantal > 1)
                    {
                        FI.minOne();
                        loadFactuur();
                    }
                    else
                    {
                        //Niets -> kan niet onder 0
                    }
                }

                //Verwijderen
                else
                {
                    FactuurList.Remove(FI);
                    loadFactuur();
                }

            }
        }

        //Producten toevoegen aan factuur
        private void dvgProducten_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (e.RowIndex >= 0)
            {
                int intRow = e.RowIndex;
                int intKolom = e.ColumnIndex;

                //Cell tag ophalen
                String strPNaam = dgvProducten.Rows[intRow].Cells[intKolom].Tag.ToString();

                //Lijst ophalen
                List<Business.Product> productsLijst = PMB.getAllProducts();

                //Producten info ophalen
                var product = productsLijst.Single(Product => Product.Naam == strPNaam);
                String strPrijs = product.getPrijs().ToString();



                int checkIndex = FactuurList.FindIndex(F => F.PNaam == strPNaam);

                if (checkIndex >= 0)
                {
                    var FI = FactuurList.Single(F => F.PNaam == strPNaam);
                    FI.addOne();
                }
                else
                {
                    Business.FactuurItem FI = new Business.FactuurItem(strPNaam, double.Parse(strPrijs), 1, double.Parse(strPrijs));
                    FactuurList.Add(FI);
                }

                loadFactuur();

            }
        }

        //Prodcuten op factuur inladen of refreshen
        public void loadFactuur()
        {
            dvgFactuur.Rows.Clear();

            if (FactuurList.Any())
            {
                foreach (Business.FactuurItem FI in FactuurList)
                {
                    dvgFactuur.Rows.Add(FI.PNaam, "€ " + FI.PrijsPS.ToString(), FI.Aantal.ToString(), "€ " + FI.PrijsT.ToString());
                }

                BI.loadInfo(FactuurList);
                getTPrijs();
            }
            else
            {
                BI.loadInfo(FactuurList);
                getTPrijs();
                //Lijst is leeg => niets
            }

        }

        public void loadProducts()
        {

            //+ en - button aanmaken
            DataGridViewButtonColumn minBtn = new DataGridViewButtonColumn()
            {
                Name = "minBtn",
                Text = "-",
                HeaderText = "-1",
                UseColumnTextForButtonValue = true
            };

            DataGridViewButtonColumn plusBtn = new DataGridViewButtonColumn()
            {
                Name = "plusBtn",
                Text = "+",
                HeaderText = "+1",
                UseColumnTextForButtonValue = true

            };

            DataGridViewButtonColumn vBtn = new DataGridViewButtonColumn()
            {
                Name = "vBtn",
                Text = "x",
                HeaderText = "X",
                UseColumnTextForButtonValue = true

            };

            dvgFactuur.Columns.Add(plusBtn);
            dvgFactuur.Columns.Add(minBtn);
            dvgFactuur.Columns.Add(vBtn);

            dvgFactuur.Columns["minBtn"].Width = 70;
            dvgFactuur.Columns["plusBtn"].Width = 70;
            dvgFactuur.Columns["vBtn"].Width = 70;

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
            dgvProducten.ScrollBars = ScrollBars.Vertical;



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

        public void getTPrijs()
        {
            double dblTPrijs = 0;

            foreach (Business.FactuurItem FI in FactuurList)
            {
                dblTPrijs += FI.PrijsT;
            }
            lblTPrijs.Text = "Totaal prijs: " + dblTPrijs.ToString() + " euro";

        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            BI.Close();
            this.Visible = false;
            Menu menu = new Menu();
            menu.Show();
        }

        private void btnNieuw_Click(object sender, EventArgs e)
        {
            FactuurList.Clear();
            loadFactuur();
            BI.clearInfo();
        }

        private void btnBetalen_Click(object sender, EventArgs e)
        {
           BI.startBetaling();

        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            BI.createQRCode("TestCode");
        }
    }
}
