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
    public partial class frmAddProdus : Form
    {
        public frmAddProdus()
        {
            InitializeComponent();
        }
       
        DataClassesDataContext db = new DataClassesDataContext();

        private void btnSaveProdus_Click(object sender, EventArgs e)
        {
            int maxCod = db.Produses.Any() ? db.Produses.Max(p => p.Cod).GetValueOrDefault() : 0;

            int nextCod = maxCod + 1;
            string numeProdus = txtNumeProdus.Text;
            decimal pretProdus = decimal.Parse(txtPretProdus.Text);

            var st = new Produse
            {
                Cod = nextCod,
                Nume = numeProdus,
                Pret = pretProdus,
            };

            db.Produses.InsertOnSubmit(st);
            db.SubmitChanges();

            var produse = Application.OpenForms["frmProduse"] as frmProduse;
            produse.loadData();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAddProdus_Load(object sender, EventArgs e)
        {

        }
    }
}
