namespace Proiect
{
    partial class frmParteneri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmParteneri));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnParteneriClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUpdatePartener = new System.Windows.Forms.Button();
            this.btnDeletePartener = new System.Windows.Forms.Button();
            this.btnAddPartener = new System.Windows.Forms.Button();
            this.dataGridViewParteneri = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewParteneri)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.btnParteneriClose);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1263, 47);
            this.panel1.TabIndex = 1;
            // 
            // btnParteneriClose
            // 
            this.btnParteneriClose.Image = ((System.Drawing.Image)(resources.GetObject("btnParteneriClose.Image")));
            this.btnParteneriClose.Location = new System.Drawing.Point(1219, 4);
            this.btnParteneriClose.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnParteneriClose.Name = "btnParteneriClose";
            this.btnParteneriClose.Size = new System.Drawing.Size(40, 36);
            this.btnParteneriClose.TabIndex = 1;
            this.btnParteneriClose.UseVisualStyleBackColor = true;
            this.btnParteneriClose.Click += new System.EventHandler(this.btnParteneriClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(548, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Parteneri";
            // 
            // btnUpdatePartener
            // 
            this.btnUpdatePartener.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnUpdatePartener.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdatePartener.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdatePartener.Location = new System.Drawing.Point(725, 55);
            this.btnUpdatePartener.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUpdatePartener.Name = "btnUpdatePartener";
            this.btnUpdatePartener.Size = new System.Drawing.Size(104, 65);
            this.btnUpdatePartener.TabIndex = 18;
            this.btnUpdatePartener.Text = "UPDATE";
            this.btnUpdatePartener.UseVisualStyleBackColor = false;
            this.btnUpdatePartener.Click += new System.EventHandler(this.btnUpdatePartener_Click);
            // 
            // btnDeletePartener
            // 
            this.btnDeletePartener.BackColor = System.Drawing.Color.Red;
            this.btnDeletePartener.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeletePartener.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletePartener.Location = new System.Drawing.Point(566, 55);
            this.btnDeletePartener.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDeletePartener.Name = "btnDeletePartener";
            this.btnDeletePartener.Size = new System.Drawing.Size(104, 65);
            this.btnDeletePartener.TabIndex = 17;
            this.btnDeletePartener.Text = "DELETE";
            this.btnDeletePartener.UseVisualStyleBackColor = false;
            this.btnDeletePartener.Click += new System.EventHandler(this.btnDeletePartener_Click);
            // 
            // btnAddPartener
            // 
            this.btnAddPartener.BackColor = System.Drawing.Color.ForestGreen;
            this.btnAddPartener.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddPartener.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPartener.Location = new System.Drawing.Point(405, 55);
            this.btnAddPartener.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddPartener.Name = "btnAddPartener";
            this.btnAddPartener.Size = new System.Drawing.Size(104, 65);
            this.btnAddPartener.TabIndex = 16;
            this.btnAddPartener.Text = "ADD";
            this.btnAddPartener.UseVisualStyleBackColor = false;
            this.btnAddPartener.Click += new System.EventHandler(this.btnAddPartener_Click);
            // 
            // dataGridViewParteneri
            // 
            this.dataGridViewParteneri.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewParteneri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewParteneri.Location = new System.Drawing.Point(13, 145);
            this.dataGridViewParteneri.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewParteneri.Name = "dataGridViewParteneri";
            this.dataGridViewParteneri.ReadOnly = true;
            this.dataGridViewParteneri.RowHeadersWidth = 51;
            this.dataGridViewParteneri.Size = new System.Drawing.Size(1237, 473);
            this.dataGridViewParteneri.TabIndex = 15;
            // 
            // frmParteneri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1263, 631);
            this.Controls.Add(this.btnUpdatePartener);
            this.Controls.Add(this.btnDeletePartener);
            this.Controls.Add(this.btnAddPartener);
            this.Controls.Add(this.dataGridViewParteneri);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmParteneri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Parteneri";
            this.Load += new System.EventHandler(this.frmParteneri_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewParteneri)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnParteneriClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUpdatePartener;
        private System.Windows.Forms.Button btnDeletePartener;
        private System.Windows.Forms.Button btnAddPartener;
        private System.Windows.Forms.DataGridView dataGridViewParteneri;
    }
}