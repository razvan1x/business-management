namespace Proiect
{
    partial class frmUpdateProdus
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
            this.txtPretProdus = new System.Windows.Forms.TextBox();
            this.txtNumeProdus = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSalvareProdus = new System.Windows.Forms.Button();
            this.txtCodProdus = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(251, 185);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 45);
            this.button1.TabIndex = 21;
            this.button1.Text = "Renunta";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtPretProdus
            // 
            this.txtPretProdus.Location = new System.Drawing.Point(148, 107);
            this.txtPretProdus.Margin = new System.Windows.Forms.Padding(4);
            this.txtPretProdus.Name = "txtPretProdus";
            this.txtPretProdus.Size = new System.Drawing.Size(260, 22);
            this.txtPretProdus.TabIndex = 20;
            // 
            // txtNumeProdus
            // 
            this.txtNumeProdus.Location = new System.Drawing.Point(148, 63);
            this.txtNumeProdus.Margin = new System.Windows.Forms.Padding(4);
            this.txtNumeProdus.Name = "txtNumeProdus";
            this.txtNumeProdus.Size = new System.Drawing.Size(260, 22);
            this.txtNumeProdus.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 99);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 32);
            this.label3.TabIndex = 18;
            this.label3.Text = "Pret";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 53);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 32);
            this.label2.TabIndex = 17;
            this.label2.Text = "Produs";
            // 
            // btnSalvareProdus
            // 
            this.btnSalvareProdus.BackColor = System.Drawing.Color.ForestGreen;
            this.btnSalvareProdus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvareProdus.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvareProdus.Location = new System.Drawing.Point(24, 185);
            this.btnSalvareProdus.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalvareProdus.Name = "btnSalvareProdus";
            this.btnSalvareProdus.Size = new System.Drawing.Size(157, 45);
            this.btnSalvareProdus.TabIndex = 16;
            this.btnSalvareProdus.Text = "Salvare";
            this.btnSalvareProdus.UseVisualStyleBackColor = false;
            this.btnSalvareProdus.Click += new System.EventHandler(this.btnSalvareProdus_Click);
            // 
            // txtCodProdus
            // 
            this.txtCodProdus.Location = new System.Drawing.Point(148, 22);
            this.txtCodProdus.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodProdus.Name = "txtCodProdus";
            this.txtCodProdus.Size = new System.Drawing.Size(260, 22);
            this.txtCodProdus.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 32);
            this.label1.TabIndex = 22;
            this.label1.Text = "Cod";
            // 
            // frmUpdateProdus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(428, 250);
            this.Controls.Add(this.txtCodProdus);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtPretProdus);
            this.Controls.Add(this.txtNumeProdus);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSalvareProdus);
            this.Name = "frmUpdateProdus";
            this.Text = "ModificareProdus";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtPretProdus;
        private System.Windows.Forms.TextBox txtNumeProdus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSalvareProdus;
        private System.Windows.Forms.TextBox txtCodProdus;
        private System.Windows.Forms.Label label1;
    }
}