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
    public partial class frmUpdatePartener : Form
    {
        public frmUpdatePartener()
        {
            InitializeComponent();
        }
        DataClassesDataContext db = new DataClassesDataContext();
        private void btnSavePartener_Click(object sender, EventArgs e)
        {
            string numePartener = txtNumePartener.Text;
            string tipPartener = comboTipPartener.Text;
            string cuiPartener = txtCuiPartener.Text;
            string adresaPartener = txtAdresaPartener.Text;
            var st = (from s in db.Parteneris where s.Cod == int.Parse(txtCodPartener.Text) select s).First();
            st.Nume = numePartener;
            st.Tip = tipPartener;
            st.Cui = cuiPartener;
            st.Adresa = adresaPartener;
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
