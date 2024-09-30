namespace Proiect
{
    partial class frmAddProdus
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
            this.btnSaveProdus = new System.Windows.Forms.Button();
            this.txtPretProdus = new System.Windows.Forms.TextBox();
            this.txtNumeProdus = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSaveProdus
            // 
            this.btnSaveProdus.BackColor = System.Drawing.Color.ForestGreen;
            this.btnSaveProdus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveProdus.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveProdus.Location = new System.Drawing.Point(19, 187);
            this.btnSaveProdus.Margin = new System.Windows.Forms.Padding(4);
            this.btnSaveProdus.Name = "btnSaveProdus";
            this.btnSaveProdus.Size = new System.Drawing.Size(157, 45);
            this.btnSaveProdus.TabIndex = 7;
            this.btnSaveProdus.Text = "Salvare";
            this.btnSaveProdus.UseVisualStyleBackColor = false;
            this.btnSaveProdus.Click += new System.EventHandler(this.btnSaveProdus_Click);
            // 
            // txtPretProdus
            // 
            this.txtPretProdus.Location = new System.Drawing.Point(143, 109);
            this.txtPretProdus.Margin = new System.Windows.Forms.Padding(4);
            this.txtPretProdus.Name = "txtPretProdus";
            this.txtPretProdus.Size = new System.Drawing.Size(260, 22);
            this.txtPretProdus.TabIndex = 14;
            // 
            // txtNumeProdus
            // 
            this.txtNumeProdus.Location = new System.Drawing.Point(145, 33);
            this.txtNumeProdus.Margin = new System.Windows.Forms.Padding(4);
            this.txtNumeProdus.Name = "txtNumeProdus";
            this.txtNumeProdus.Size = new System.Drawing.Size(260, 22);
            this.txtNumeProdus.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 101);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 32);
            this.label3.TabIndex = 12;
            this.label3.Text = "Pret";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 23);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 32);
            this.label2.TabIndex = 11;
            this.label2.Text = "Produs";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(246, 187);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 45);
            this.button1.TabIndex = 15;
            this.button1.Text = "Renunta";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmAddProdus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(428, 250);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtPretProdus);
            this.Controls.Add(this.txtNumeProdus);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSaveProdus);
            this.Name = "frmAddProdus";
            this.Text = "AdaugareProdus";
            this.Load += new System.EventHandler(this.frmAddProdus_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSaveProdus;
        private System.Windows.Forms.TextBox txtPretProdus;
        private System.Windows.Forms.TextBox txtNumeProdus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}