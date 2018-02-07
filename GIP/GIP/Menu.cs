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
        //Vars
        StartForm startform = new StartForm();
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
    }
}
