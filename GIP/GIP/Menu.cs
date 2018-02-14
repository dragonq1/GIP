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
    public partial class Menu : MetroForm
    {
        //Nakijken of gebruiker applicatie sluit
        private void Menu_FormClosing(object sender, FormClosingEventArgs e)
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
        StartForm startform = new StartForm();
        ProductManager PM = new ProductManager();
        Business.Comm comm = new Business.Comm();

        public Menu()
        {
            InitializeComponent();
        }

        //Buttons
        private void btnUitloggen_Click(object sender, EventArgs e)
        {
            Boolean result = comm.ResetUser();
            if(result)
            {
                startform.Show();
                this.Visible = false;
            }else
            {
                MessageBox.Show("Oeps! Er is iets fout gelopen. Foutcode: " + result, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void btnPM_Click(object sender, EventArgs e)
        {
            PM.Show();
            this.Visible = false;
        }
    }
}
