namespace NO2A_H08_SuFaturasi
{
    partial class FrmFatura
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
            this.comboMusteriID = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTarih = new System.Windows.Forms.DateTimePicker();
            this.dateSonOdemeTarih = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numericIlkEndeks = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.numericSonEndeks = new System.Windows.Forms.NumericUpDown();
            this.lblTutar = new System.Windows.Forms.Label();
            this.btnKaydet = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericIlkEndeks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericSonEndeks)).BeginInit();
            this.SuspendLayout();
            // 
            // comboMusteriID
            // 
            this.comboMusteriID.FormattingEnabled = true;
            this.comboMusteriID.Location = new System.Drawing.Point(126, 12);
            this.comboMusteriID.Name = "comboMusteriID";
            this.comboMusteriID.Size = new System.Drawing.Size(203, 24);
            this.comboMusteriID.TabIndex = 0;
            this.comboMusteriID.SelectedIndexChanged += new System.EventHandler(this.comboMusteriID_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Müşteri";
            // 
            // dateTarih
            // 
            this.dateTarih.Location = new System.Drawing.Point(126, 58);
            this.dateTarih.Name = "dateTarih";
            this.dateTarih.Size = new System.Drawing.Size(203, 22);
            this.dateTarih.TabIndex = 2;
            this.dateTarih.ValueChanged += new System.EventHandler(this.dateTarih_ValueChanged);
            // 
            // dateSonOdemeTarih
            // 
            this.dateSonOdemeTarih.Location = new System.Drawing.Point(126, 98);
            this.dateSonOdemeTarih.Name = "dateSonOdemeTarih";
            this.dateSonOdemeTarih.Size = new System.Drawing.Size(203, 22);
            this.dateSonOdemeTarih.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fatura Tarihi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Son Ödeme Tarihi";
            // 
            // numericIlkEndeks
            // 
            this.numericIlkEndeks.Location = new System.Drawing.Point(126, 139);
            this.numericIlkEndeks.Name = "numericIlkEndeks";
            this.numericIlkEndeks.Size = new System.Drawing.Size(91, 22);
            this.numericIlkEndeks.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "İlk/Son Endeks";
            // 
            // numericSonEndeks
            // 
            this.numericSonEndeks.Location = new System.Drawing.Point(238, 139);
            this.numericSonEndeks.Name = "numericSonEndeks";
            this.numericSonEndeks.Size = new System.Drawing.Size(91, 22);
            this.numericSonEndeks.TabIndex = 5;
            this.numericSonEndeks.ValueChanged += new System.EventHandler(this.numericSonEndeks_ValueChanged);
            // 
            // lblTutar
            // 
            this.lblTutar.AutoSize = true;
            this.lblTutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTutar.Location = new System.Drawing.Point(123, 191);
            this.lblTutar.Name = "lblTutar";
            this.lblTutar.Size = new System.Drawing.Size(110, 32);
            this.lblTutar.TabIndex = 6;
            this.lblTutar.Text = "0,00 TL";
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(69, 245);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(200, 48);
            this.btnKaydet.TabIndex = 7;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // FrmFatura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 322);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.lblTutar);
            this.Controls.Add(this.numericSonEndeks);
            this.Controls.Add(this.numericIlkEndeks);
            this.Controls.Add(this.dateSonOdemeTarih);
            this.Controls.Add(this.dateTarih);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboMusteriID);
            this.Name = "FrmFatura";
            this.Text = "FrmFatura";
            this.Load += new System.EventHandler(this.FrmFatura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericIlkEndeks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericSonEndeks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboMusteriID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTarih;
        private System.Windows.Forms.DateTimePicker dateSonOdemeTarih;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericIlkEndeks;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericSonEndeks;
        private System.Windows.Forms.Label lblTutar;
        private System.Windows.Forms.Button btnKaydet;
    }
}