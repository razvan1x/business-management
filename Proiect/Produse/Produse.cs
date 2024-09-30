using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;


namespace Proiect
{
    public partial class frmProduse : Form
    {
        public frmProduse()
        {
            InitializeComponent();
        }
        DataClassesDataContext db = new DataClassesDataContext();
        private void btnAddProdus_Click(object sender, EventArgs e)
        {
            frmAddProdus adaugaprodus = new frmAddProdus();
            adaugaprodus.ShowDialog();
        }
        private void btnProduseClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnUpdateProdus_Click(object sender, EventArgs e)
        {
            frmUpdateProdus modificareProdus = new frmUpdateProdus();
            modificareProdus.ShowDialog();
        }
        private void frmProduse_Load(object sender, EventArgs e)
        {
            loadData();
        }
        public void loadData()
        {
            var date = from a in db.GetTable<Produse>() select a;
            dataGridViewProduse.DataSource = date;
        }
        private void btnDeleteProdus_Click(object sender, EventArgs e)
        {
            if (dataGridViewProduse.SelectedRows.Count > 0)
            {
                int rowIndex = dataGridViewProduse.SelectedCells[0].RowIndex;

                string codProdus = dataGridViewProduse.Rows[rowIndex].Cells[1].Value.ToString(); 
                string numeProdus = dataGridViewProduse.Rows[rowIndex].Cells[2].Value.ToString(); 

                DialogResult result = MessageBox.Show("Doriti sa stergeti produsul cu urmatoarele detalii?\n\nCod produs: " + codProdus + "\nNume produs: " + numeProdus, "Confirmare stergere", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    Produse del = db.Produses.FirstOrDefault(dell => dell.Cod.Equals(codProdus));
                    if (del != null)
                    {
                        db.Produses.DeleteOnSubmit(del);
                        db.SubmitChanges();
                        MessageBox.Show("Produsul a fost sters cu succes!", "Stergere reusita", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loadData();
                    }
                    else
                    {
                        MessageBox.Show("Produsul nu a fost gasit în baza de date!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
