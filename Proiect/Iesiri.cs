using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Proiect
{
    public partial class frmIesiri : Form
    {
        DataClassesDataContext db = new DataClassesDataContext();
        private bool isAddingNew = false;
        public frmIesiri()
        {
            InitializeComponent();
            PopulareComboBox();
            SetupBindingNavigator();
          
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            comboBox3.SelectedIndexChanged += comboBox3_SelectedIndexChanged;
            txtCantitate.TextChanged += txtCantitate_TextChanged;          
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void PopulareComboBox()
        {
            var populatecmbgestiuni = (from x in db.Gestiunis select x).ToList();
            comboBox2.DisplayMember = "Nume";
            comboBox2.ValueMember = "ID";
            comboBox2.DataSource = populatecmbgestiuni;
         
            comboBox3.DisplayMember = "Nume";
            comboBox3.ValueMember = "ID";
            comboBox3.DataSource = new List<Produse>();
        }
        private void FiltrareProdusePeGestiune()
        {
            if (comboBox2.SelectedValue != null)
            {
                int gestiuneId = Convert.ToInt32(comboBox2.SelectedValue);
              
                var produseInGestiune = (from detaliu in db.Intrari_detalius
                                         join intrare in db.Intraris on detaliu.ID_Intrari equals intrare.ID
                                         where intrare.Gestiune == gestiuneId
                                         select detaliu.Produs).Distinct().ToList();

                var produse = (from produs in db.Produses
                               where produseInGestiune.Contains(produs.ID)
                               select produs).ToList();

                comboBox3.DataSource = produse;
            }
        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            FiltrareProdusePeGestiune();
        }
        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            calculareValoare();
        }
        private void txtCantitate_TextChanged(object sender, EventArgs e)
        {
            calculareValoare();
        }
        void loadData()
        {
            var st = from s in db.Iesiris select s;
            var ds = from s in db.Iesiri_detalius select s;

            bindingSource1.DataSource = st.ToList();
            dataGridView1.DataSource = bindingSource1;
        }

        private void frmIesiri_Load(object sender, EventArgs e)
        {
            loadData();
        }
        private void SetupBindingNavigator()
        {
            bindingNavigatorAddNewItem.Click -= bindingNavigatorAddNewItem_Click;
            bindingNavigatorAddNewItem.Click += bindingNavigatorAddNewItem_Click;

            bindingNavigator1.BindingSource = bindingSource1;
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            ClearFields();
            isAddingNew = true;
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (isAddingNew)
            {
                decimal nextNumar = db.Iesiris.Any() ? (db.Iesiris.Max(i => (decimal?)i.Numar) ?? 0) + 1 : 1;

                DateTime data = DateTime.Now; 
                int gestiuneId = Convert.ToInt32(comboBox2.SelectedValue);

                var iesire = new Iesiri
                {
                    Numar = nextNumar,
                    Data = data,
                    Gestiune = gestiuneId,
                };

                db.Iesiris.InsertOnSubmit(iesire);
                db.SubmitChanges();

                int iesireId = (int)iesire.ID;
                int produsId = Convert.ToInt32(comboBox3.SelectedValue);
                decimal cantitateProdus = decimal.Parse(txtCantitate.Text);
                decimal valoare = decimal.Parse(txtValoare.Text);

                var iesireDetaliu = new Iesiri_detaliu
                {
                    ID_Iesiri = iesireId,
                    Produs = produsId,
                    Cantitate = cantitateProdus,
                    Valoare = valoare
                };

                db.Iesiri_detalius.InsertOnSubmit(iesireDetaliu);
                db.SubmitChanges();

                MessageBox.Show("Datele au fost salvate cu succes!");
                loadData();
                isAddingNew = false;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (isAddingNew)
            {
                DialogResult result = MessageBox.Show("Sunteți sigur că doriți să renunțați la modificări?",
                                                      "Confirmare renunțare",
                                                      MessageBoxButtons.YesNo,
                                                      MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    isAddingNew = false;
                    loadData();
                }
            }
        }
        private void ClearFields()
        {
            comboBox2.SelectedIndex = -1;
            comboBox3.SelectedIndex = -1;
            txtCantitate.Clear();
            txtValoare.Clear();
        }

        private void toolStripButtonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                int idIesire = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value); 

                var iesire = db.Iesiris.FirstOrDefault(i => i.ID == idIesire);
                var iesiriDetalii = db.Iesiri_detalius.Where(d => d.ID_Iesiri == idIesire).ToList();

                if (iesire != null)
                {
                    string detaliiIdList = string.Join(", ", iesiriDetalii.Select(d => d.ID));
                    string message = $"Doriti sa stergeti inregistrarea cu urmatoarele detalii?\n" +
                                     $"ID Iesire: {idIesire}\n" +
                                     $"Numar Iesire: {iesire.Numar}\n" +
                                     $"ID-uri Iesiri in detaliu: {detaliiIdList}";

                    DialogResult result = MessageBox.Show(message, "Confirmare stergere", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        db.Iesiri_detalius.DeleteAllOnSubmit(iesiriDetalii);
                        db.Iesiris.DeleteOnSubmit(iesire);

                        db.SubmitChanges();

                        MessageBox.Show("Inregistrarea a fost stearsa cu succes!");
                        loadData();
                    }
                }
            }
        }
    }
}
