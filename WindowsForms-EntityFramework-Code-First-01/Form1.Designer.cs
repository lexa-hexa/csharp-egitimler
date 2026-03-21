namespace WindowsForms_EntityFramework_Code_First_01
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnKayitEkle = new System.Windows.Forms.Button();
            this.txtStokMiktari = new System.Windows.Forms.TextBox();
            this.lblStokMiktari = new System.Windows.Forms.Label();
            this.txtUrunFiyati = new System.Windows.Forms.TextBox();
            this.txtUrunAdi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblUrunAdi = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.txtArama = new System.Windows.Forms.TextBox();
            this.dgvUrunListesi = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUrunListesi)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSil);
            this.groupBox1.Controls.Add(this.btnGuncelle);
            this.groupBox1.Controls.Add(this.btnKayitEkle);
            this.groupBox1.Controls.Add(this.txtStokMiktari);
            this.groupBox1.Controls.Add(this.lblStokMiktari);
            this.groupBox1.Controls.Add(this.txtUrunFiyati);
            this.groupBox1.Controls.Add(this.txtUrunAdi);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblUrunAdi);
            this.groupBox1.Controls.Add(this.lblId);
            this.groupBox1.Location = new System.Drawing.Point(490, 79);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(282, 246);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ürün Kayıt";
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(184, 185);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 23);
            this.btnSil.TabIndex = 9;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(103, 185);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(75, 23);
            this.btnGuncelle.TabIndex = 8;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnKayitEkle
            // 
            this.btnKayitEkle.Location = new System.Drawing.Point(22, 185);
            this.btnKayitEkle.Name = "btnKayitEkle";
            this.btnKayitEkle.Size = new System.Drawing.Size(75, 23);
            this.btnKayitEkle.TabIndex = 7;
            this.btnKayitEkle.Text = "Kayıt Ekle";
            this.btnKayitEkle.UseVisualStyleBackColor = true;
            this.btnKayitEkle.Click += new System.EventHandler(this.btnKayitEkle_Click);
            // 
            // txtStokMiktari
            // 
            this.txtStokMiktari.Location = new System.Drawing.Point(110, 126);
            this.txtStokMiktari.Name = "txtStokMiktari";
            this.txtStokMiktari.Size = new System.Drawing.Size(100, 20);
            this.txtStokMiktari.TabIndex = 6;
            // 
            // lblStokMiktari
            // 
            this.lblStokMiktari.AutoSize = true;
            this.lblStokMiktari.Location = new System.Drawing.Point(22, 129);
            this.lblStokMiktari.Name = "lblStokMiktari";
            this.lblStokMiktari.Size = new System.Drawing.Size(63, 13);
            this.lblStokMiktari.TabIndex = 5;
            this.lblStokMiktari.Text = "Stok Miktarı";
            // 
            // txtUrunFiyati
            // 
            this.txtUrunFiyati.Location = new System.Drawing.Point(110, 98);
            this.txtUrunFiyati.Name = "txtUrunFiyati";
            this.txtUrunFiyati.Size = new System.Drawing.Size(100, 20);
            this.txtUrunFiyati.TabIndex = 4;
            // 
            // txtUrunAdi
            // 
            this.txtUrunAdi.Location = new System.Drawing.Point(110, 63);
            this.txtUrunAdi.Name = "txtUrunAdi";
            this.txtUrunAdi.Size = new System.Drawing.Size(100, 20);
            this.txtUrunAdi.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ürün Fiyatı";
            // 
            // lblUrunAdi
            // 
            this.lblUrunAdi.AutoSize = true;
            this.lblUrunAdi.Location = new System.Drawing.Point(22, 63);
            this.lblUrunAdi.Name = "lblUrunAdi";
            this.lblUrunAdi.Size = new System.Drawing.Size(47, 13);
            this.lblUrunAdi.TabIndex = 1;
            this.lblUrunAdi.Text = "Ürün adı";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(22, 35);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(13, 13);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "0";
            this.lblId.Visible = false;
            // 
            // txtArama
            // 
            this.txtArama.Location = new System.Drawing.Point(490, 28);
            this.txtArama.Name = "txtArama";
            this.txtArama.Size = new System.Drawing.Size(282, 20);
            this.txtArama.TabIndex = 8;
            this.txtArama.TextChanged += new System.EventHandler(this.txtArama_TextChanged);
            // 
            // dgvUrunListesi
            // 
            this.dgvUrunListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUrunListesi.Location = new System.Drawing.Point(12, 12);
            this.dgvUrunListesi.Name = "dgvUrunListesi";
            this.dgvUrunListesi.Size = new System.Drawing.Size(449, 426);
            this.dgvUrunListesi.TabIndex = 6;
            this.dgvUrunListesi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUrunListesi_CellClick);
            this.dgvUrunListesi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUrunListesi_CellContentClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtArama);
            this.Controls.Add(this.dgvUrunListesi);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUrunListesi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnKayitEkle;
        private System.Windows.Forms.TextBox txtStokMiktari;
        private System.Windows.Forms.Label lblStokMiktari;
        private System.Windows.Forms.TextBox txtUrunFiyati;
        private System.Windows.Forms.TextBox txtUrunAdi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblUrunAdi;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtArama;
        private System.Windows.Forms.DataGridView dgvUrunListesi;
    }
}

