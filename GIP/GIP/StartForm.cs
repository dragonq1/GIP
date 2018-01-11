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
        QRCodeGen QRCodeGen = new QRCodeGen();


        public StartForm()
        {
            InitializeComponent();
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
            this.Close();
        }
    }
}
