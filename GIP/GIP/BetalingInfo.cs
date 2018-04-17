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
using System.Timers;

namespace GIP
{
    public partial class BetalingInfo : MetroForm
    {
        //Vars
        Business.Comm comm = new Business.Comm();
        public double TPrijs { get; set; }
        public String QRCode { get; set; }

        public BetalingInfo(Kassa kassa)
        {
            InitializeComponent();
            _parent = kassa;
        }

        private Kassa _parent = null;

        public void loadInfo(List<Business.FactuurItem> FactuurList)
        {
            dgvProducten.Visible = true;
            lblTPrijs.Visible = true;
            lblWelkom.Visible = false;


            dgvProducten.Rows.Clear();

            if (FactuurList.Any())
            {
                foreach (Business.FactuurItem FI in FactuurList)
                {
                    String strNaam = FI.PNaam;
                    String strAantal = FI.Aantal.ToString();
                    String strPrijs = "€ " + FI.PrijsT.ToString();
                    dgvProducten.Rows.Add(strNaam, strAantal, strPrijs);
                }

                dgvProducten.ClearSelection();
                setTPrijs(FactuurList);
            }
            else
            {
                clearInfo();
            }

        }

        public void setTPrijs(List<Business.FactuurItem> FactuurList)
        {
            double dblTPrijs = 0;

            foreach (Business.FactuurItem FI in FactuurList)
            {
                dblTPrijs += FI.PrijsT;
            }
            TPrijs = dblTPrijs;
            lblTPrijs.Text = "Totaal prijs: " + dblTPrijs.ToString() + " euro";

        }


        public void clearInfo()
        {
            timerBetaling.Stop();
            dgvProducten.Visible = false;
            lblTPrijs.Visible = false;
            pbQR.Image = null;
            pbQR.Visible = false;
            lblStatus.Visible = false;
            lblWelkom.Visible = true;

            dgvProducten.Rows.Clear();
        }

        public void startBetaling()
        {

            //Vars
            Business.Gebruiker gebruiker = Business.GlobalInfo.Gebruiker;
            //Code aanmaken
            Random rdm = new Random();
            int intRDM = rdm.Next(100, 5000);
            String qrCode = "2247-" + gebruiker.UserID + "-" + TPrijs.ToString() + "-" + intRDM.ToString();

            //Betaling aanmaken
            String resultB = comm.addBetaling(qrCode, TPrijs);
            if (resultB.Equals("success"))
            {
                Boolean resultQR = createQRCode(qrCode);
                if (resultQR)
                {
                    _parent.bBetaling = true;
                    QRCode = qrCode;
                    lblStatus.Visible = true;
                    timerBetaling.Start();

                }
                else
                {
                    MessageBox.Show("Fout bij aanmaken van QR-Code", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Fout: " + resultB, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        //Teller voor lblStatus
        int intTeller = 1;

        //Timer voor nakijken betaling
        private void timerBetaling_tick(Object sender, EventArgs e)
        {
            Boolean resultBetaling = comm.checkBetaling(QRCode);
            if (resultBetaling)
            {
                timerBetaling.Stop();
                clearInfo();
                _parent.FactuurList.Clear();
                _parent.loadFactuur();
                MessageBox.Show("Transactie geslaagd!", "Transactie", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _parent.bBetaling = false;
            }
            else
            {
                switch (intTeller)
                {
                    case 1:
                        lblStatus.Text = "Wachten op bevestiging.";
                        intTeller++;
                        break;
                    case 2:
                        lblStatus.Text = "Wachten op bevestiging..";
                        intTeller++;
                        break;
                    case 3:
                        lblStatus.Text = "Wachten op bevestiging...";
                        intTeller = 1;
                        break;
                }

            }
        }


        public Boolean createQRCode(string Tekst)
        {
            try
            {
                String tekst = Tekst;
                QRCodeGenerator qrGenerator = new QRCodeGenerator();
                QRCodeData qrCodeData = qrGenerator.CreateQrCode(tekst, QRCodeGenerator.ECCLevel.Q);
                QRCode qrCode = new QRCode(qrCodeData);
                pbQR.Image = qrCode.GetGraphic(15);
                pbQR.Height = pbQR.Bounds.Height;
                pbQR.Width = pbQR.Bounds.Width;
                dgvProducten.Visible = false;
                pbQR.Visible = true;
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }


    }
}
