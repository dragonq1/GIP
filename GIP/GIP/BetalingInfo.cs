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
    public partial class BetalingInfo : MetroForm
    {
        public BetalingInfo()
        {
            InitializeComponent();
        }

        public void loadInfo(List<Business.FactuurItem> FactuurList)
        {
            dgvProducten.Visible = true;
            lblTPrijs.Visible = true;
            lblWelkom.Visible = false;


            dgvProducten.Rows.Clear();

            foreach(Business.FactuurItem FI in FactuurList)
            {
                String strNaam = FI.PNaam;
                String strAantal = FI.Aantal.ToString();
                String strPrijs = FI.PrijsT.ToString();
                dgvProducten.Rows.Add(strNaam, strAantal, strPrijs);
            }

            dgvProducten.ClearSelection();
            setTPrijs(FactuurList);
        }

        public void setTPrijs(List<Business.FactuurItem> FactuurList)
        {
            double dblTPrijs = 0;

            foreach (Business.FactuurItem FI in FactuurList)
            {
                dblTPrijs += FI.PrijsT;
            }
            lblTPrijs.Text = "Totaal prijs: " + dblTPrijs.ToString() + " euro";

        }


        public void clearInfo()
        {
            dgvProducten.Visible = false;
            lblTPrijs.Visible = false;
            lblWelkom.Visible = true;
            dgvProducten.Rows.Clear();
        }


    }
}
