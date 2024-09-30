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
    public partial class frmAddGestiune : Form
    {
        public frmAddGestiune()
        {
            InitializeComponent();
        }
        DataClassesDataContext db = new DataClassesDataContext();
        private void btnSaveGestiune_Click(object sender, EventArgs e)
        {
            int maxCod = db.Gestiunis.Any() ? db.Gestiunis.Max(p => p.Cod).GetValueOrDefault() : 0;

            int nextCod = maxCod + 1;
            string numeGestiune = txtNumeGestiune.Text;

            var st = new Gestiuni
            {
                Cod = nextCod,
                Nume = numeGestiune,               
            };

            db.Gestiunis.InsertOnSubmit(st);
            db.SubmitChanges();

            var produse = Application.OpenForms["frmgestiuni"] as frmGestiuni;
            produse.loadData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
