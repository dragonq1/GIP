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

namespace GIP
{
    public partial class Form1 : Form
    {
        QRCodeGen QRCodeGen = new QRCodeGen();


        public Form1()
        {
            InitializeComponent();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {           
                String tekst = tbTekst.Text;
                QRCodeGenerator qrGenerator = new QRCodeGenerator();
                QRCodeData qrCodeData = qrGenerator.CreateQrCode(tekst, QRCodeGenerator.ECCLevel.Q);
                QRCode qrCode = new QRCode(qrCodeData);
                pbBox.Image = qrCode.GetGraphic(15);
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
