using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect
{
    public partial class frmUpdateProdus : Form
    {
        public frmUpdateProdus()
        {
            InitializeComponent();
        }

        DataClassesDataContext db = new DataClassesDataContext();
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalvareProdus_Click(object sender, EventArgs e)
        {
            string numeProdus = txtNumeProdus.Text;
            decimal pretProdus = decimal.Parse(txtPretProdus.Text);
            var st = (from s in db.Produses where s.Cod == int.Parse(txtCodProdus.Text) select s).First();
            st.Nume = numeProdus;
            st.Pret = pretProdus;
            db.SubmitChanges();

            var produse = Application.OpenForms["frmProduse"] as frmProduse;
            produse.loadData();
        }


    }
}
