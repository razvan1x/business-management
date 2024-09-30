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
    public partial class frmParteneri : Form
    {
        public frmParteneri()
        {
            InitializeComponent();
        }

        private void btnParteneriClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        DataClassesDataContext db = new DataClassesDataContext();

        private void btnAddPartener_Click(object sender, EventArgs e)
        {
            frmAddPartener adaugapartener = new frmAddPartener();
            adaugapartener.ShowDialog();
        }
        public void loadData()
        {
            var date = from a in db.GetTable<Parteneri>() select a;
            dataGridViewParteneri.DataSource = date;
        }

        private void btnUpdatePartener_Click(object sender, EventArgs e)
        {
            frmUpdatePartener modificapartener = new frmUpdatePartener();
            modificapartener.ShowDialog();
        }

        private void frmParteneri_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void btnDeletePartener_Click(object sender, EventArgs e)
        {
            if (dataGridViewParteneri.SelectedRows.Count > 0)
            {
                int rowIndex = dataGridViewParteneri.SelectedCells[0].RowIndex;

                string codPartener = dataGridViewParteneri.Rows[rowIndex].Cells[1].Value.ToString();
                string numePartener = dataGridViewParteneri.Rows[rowIndex].Cells[2].Value.ToString();

                DialogResult result = MessageBox.Show("Doriti sa stergeti partenerul cu urmatoarele detalii?\n\nCod partener: " + codPartener + "\nNume partener: " + numePartener, "Confirmare stergere", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    Parteneri del = db.Parteneris.FirstOrDefault(dell => dell.Cod.Equals(codPartener));
                    if (del != null)
                    {
                        db.Parteneris.DeleteOnSubmit(del);
                        db.SubmitChanges();
                        MessageBox.Show("Partenerul a fost sters cu succes!", "Stergere reusita", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loadData();
                    }
                    else
                    {
                        MessageBox.Show("Partenerul nu a fost gasit în baza de date!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
