namespace Proiect
{
    partial class frmGestiuni
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGestiuni));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnGestiuniClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUpdateGestiune = new System.Windows.Forms.Button();
            this.btnDeleteGestiune = new System.Windows.Forms.Button();
            this.btnAddGestiune = new System.Windows.Forms.Button();
            this.dataGridViewGestiuni = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGestiuni)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.btnGestiuniClose);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1231, 47);
            this.panel1.TabIndex = 1;
            // 
            // btnGestiuniClose
            // 
            this.btnGestiuniClose.Image = ((System.Drawing.Image)(resources.GetObject("btnGestiuniClose.Image")));
            this.btnGestiuniClose.Location = new System.Drawing.Point(1187, 4);
            this.btnGestiuniClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnGestiuniClose.Name = "btnGestiuniClose";
            this.btnGestiuniClose.Size = new System.Drawing.Size(40, 36);
            this.btnGestiuniClose.TabIndex = 1;
            this.btnGestiuniClose.UseVisualStyleBackColor = true;
            this.btnGestiuniClose.Click += new System.EventHandler(this.btnGestiuniClose_Click);
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
            this.label1.Text = "Gestiuni";
            // 
            // btnUpdateGestiune
            // 
            this.btnUpdateGestiune.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnUpdateGestiune.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateGestiune.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateGestiune.Location = new System.Drawing.Point(714, 55);
            this.btnUpdateGestiune.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdateGestiune.Name = "btnUpdateGestiune";
            this.btnUpdateGestiune.Size = new System.Drawing.Size(125, 65);
            this.btnUpdateGestiune.TabIndex = 18;
            this.btnUpdateGestiune.Text = "UPDATE";
            this.btnUpdateGestiune.UseVisualStyleBackColor = false;
            this.btnUpdateGestiune.Click += new System.EventHandler(this.btnUpdateGestiune_Click);
            // 
            // btnDeleteGestiune
            // 
            this.btnDeleteGestiune.BackColor = System.Drawing.Color.Red;
            this.btnDeleteGestiune.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteGestiune.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteGestiune.Location = new System.Drawing.Point(555, 55);
            this.btnDeleteGestiune.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteGestiune.Name = "btnDeleteGestiune";
            this.btnDeleteGestiune.Size = new System.Drawing.Size(125, 65);
            this.btnDeleteGestiune.TabIndex = 17;
            this.btnDeleteGestiune.Text = "DELETE";
            this.btnDeleteGestiune.UseVisualStyleBackColor = false;
            this.btnDeleteGestiune.Click += new System.EventHandler(this.btnDeleteGestiune_Click);
            // 
            // btnAddGestiune
            // 
            this.btnAddGestiune.BackColor = System.Drawing.Color.ForestGreen;
            this.btnAddGestiune.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddGestiune.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddGestiune.Location = new System.Drawing.Point(394, 55);
            this.btnAddGestiune.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddGestiune.Name = "btnAddGestiune";
            this.btnAddGestiune.Size = new System.Drawing.Size(125, 65);
            this.btnAddGestiune.TabIndex = 16;
            this.btnAddGestiune.Text = "ADD";
            this.btnAddGestiune.UseVisualStyleBackColor = false;
            this.btnAddGestiune.Click += new System.EventHandler(this.btnAddGestiune_Click);
            // 
            // dataGridViewGestiuni
            // 
            this.dataGridViewGestiuni.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewGestiuni.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewGestiuni.Location = new System.Drawing.Point(13, 130);
            this.dataGridViewGestiuni.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewGestiuni.Name = "dataGridViewGestiuni";
            this.dataGridViewGestiuni.ReadOnly = true;
            this.dataGridViewGestiuni.RowHeadersWidth = 51;
            this.dataGridViewGestiuni.Size = new System.Drawing.Size(1205, 488);
            this.dataGridViewGestiuni.TabIndex = 15;
            // 
            // frmGestiuni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1231, 631);
            this.Controls.Add(this.btnUpdateGestiune);
            this.Controls.Add(this.btnDeleteGestiune);
            this.Controls.Add(this.btnAddGestiune);
            this.Controls.Add(this.dataGridViewGestiuni);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmGestiuni";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestiuni";
            this.Load += new System.EventHandler(this.frmGestiuni_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGestiuni)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnGestiuniClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUpdateGestiune;
        private System.Windows.Forms.Button btnDeleteGestiune;
        private System.Windows.Forms.Button btnAddGestiune;
        private System.Windows.Forms.DataGridView dataGridViewGestiuni;
    }
}