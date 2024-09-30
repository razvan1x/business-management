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
    public partial class frmGestiuni : Form
    {
        public frmGestiuni()
        {
            InitializeComponent();
        }
        private void btnGestiuniClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        DataClassesDataContext db = new DataClassesDataContext();

        private void btnAddGestiune_Click(object sender, EventArgs e)
        {
            frmAddGestiune adaugagestiune = new frmAddGestiune();
            adaugagestiune.ShowDialog();
        }
        public void loadData()
        {
            var date = from a in db.GetTable<Gestiuni>() select a;
            dataGridViewGestiuni.DataSource = date;
        }
        private void btnUpdateGestiune_Click(object sender, EventArgs e)
        {
           frmUpdateGestiune modificaregestiune = new frmUpdateGestiune();
           modificaregestiune.ShowDialog();
        }

        private void frmGestiuni_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void btnDeleteGestiune_Click(object sender, EventArgs e)
        {
            if (dataGridViewGestiuni.SelectedRows.Count > 0)
            {
                int rowIndex = dataGridViewGestiuni.SelectedCells[0].RowIndex;

                string codGestiune = dataGridViewGestiuni.Rows[rowIndex].Cells[1].Value.ToString();
                string numeGestiune = dataGridViewGestiuni.Rows[rowIndex].Cells[2].Value.ToString();

                DialogResult result = MessageBox.Show("Doriti sa stergeti gestiunea cu urmatoarele detalii?\n\nCod gestiune: " + codGestiune + "\nNume gestiune: " + numeGestiune, "Confirmare stergere", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    Gestiuni del = db.Gestiunis.FirstOrDefault(dell => dell.Cod.Equals(codGestiune));
                    if (del != null)
                    {
                        db.Gestiunis.DeleteOnSubmit(del);
                        db.SubmitChanges();
                        MessageBox.Show("Gestiunea a fost stearsa cu succes!", "Stergere reusita", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loadData();
                    }
                    else
                    {
                        MessageBox.Show("Gestiunea nu a fost gasita în baza de date!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Va rugam sa selectati linia pe care doriti s-o stergeti!", "Atentie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
