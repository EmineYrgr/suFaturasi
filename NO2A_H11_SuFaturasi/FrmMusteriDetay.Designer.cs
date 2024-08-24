namespace NO2A_H11_SuFaturasi
{
    partial class FrmMusteriDetay
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
            this.txtTCKN = new System.Windows.Forms.MaskedTextBox();
            this.txtAdSoyad = new System.Windows.Forms.TextBox();
            this.txtSayacNo = new System.Windows.Forms.MaskedTextBox();
            this.txtCepTelefonu = new System.Windows.Forms.MaskedTextBox();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.comboIl = new System.Windows.Forms.ComboBox();
            this.comboIlce = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnKapat = new System.Windows.Forms.Button();
            this.btnKaydetGuncelle = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.radioBahce = new System.Windows.Forms.RadioButton();
            this.radioMesken = new System.Windows.Forms.RadioButton();
            this.radioTicari = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // txtTCKN
            // 
            this.txtTCKN.Location = new System.Drawing.Point(118, 45);
            this.txtTCKN.Mask = "00000000000";
            this.txtTCKN.Name = "txtTCKN";
            this.txtTCKN.Size = new System.Drawing.Size(179, 22);
            this.txtTCKN.TabIndex = 0;
            this.txtTCKN.ValidatingType = typeof(int);
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.Location = new System.Drawing.Point(118, 78);
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.Size = new System.Drawing.Size(179, 22);
            this.txtAdSoyad.TabIndex = 1;
            // 
            // txtSayacNo
            // 
            this.txtSayacNo.Location = new System.Drawing.Point(118, 111);
            this.txtSayacNo.Mask = "00000";
            this.txtSayacNo.Name = "txtSayacNo";
            this.txtSayacNo.Size = new System.Drawing.Size(179, 22);
            this.txtSayacNo.TabIndex = 2;
            this.txtSayacNo.ValidatingType = typeof(int);
            // 
            // txtCepTelefonu
            // 
            this.txtCepTelefonu.Location = new System.Drawing.Point(118, 144);
            this.txtCepTelefonu.Mask = "(999) 000-0000";
            this.txtCepTelefonu.Name = "txtCepTelefonu";
            this.txtCepTelefonu.Size = new System.Drawing.Size(179, 22);
            this.txtCepTelefonu.TabIndex = 3;
            // 
            // txtAdres
            // 
            this.txtAdres.Location = new System.Drawing.Point(373, 18);
            this.txtAdres.Multiline = true;
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(248, 118);
            this.txtAdres.TabIndex = 4;
            // 
            // comboIl
            // 
            this.comboIl.FormattingEnabled = true;
            this.comboIl.Location = new System.Drawing.Point(373, 142);
            this.comboIl.Name = "comboIl";
            this.comboIl.Size = new System.Drawing.Size(121, 24);
            this.comboIl.TabIndex = 5;
            this.comboIl.SelectedIndexChanged += new System.EventHandler(this.comboIl_SelectedIndexChanged);
            // 
            // comboIlce
            // 
            this.comboIlce.FormattingEnabled = true;
            this.comboIlce.Location = new System.Drawing.Point(500, 142);
            this.comboIlce.Name = "comboIlce";
            this.comboIlce.Size = new System.Drawing.Size(121, 24);
            this.comboIlce.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "TC Kimlik No";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Ad Soyad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Sayaç No";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Cep Telefonu";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(319, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Adres";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(319, 142);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 16);
            this.label6.TabIndex = 7;
            this.label6.Text = "İl / İlçe";
            // 
            // btnKapat
            // 
            this.btnKapat.Location = new System.Drawing.Point(21, 180);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(276, 50);
            this.btnKapat.TabIndex = 8;
            this.btnKapat.Text = "Kapat";
            this.btnKapat.UseVisualStyleBackColor = true;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // btnKaydetGuncelle
            // 
            this.btnKaydetGuncelle.Location = new System.Drawing.Point(322, 180);
            this.btnKaydetGuncelle.Name = "btnKaydetGuncelle";
            this.btnKaydetGuncelle.Size = new System.Drawing.Size(299, 50);
            this.btnKaydetGuncelle.TabIndex = 9;
            this.btnKaydetGuncelle.Text = "Kaydet";
            this.btnKaydetGuncelle.UseVisualStyleBackColor = true;
            this.btnKaydetGuncelle.Click += new System.EventHandler(this.btnKaydetGuncelle_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 16);
            this.label7.TabIndex = 7;
            this.label7.Text = "Abone Türü";
            // 
            // radioBahce
            // 
            this.radioBahce.AutoSize = true;
            this.radioBahce.Location = new System.Drawing.Point(106, 9);
            this.radioBahce.Name = "radioBahce";
            this.radioBahce.Size = new System.Drawing.Size(67, 20);
            this.radioBahce.TabIndex = 10;
            this.radioBahce.TabStop = true;
            this.radioBahce.Text = "Bahçe";
            this.radioBahce.UseVisualStyleBackColor = true;
            // 
            // radioMesken
            // 
            this.radioMesken.AutoSize = true;
            this.radioMesken.Location = new System.Drawing.Point(179, 9);
            this.radioMesken.Name = "radioMesken";
            this.radioMesken.Size = new System.Drawing.Size(76, 20);
            this.radioMesken.TabIndex = 11;
            this.radioMesken.TabStop = true;
            this.radioMesken.Text = "Mesken";
            this.radioMesken.UseVisualStyleBackColor = true;
            // 
            // radioTicari
            // 
            this.radioTicari.AutoSize = true;
            this.radioTicari.Location = new System.Drawing.Point(252, 9);
            this.radioTicari.Name = "radioTicari";
            this.radioTicari.Size = new System.Drawing.Size(62, 20);
            this.radioTicari.TabIndex = 12;
            this.radioTicari.TabStop = true;
            this.radioTicari.Text = "Ticari";
            this.radioTicari.UseVisualStyleBackColor = true;
            // 
            // FrmMusteriDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 248);
            this.Controls.Add(this.radioTicari);
            this.Controls.Add(this.radioMesken);
            this.Controls.Add(this.radioBahce);
            this.Controls.Add(this.btnKaydetGuncelle);
            this.Controls.Add(this.btnKapat);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboIlce);
            this.Controls.Add(this.comboIl);
            this.Controls.Add(this.txtAdres);
            this.Controls.Add(this.txtCepTelefonu);
            this.Controls.Add(this.txtSayacNo);
            this.Controls.Add(this.txtAdSoyad);
            this.Controls.Add(this.txtTCKN);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FrmMusteriDetay";
            this.Text = "FrmMusteriDetay";
            this.Load += new System.EventHandler(this.FrmMusteriDetay_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox txtTCKN;
        private System.Windows.Forms.TextBox txtAdSoyad;
        private System.Windows.Forms.MaskedTextBox txtSayacNo;
        private System.Windows.Forms.MaskedTextBox txtCepTelefonu;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.ComboBox comboIl;
        private System.Windows.Forms.ComboBox comboIlce;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnKapat;
        private System.Windows.Forms.Button btnKaydetGuncelle;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton radioBahce;
        private System.Windows.Forms.RadioButton radioMesken;
        private System.Windows.Forms.RadioButton radioTicari;
    }
}