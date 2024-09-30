namespace Proiect
{
    partial class frmAddPartener
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
            this.label6 = new System.Windows.Forms.Label();
            this.comboTipPartener = new System.Windows.Forms.ComboBox();
            this.txtAdresaPartener = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCuiPartener = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNumePartener = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSavePartener = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(18, 122);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 32);
            this.label6.TabIndex = 36;
            this.label6.Text = "Tip";
            // 
            // comboTipPartener
            // 
            this.comboTipPartener.FormattingEnabled = true;
            this.comboTipPartener.Items.AddRange(new object[] {
            "Client",
            "Furnizor"});
            this.comboTipPartener.Location = new System.Drawing.Point(147, 127);
            this.comboTipPartener.Margin = new System.Windows.Forms.Padding(4);
            this.comboTipPartener.Name = "comboTipPartener";
            this.comboTipPartener.Size = new System.Drawing.Size(260, 24);
            this.comboTipPartener.TabIndex = 35;
            // 
            // txtAdresaPartener
            // 
            this.txtAdresaPartener.Location = new System.Drawing.Point(147, 182);
            this.txtAdresaPartener.Margin = new System.Windows.Forms.Padding(4);
            this.txtAdresaPartener.Multiline = true;
            this.txtAdresaPartener.Name = "txtAdresaPartener";
            this.txtAdresaPartener.Size = new System.Drawing.Size(260, 100);
            this.txtAdresaPartener.TabIndex = 34;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(18, 177);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 32);
            this.label5.TabIndex = 33;
            this.label5.Text = "Adresa";
            // 
            // txtCuiPartener
            // 
            this.txtCuiPartener.Location = new System.Drawing.Point(147, 72);
            this.txtCuiPartener.Margin = new System.Windows.Forms.Padding(4);
            this.txtCuiPartener.Name = "txtCuiPartener";
            this.txtCuiPartener.Size = new System.Drawing.Size(260, 22);
            this.txtCuiPartener.TabIndex = 32;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 67);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 32);
            this.label3.TabIndex = 31;
            this.label3.Text = "CUI";
            // 
            // txtNumePartener
            // 
            this.txtNumePartener.Location = new System.Drawing.Point(147, 22);
            this.txtNumePartener.Margin = new System.Windows.Forms.Padding(4);
            this.txtNumePartener.Name = "txtNumePartener";
            this.txtNumePartener.Size = new System.Drawing.Size(260, 22);
            this.txtNumePartener.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 18);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 32);
            this.label2.TabIndex = 27;
            this.label2.Text = "Partener";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(250, 301);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 46);
            this.button1.TabIndex = 38;
            this.button1.Text = "Renunta";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSavePartener
            // 
            this.btnSavePartener.BackColor = System.Drawing.Color.ForestGreen;
            this.btnSavePartener.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSavePartener.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSavePartener.Location = new System.Drawing.Point(24, 301);
            this.btnSavePartener.Margin = new System.Windows.Forms.Padding(4);
            this.btnSavePartener.Name = "btnSavePartener";
            this.btnSavePartener.Size = new System.Drawing.Size(157, 46);
            this.btnSavePartener.TabIndex = 37;
            this.btnSavePartener.Text = "Salvare";
            this.btnSavePartener.UseVisualStyleBackColor = false;
            this.btnSavePartener.Click += new System.EventHandler(this.btnSavePartener_Click);
            // 
            // frmAddPartener
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(427, 367);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSavePartener);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboTipPartener);
            this.Controls.Add(this.txtAdresaPartener);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtCuiPartener);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNumePartener);
            this.Controls.Add(this.label2);
            this.Name = "frmAddPartener";
            this.Text = "AdaugarePartener";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboTipPartener;
        private System.Windows.Forms.TextBox txtAdresaPartener;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCuiPartener;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNumePartener;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnSavePartener;
    }
}