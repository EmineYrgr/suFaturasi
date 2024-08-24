namespace NO2A_H11_SuFaturasi
{
    partial class FrmAna
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnMusteriEkle = new System.Windows.Forms.Button();
            this.btnMusteriList = new System.Windows.Forms.Button();
            this.btnYeniFatura = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnMusteriEkle);
            this.flowLayoutPanel1.Controls.Add(this.btnMusteriList);
            this.flowLayoutPanel1.Controls.Add(this.btnYeniFatura);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(113, 488);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // btnMusteriEkle
            // 
            this.btnMusteriEkle.Location = new System.Drawing.Point(2, 2);
            this.btnMusteriEkle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnMusteriEkle.Name = "btnMusteriEkle";
            this.btnMusteriEkle.Size = new System.Drawing.Size(111, 41);
            this.btnMusteriEkle.TabIndex = 0;
            this.btnMusteriEkle.Text = "Yeni Müşteri Ekle";
            this.btnMusteriEkle.UseVisualStyleBackColor = true;
            this.btnMusteriEkle.Click += new System.EventHandler(this.btnMusteriEkle_Click);
            // 
            // btnMusteriList
            // 
            this.btnMusteriList.Location = new System.Drawing.Point(2, 47);
            this.btnMusteriList.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnMusteriList.Name = "btnMusteriList";
            this.btnMusteriList.Size = new System.Drawing.Size(111, 41);
            this.btnMusteriList.TabIndex = 1;
            this.btnMusteriList.Text = "Müşteri Listesi";
            this.btnMusteriList.UseVisualStyleBackColor = true;
            this.btnMusteriList.Click += new System.EventHandler(this.btnMusteriList_Click);
            // 
            // btnYeniFatura
            // 
            this.btnYeniFatura.Location = new System.Drawing.Point(2, 92);
            this.btnYeniFatura.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnYeniFatura.Name = "btnYeniFatura";
            this.btnYeniFatura.Size = new System.Drawing.Size(111, 41);
            this.btnYeniFatura.TabIndex = 2;
            this.btnYeniFatura.Text = "Yeni Fatura";
            this.btnYeniFatura.UseVisualStyleBackColor = true;
            this.btnYeniFatura.Click += new System.EventHandler(this.btnYeniFatura_Click);
            // 
            // FrmAna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 488);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmAna";
            this.Text = "FrmAna";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmAna_FormClosing);
            this.Load += new System.EventHandler(this.FrmAna_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnMusteriEkle;
        private System.Windows.Forms.Button btnMusteriList;
        private System.Windows.Forms.Button btnYeniFatura;
    }
}