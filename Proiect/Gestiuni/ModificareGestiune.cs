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
    public partial class frmUpdateGestiune : Form
    {
        public frmUpdateGestiune()
        {
            InitializeComponent();
        }
        DataClassesDataContext db = new DataClassesDataContext();
        private void btnSaveGestiune_Click(object sender, EventArgs e)
        {
            string numeGestiune = txtNumeGestiune.Text;
            var st = (from s in db.Gestiunis where s.Cod == int.Parse(txtCodGestiune.Text) select s).First();
            st.Nume = numeGestiune;
            db.SubmitChanges();

            var gestiuni = Application.OpenForms["frmGestiuni"] as frmGestiuni;
            gestiuni.loadData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
