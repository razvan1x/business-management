using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.Linq;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect
{
    public partial class frmIntrari : Form
    {
        DataClassesDataContext db = new DataClassesDataContext();
        private bool isAddingNew = false;

        public frmIntrari()
        {
            InitializeComponent();
            PopulareComboBox();
            SetupBindingNavigator();

            comboBox3.SelectedIndexChanged += comboBox3_SelectedIndexChanged;
            txtCantitate.TextChanged += txtCantitate_TextChanged;
            dataGridView1.CurrentCellDirtyStateChanged += dataGridView1_CurrentCellDirtyStateChanged;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;

            toolStripButton2.Click += toolStripButton2_Click;
        }
        private void dataGridView1_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dataGridView1.IsCurrentCellDirty)
            {
                dataGridView1.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }
        private void PopulareComboBox()
        {
            var populatecmbparteneri = (from x in db.Parteneris select x).ToList();
            comboBox1.DisplayMember = "Nume";  
            comboBox1.ValueMember = "ID";      
            comboBox1.DataSource = populatecmbparteneri;

            var populatecmbgestiuni = (from x in db.Gestiunis select x).ToList();
            comboBox2.DisplayMember = "Nume";  
            comboBox2.ValueMember = "ID";      
            comboBox2.DataSource = populatecmbgestiuni;

            var populatecmbproduse = (from x in db.Produses select x).ToList();
            comboBox3.DisplayMember = "Nume";
            comboBox3.ValueMember = "ID";
            comboBox3.DataSource = populatecmbproduse;
        }
        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            calculareValoare();
        }

        private void txtCantitate_TextChanged(object sender, EventArgs e)
        {
            calculareValoare();
        }

        private void calculareValoare()
        {
            if (comboBox3.SelectedValue != null && decimal.TryParse(txtCantitate.Text, out decimal cantitate))
            {
                int produsId = Convert.ToInt32(comboBox3.SelectedValue);
                var produs = db.Produses.FirstOrDefault(p => p.ID == produsId);
                if (produs != null)
                {
                    decimal pret = produs.Pret ?? 0; 
                    decimal valoare = pret * cantitate;
                    txtValoare.Text = valoare.ToString("0.00");
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void frmIntrari_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'intrari_detaliuDataSet.Intrari_detaliu' table. You can move, or remove it, as needed.
            this.intrari_detaliuTableAdapter.Fill(this.intrari_detaliuDataSet.Intrari_detaliu);
            loadData();

            btnSave.Click += btnSave_Click;
            btnCancel.Click += btnCancel_Click;
        }
        void loadData()
        {
            var st = from s in db.Intraris select s;
            var ds = from s in db.Intrari_detalius select s;

            intraridetaliuBindingSource.DataSource = ds.ToList();
            dataGridView1.DataSource = intraridetaliuBindingSource;
        }
        private void SetupBindingNavigator()
        {
            bindingNavigator1.BindingSource = intraridetaliuBindingSource;

            bindingNavigatorAddNewItem.Click -= bindingNavigatorAddNewItem_Click;
            bindingNavigatorAddNewItem.Click += bindingNavigatorAddNewItem_Click;
        }
        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            ClearFields();
            isAddingNew = true;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (isAddingNew)
            {
                decimal nextNumar = db.Intraris.Any() ? db.Intraris.Max(i => i.Numar) + 1 : 1;

                DateTime data = dateTimePicker1.Value;
                int partenerId = Convert.ToInt32(comboBox1.SelectedValue);
                int gestiuneId = Convert.ToInt32(comboBox2.SelectedValue);

                var st = new Intrari
                {
                    Numar = nextNumar,
                    Data = data,
                    Partener = partenerId,
                    Gestiune = gestiuneId,
                };

                db.Intraris.InsertOnSubmit(st);
                db.SubmitChanges();

                int intrariId = (int)st.ID;
                int produsId = Convert.ToInt32(comboBox3.SelectedValue);
                decimal cantitateProdus = decimal.Parse(txtCantitate.Text);
                decimal valoare = decimal.Parse(txtValoare.Text);


                var ds = new Intrari_detaliu
                {
                    ID_Intrari = intrariId,
                    Produs = produsId,
                    Cantitate = cantitateProdus,
                    Valoare = valoare
                };
               
                db.Intrari_detalius.InsertOnSubmit(ds);
                db.SubmitChanges();

                MessageBox.Show("Datele au fost salvate cu succes!");
                loadData();
                isAddingNew = false;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Doriti sa renuntati la modificari?", "Confirmare renuntare", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                if (isAddingNew)
                {
                    isAddingNew = false;
                    loadData();
                }
            }
        }
        private void ClearFields()
        {
            dateTimePicker1.Value = DateTime.Now;
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
            comboBox3.SelectedIndex = -1;
            txtCantitate.Clear();
            txtValoare.Clear();
        }
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                int idDetaliu = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                int idIntrari = Convert.ToInt32(dataGridView1.CurrentRow.Cells[1].Value);

                var detaliu = db.Intrari_detalius.FirstOrDefault(d => d.ID == idDetaliu);
                var intrari = db.Intraris.FirstOrDefault(i => i.ID == idIntrari);

                if (detaliu != null && intrari != null)
                {
                    string message = $"Doriti sa stergeti inregistrarea cu urmatoarele detalii?\n" +
                             $"ID Intrare: {idIntrari}\n" +
                             $"Numar Intrare: {intrari.Numar}\n" +
                             $"ID Detaliu: {idDetaliu}";                                                    

                    DialogResult result = MessageBox.Show(message, "Confirmare stergere", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        db.Intrari_detalius.DeleteOnSubmit(detaliu);
                        db.Intraris.DeleteOnSubmit(intrari);

                        db.SubmitChanges();

                        MessageBox.Show("Inregistrarea a fost stearsa cu succes!");
                        loadData();
                    }
                }
            }
        }
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                int idDetaliu = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                int idIntrari = Convert.ToInt32(dataGridView1.CurrentRow.Cells[1].Value);

                var detaliu = db.Intrari_detalius.FirstOrDefault(d => d.ID == idDetaliu);
                var intrari = db.Intraris.FirstOrDefault(i => i.ID == idIntrari);

                if (detaliu != null && intrari != null)
                {
                    comboBox1.SelectedValue = intrari.Partener;
                    comboBox2.SelectedValue = intrari.Gestiune;
                    comboBox3.SelectedValue = detaliu.Produs;
                    txtCantitate.Text = detaliu.Cantitate.ToString();
                }
            }
        }
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                int idDetaliu = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                int idIntrari = Convert.ToInt32(dataGridView1.CurrentRow.Cells[1].Value);

                var detaliu = db.Intrari_detalius.FirstOrDefault(d => d.ID == idDetaliu);
                var intrari = db.Intraris.FirstOrDefault(i => i.ID == idIntrari);

                if (detaliu != null && intrari != null)
                {
                    intrari.Partener = Convert.ToInt32(comboBox1.SelectedValue);
                    intrari.Gestiune = Convert.ToInt32(comboBox2.SelectedValue);
                    intrari.Data = DateTime.Now;
                    detaliu.Produs = Convert.ToInt32(comboBox3.SelectedValue);
                    detaliu.Cantitate = decimal.Parse(txtCantitate.Text);

                    var produs = db.Produses.FirstOrDefault(p => p.ID == detaliu.Produs);
                    if (produs != null)
                    {
                        decimal pret = produs.Pret ?? 0;
                        detaliu.Valoare = pret * detaliu.Cantitate;
                    }

                    db.SubmitChanges();

                    MessageBox.Show("Modificarile au fost salvate cu succes!");
                    loadData();
                }
            }
        }
    }
}
