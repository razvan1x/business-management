namespace Proiect
{
    partial class frmUpdateGestiune
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
            this.button1 = new System.Windows.Forms.Button();
            this.txtCodGestiune = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSaveGestiune = new System.Windows.Forms.Button();
            this.txtNumeGestiune = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(269, 181);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 45);
            this.button1.TabIndex = 25;
            this.button1.Text = "Renunta";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtCodGestiune
            // 
            this.txtCodGestiune.Location = new System.Drawing.Point(166, 46);
            this.txtCodGestiune.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodGestiune.Name = "txtCodGestiune";
            this.txtCodGestiune.Size = new System.Drawing.Size(260, 22);
            this.txtCodGestiune.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 36);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 32);
            this.label2.TabIndex = 23;
            this.label2.Text = "Cod";
            // 
            // btnSaveGestiune
            // 
            this.btnSaveGestiune.BackColor = System.Drawing.Color.ForestGreen;
            this.btnSaveGestiune.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveGestiune.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveGestiune.Location = new System.Drawing.Point(40, 181);
            this.btnSaveGestiune.Margin = new System.Windows.Forms.Padding(4);
            this.btnSaveGestiune.Name = "btnSaveGestiune";
            this.btnSaveGestiune.Size = new System.Drawing.Size(157, 45);
            this.btnSaveGestiune.TabIndex = 22;
            this.btnSaveGestiune.Text = "Salvare";
            this.btnSaveGestiune.UseVisualStyleBackColor = false;
            this.btnSaveGestiune.Click += new System.EventHandler(this.btnSaveGestiune_Click);
            // 
            // txtNumeGestiune
            // 
            this.txtNumeGestiune.Location = new System.Drawing.Point(166, 104);
            this.txtNumeGestiune.Margin = new System.Windows.Forms.Padding(4);
            this.txtNumeGestiune.Name = "txtNumeGestiune";
            this.txtNumeGestiune.Size = new System.Drawing.Size(260, 22);
            this.txtNumeGestiune.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 94);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 32);
            this.label1.TabIndex = 26;
            this.label1.Text = "Gestiune";
            // 
            // frmUpdateGestiune
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(472, 259);
            this.Controls.Add(this.txtNumeGestiune);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtCodGestiune);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSaveGestiune);
            this.Name = "frmUpdateGestiune";
            this.Text = "ModificareGestiune";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtCodGestiune;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSaveGestiune;
        private System.Windows.Forms.TextBox txtNumeGestiune;
        private System.Windows.Forms.Label label1;
    }
}