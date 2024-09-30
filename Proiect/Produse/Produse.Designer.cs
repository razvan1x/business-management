namespace Proiect
{
    partial class frmProduse
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProduse));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnProduseClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewProduse = new System.Windows.Forms.DataGridView();
            this.btnAddProdus = new System.Windows.Forms.Button();
            this.btnDeleteProdus = new System.Windows.Forms.Button();
            this.btnUpdateProdus = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProduse)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.btnProduseClose);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1231, 47);
            this.panel1.TabIndex = 0;
            // 
            // btnProduseClose
            // 
            this.btnProduseClose.Image = ((System.Drawing.Image)(resources.GetObject("btnProduseClose.Image")));
            this.btnProduseClose.Location = new System.Drawing.Point(1187, 4);
            this.btnProduseClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnProduseClose.Name = "btnProduseClose";
            this.btnProduseClose.Size = new System.Drawing.Size(40, 36);
            this.btnProduseClose.TabIndex = 1;
            this.btnProduseClose.UseVisualStyleBackColor = true;
            this.btnProduseClose.Click += new System.EventHandler(this.btnProduseClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(548, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Produse";
            // 
            // dataGridViewProduse
            // 
            this.dataGridViewProduse.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewProduse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProduse.Location = new System.Drawing.Point(30, 146);
            this.dataGridViewProduse.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewProduse.Name = "dataGridViewProduse";
            this.dataGridViewProduse.ReadOnly = true;
            this.dataGridViewProduse.RowHeadersWidth = 51;
            this.dataGridViewProduse.Size = new System.Drawing.Size(1171, 472);
            this.dataGridViewProduse.TabIndex = 5;
            // 
            // btnAddProdus
            // 
            this.btnAddProdus.BackColor = System.Drawing.Color.ForestGreen;
            this.btnAddProdus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddProdus.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddProdus.Location = new System.Drawing.Point(384, 55);
            this.btnAddProdus.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddProdus.Name = "btnAddProdus";
            this.btnAddProdus.Size = new System.Drawing.Size(125, 65);
            this.btnAddProdus.TabIndex = 6;
            this.btnAddProdus.Text = "ADD";
            this.btnAddProdus.UseVisualStyleBackColor = false;
            this.btnAddProdus.Click += new System.EventHandler(this.btnAddProdus_Click);
            // 
            // btnDeleteProdus
            // 
            this.btnDeleteProdus.BackColor = System.Drawing.Color.Red;
            this.btnDeleteProdus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteProdus.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteProdus.Location = new System.Drawing.Point(545, 55);
            this.btnDeleteProdus.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteProdus.Name = "btnDeleteProdus";
            this.btnDeleteProdus.Size = new System.Drawing.Size(125, 65);
            this.btnDeleteProdus.TabIndex = 7;
            this.btnDeleteProdus.Text = "DELETE";
            this.btnDeleteProdus.UseVisualStyleBackColor = false;
            this.btnDeleteProdus.Click += new System.EventHandler(this.btnDeleteProdus_Click);
            // 
            // btnUpdateProdus
            // 
            this.btnUpdateProdus.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnUpdateProdus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateProdus.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateProdus.Location = new System.Drawing.Point(704, 55);
            this.btnUpdateProdus.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdateProdus.Name = "btnUpdateProdus";
            this.btnUpdateProdus.Size = new System.Drawing.Size(125, 65);
            this.btnUpdateProdus.TabIndex = 8;
            this.btnUpdateProdus.Text = "UPDATE";
            this.btnUpdateProdus.UseVisualStyleBackColor = false;
            this.btnUpdateProdus.Click += new System.EventHandler(this.btnUpdateProdus_Click);
            // 
            // frmProduse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1231, 631);
            this.Controls.Add(this.btnUpdateProdus);
            this.Controls.Add(this.btnDeleteProdus);
            this.Controls.Add(this.btnAddProdus);
            this.Controls.Add(this.dataGridViewProduse);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmProduse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Produse";
            this.Load += new System.EventHandler(this.frmProduse_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProduse)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnProduseClose;
        private System.Windows.Forms.DataGridView dataGridViewProduse;
        private System.Windows.Forms.Button btnAddProdus;
        private System.Windows.Forms.Button btnDeleteProdus;
        private System.Windows.Forms.Button btnUpdateProdus;
    }
}