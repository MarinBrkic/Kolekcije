namespace kolekcijeFrm
{
    partial class Form1
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
            this.txtMarka = new System.Windows.Forms.TextBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.cmbVrsta = new System.Windows.Forms.ComboBox();
            this.txtIspis = new System.Windows.Forms.TextBox();
            this.btnUnos = new System.Windows.Forms.Button();
            this.btnISpis = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnObrada = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtMarka
            // 
            this.txtMarka.Location = new System.Drawing.Point(122, 62);
            this.txtMarka.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMarka.Name = "txtMarka";
            this.txtMarka.Size = new System.Drawing.Size(136, 26);
            this.txtMarka.TabIndex = 0;
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(122, 98);
            this.txtModel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(136, 26);
            this.txtModel.TabIndex = 1;
            // 
            // cmbVrsta
            // 
            this.cmbVrsta.FormattingEnabled = true;
            this.cmbVrsta.Items.AddRange(new object[] {
            "Avion",
            "Vozilo",
            "Brod"});
            this.cmbVrsta.Location = new System.Drawing.Point(122, 132);
            this.cmbVrsta.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbVrsta.Name = "cmbVrsta";
            this.cmbVrsta.Size = new System.Drawing.Size(136, 28);
            this.cmbVrsta.TabIndex = 2;
            // 
            // txtIspis
            // 
            this.txtIspis.Location = new System.Drawing.Point(264, 62);
            this.txtIspis.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtIspis.Multiline = true;
            this.txtIspis.Name = "txtIspis";
            this.txtIspis.Size = new System.Drawing.Size(910, 250);
            this.txtIspis.TabIndex = 10;
            this.txtIspis.TabStop = false;
            // 
            // btnUnos
            // 
            this.btnUnos.Location = new System.Drawing.Point(122, 186);
            this.btnUnos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnUnos.Name = "btnUnos";
            this.btnUnos.Size = new System.Drawing.Size(136, 60);
            this.btnUnos.TabIndex = 3;
            this.btnUnos.Text = "&Unos";
            this.btnUnos.UseVisualStyleBackColor = true;
            this.btnUnos.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnISpis
            // 
            this.btnISpis.Location = new System.Drawing.Point(122, 254);
            this.btnISpis.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnISpis.Name = "btnISpis";
            this.btnISpis.Size = new System.Drawing.Size(136, 60);
            this.btnISpis.TabIndex = 5;
            this.btnISpis.Text = "&Ispis";
            this.btnISpis.UseVisualStyleBackColor = true;
            this.btnISpis.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Marka:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Model:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Vrsta:";
            // 
            // btnObrada
            // 
            this.btnObrada.Location = new System.Drawing.Point(24, 186);
            this.btnObrada.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnObrada.Name = "btnObrada";
            this.btnObrada.Size = new System.Drawing.Size(91, 126);
            this.btnObrada.TabIndex = 4;
            this.btnObrada.Text = "&Obrada";
            this.btnObrada.UseVisualStyleBackColor = true;
            this.btnObrada.Click += new System.EventHandler(this.btnObrada_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1188, 328);
            this.Controls.Add(this.btnObrada);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnISpis);
            this.Controls.Add(this.btnUnos);
            this.Controls.Add(this.txtIspis);
            this.Controls.Add(this.cmbVrsta);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.txtMarka);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Vježba :: Kolekcije";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMarka;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.ComboBox cmbVrsta;
        private System.Windows.Forms.TextBox txtIspis;
        private System.Windows.Forms.Button btnUnos;
        private System.Windows.Forms.Button btnISpis;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnObrada;
    }
}

