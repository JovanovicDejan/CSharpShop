namespace OnlineShop
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtOperativniSistem = new System.Windows.Forms.TextBox();
            this.txtNacinUnosa = new System.Windows.Forms.TextBox();
            this.txtRam = new System.Windows.Forms.TextBox();
            this.txtProcesor = new System.Windows.Forms.TextBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.txtMarka = new System.Windows.Forms.TextBox();
            this.txtCena = new System.Windows.Forms.TextBox();
            this.txtNapajanje = new System.Windows.Forms.TextBox();
            this.txtKuciste = new System.Windows.Forms.TextBox();
            this.btnSacuvaj = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnSaveJson = new System.Windows.Forms.Button();
            this.sacuvajJson = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(141, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 16);
            this.label1.TabIndex = 19;
            this.label1.Text = "Cena :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(141, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 16);
            this.label2.TabIndex = 18;
            this.label2.Text = "Marka :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(141, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 16);
            this.label3.TabIndex = 17;
            this.label3.Text = "Model :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(141, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 16);
            this.label4.TabIndex = 16;
            this.label4.Text = "Procesor :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(141, 211);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 16);
            this.label5.TabIndex = 15;
            this.label5.Text = "Ram :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(141, 249);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 16);
            this.label6.TabIndex = 14;
            this.label6.Text = "Operativni sistem :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(141, 289);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 16);
            this.label7.TabIndex = 13;
            this.label7.Text = "Nacin unosa :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(141, 328);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 16);
            this.label8.TabIndex = 12;
            this.label8.Text = "Napajanje :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(141, 365);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 16);
            this.label9.TabIndex = 11;
            this.label9.Text = "Kuciste :";
            // 
            // txtOperativniSistem
            // 
            this.txtOperativniSistem.Location = new System.Drawing.Point(264, 249);
            this.txtOperativniSistem.Name = "txtOperativniSistem";
            this.txtOperativniSistem.Size = new System.Drawing.Size(100, 22);
            this.txtOperativniSistem.TabIndex = 5;
            // 
            // txtNacinUnosa
            // 
            this.txtNacinUnosa.Location = new System.Drawing.Point(264, 289);
            this.txtNacinUnosa.Name = "txtNacinUnosa";
            this.txtNacinUnosa.Size = new System.Drawing.Size(100, 22);
            this.txtNacinUnosa.TabIndex = 6;
            // 
            // txtRam
            // 
            this.txtRam.Location = new System.Drawing.Point(264, 205);
            this.txtRam.Name = "txtRam";
            this.txtRam.Size = new System.Drawing.Size(100, 22);
            this.txtRam.TabIndex = 4;
            // 
            // txtProcesor
            // 
            this.txtProcesor.Location = new System.Drawing.Point(264, 164);
            this.txtProcesor.Name = "txtProcesor";
            this.txtProcesor.Size = new System.Drawing.Size(100, 22);
            this.txtProcesor.TabIndex = 3;
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(264, 131);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(100, 22);
            this.txtModel.TabIndex = 2;
            // 
            // txtMarka
            // 
            this.txtMarka.Location = new System.Drawing.Point(264, 97);
            this.txtMarka.Name = "txtMarka";
            this.txtMarka.Size = new System.Drawing.Size(100, 22);
            this.txtMarka.TabIndex = 1;
            // 
            // txtCena
            // 
            this.txtCena.Location = new System.Drawing.Point(264, 64);
            this.txtCena.Name = "txtCena";
            this.txtCena.Size = new System.Drawing.Size(100, 22);
            this.txtCena.TabIndex = 0;
            // 
            // txtNapajanje
            // 
            this.txtNapajanje.Location = new System.Drawing.Point(264, 328);
            this.txtNapajanje.Name = "txtNapajanje";
            this.txtNapajanje.Size = new System.Drawing.Size(100, 22);
            this.txtNapajanje.TabIndex = 7;
            // 
            // txtKuciste
            // 
            this.txtKuciste.Location = new System.Drawing.Point(264, 365);
            this.txtKuciste.Name = "txtKuciste";
            this.txtKuciste.Size = new System.Drawing.Size(100, 22);
            this.txtKuciste.TabIndex = 8;
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.Location = new System.Drawing.Point(62, 433);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(220, 49);
            this.btnSacuvaj.TabIndex = 10;
            this.btnSacuvaj.Text = "Dodaj na listu";
            this.btnSacuvaj.UseVisualStyleBackColor = true;
            this.btnSacuvaj.Click += new System.EventHandler(this.btnSacuvaj_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(0, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 16);
            this.label10.TabIndex = 21;
            this.label10.Text = "label10";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(120, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(309, 31);
            this.label11.TabIndex = 20;
            this.label11.Text = "Dodaj novi desktop racunar";
            // 
            // btnSaveJson
            // 
            this.btnSaveJson.Location = new System.Drawing.Point(303, 433);
            this.btnSaveJson.Name = "btnSaveJson";
            this.btnSaveJson.Size = new System.Drawing.Size(220, 49);
            this.btnSaveJson.TabIndex = 9;
            this.btnSaveJson.Text = "Sacuvaj JSON";
            this.btnSaveJson.UseVisualStyleBackColor = true;
            this.btnSaveJson.Click += new System.EventHandler(this.btnSaveJson_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 519);
            this.Controls.Add(this.btnSaveJson);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnSacuvaj);
            this.Controls.Add(this.txtKuciste);
            this.Controls.Add(this.txtNapajanje);
            this.Controls.Add(this.txtCena);
            this.Controls.Add(this.txtMarka);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.txtProcesor);
            this.Controls.Add(this.txtRam);
            this.Controls.Add(this.txtNacinUnosa);
            this.Controls.Add(this.txtOperativniSistem);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtOperativniSistem;
        private System.Windows.Forms.TextBox txtNacinUnosa;
        private System.Windows.Forms.TextBox txtRam;
        private System.Windows.Forms.TextBox txtProcesor;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.TextBox txtMarka;
        private System.Windows.Forms.TextBox txtCena;
        private System.Windows.Forms.TextBox txtNapajanje;
        private System.Windows.Forms.TextBox txtKuciste;
        private System.Windows.Forms.Button btnSacuvaj;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnSaveJson;
        private System.Windows.Forms.SaveFileDialog sacuvajJson;
    }
}

