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
    public partial class frmAddPartener : Form
    {
        public frmAddPartener()
        {
            InitializeComponent();
        }
        DataClassesDataContext db = new DataClassesDataContext();
        private void btnSavePartener_Click(object sender, EventArgs e)
        {
            int maxCod = db.Parteneris.Any() ? db.Parteneris.Max(p => p.Cod).GetValueOrDefault() : 0;

            int nextCod = maxCod + 1;
            string numePartener = txtNumePartener.Text;
            string tipPartener = comboTipPartener.Text;
            string cuiPartener = txtCuiPartener.Text;
            string adresaPartener = txtAdresaPartener.Text;

            var st = new Parteneri
            {
                Cod = nextCod,
                Nume = numePartener,
                Tip = tipPartener,
                Cui = cuiPartener,
                Adresa = adresaPartener,
            };

            db.Parteneris.InsertOnSubmit(st);
            db.SubmitChanges();

            var parteneri = Application.OpenForms["frmParteneri"] as frmParteneri;
            parteneri.loadData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
