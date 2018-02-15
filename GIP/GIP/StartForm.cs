using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QRCoder;
using MetroFramework.Forms;

namespace GIP
{
    public partial class StartForm : MetroForm
    {
        //Nakijken of gebruiker applicatie sluit
        private void StartForm_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (MessageBox.Show("Ben je zeker dat je applicatie wilt sluiten?", "Afsluiten", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Environment.Exit(0);
            }
            else
            {
                e.Cancel = true;
            }
        }

        //Vars
        QRCodeGen QRCodeGen = new QRCodeGen();
        Business.Comm comm = new Business.Comm();
        Business.FileManager FM = new Business.FileManager();


        public StartForm()
        {
            InitializeComponent();
            onStartup();
        }
        
        private void onStartup()
        {
            String result = FM.onStartup();
            if(result.Equals("success"))
            {
                //Niets
            }
            else
            {
                //Fout bij creeëren van files, inloggen blokkeren
                MessageBox.Show("Oeps! Er is iets fout gelopen!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtNaam.Enabled = false;
                txtWachtwoord.Enabled = false;
            }
        }

        private void StartForm_Load(object sender, EventArgs e)
        {
            
        }

        public Bitmap createQRCode(object sender, EventArgs e, string Tekst)
        {
            String tekst = Tekst;
            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(tekst, QRCodeGenerator.ECCLevel.Q);
            QRCode qrCode = new QRCode(qrCodeData);
            return qrCode.GetGraphic(15);
        }

        private void btnAfsluiten_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnInloggen_Click(object sender, EventArgs e)
        {
            if(!(txtNaam.Text.Equals("") || txtWachtwoord.Text.Equals("")))
            {
                String result = comm.Login(txtNaam.Text, txtWachtwoord.Text);
                if (result == "true")
                {
                    Menu menu = new Menu();
                    menu.Show();
                    this.Visible = false;
                }else if(result == "false")
                {
                    lblLogin.Visible = true;

                }
                else
                {
                    MessageBox.Show("Oeps! Er is iets fout gelopen. Foutcode: " + result, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }
            else               
            {
                //Niets
            }
        }
    }
}
