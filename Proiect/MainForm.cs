using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnProduse_Click(object sender, EventArgs e)
        {
            frmProduse produse = new frmProduse();
            produse.ShowDialog();
        }

        private void btnGestiuni_Click(object sender, EventArgs e)
        {
            frmGestiuni gestiuni = new frmGestiuni();
            gestiuni.ShowDialog();
        }

        private void btnParteneri_Click(object sender, EventArgs e)
        {
            frmParteneri parteneri = new frmParteneri();
            parteneri.ShowDialog();
        }

        private void btnIntrari_Click(object sender, EventArgs e)
        {
            frmIntrari intrari = new frmIntrari();
            intrari.ShowDialog();
        }

        private void btnIesiri_Click(object sender, EventArgs e)
        {
            frmIesiri iesiri = new frmIesiri();
            iesiri.ShowDialog();
        }

        private void btnRapoarte_Click(object sender, EventArgs e)
        {
            frmRapoarte rapoarte = new frmRapoarte();
            rapoarte.ShowDialog();
        }
    }
}
