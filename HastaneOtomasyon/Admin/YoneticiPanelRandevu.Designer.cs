namespace HastaneOtomasyon.Admin
{
    partial class YoneticiPanelRandevu
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
            this.btnAnasayfa = new System.Windows.Forms.Button();
            this.txtAra = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtDoktorSilTc = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnArama = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbHasta = new System.Windows.Forms.ComboBox();
            this.cbPoliklinik = new System.Windows.Forms.ComboBox();
            this.cbDoktor = new System.Windows.Forms.ComboBox();
            this.cbSaat = new System.Windows.Forms.ComboBox();
            this.dateTarih = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAnasayfa
            // 
            this.btnAnasayfa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAnasayfa.Location = new System.Drawing.Point(904, 14);
            this.btnAnasayfa.Name = "btnAnasayfa";
            this.btnAnasayfa.Size = new System.Drawing.Size(107, 40);
            this.btnAnasayfa.TabIndex = 96;
            this.btnAnasayfa.Text = "Anasayfa";
            this.btnAnasayfa.UseVisualStyleBackColor = true;
            this.btnAnasayfa.Click += new System.EventHandler(this.btnAnasayfa_Click);
            // 
            // txtAra
            // 
            this.txtAra.Location = new System.Drawing.Point(673, 133);
            this.txtAra.Name = "txtAra";
            this.txtAra.Size = new System.Drawing.Size(215, 20);
            this.txtAra.TabIndex = 95;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(670, 110);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(149, 18);
            this.label11.TabIndex = 94;
            this.label11.Text = "İsime göre doktor ara";
            // 
            // txtDoktorSilTc
            // 
            this.txtDoktorSilTc.Location = new System.Drawing.Point(673, 181);
            this.txtDoktorSilTc.Name = "txtDoktorSilTc";
            this.txtDoktorSilTc.Size = new System.Drawing.Size(215, 20);
            this.txtDoktorSilTc.TabIndex = 93;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(670, 160);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(222, 18);
            this.label10.TabIndex = 92;
            this.label10.Text = "Silinecek Doktorun TC numarası";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 225);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(982, 265);
            this.dataGridView1.TabIndex = 91;
            // 
            // btnArama
            // 
            this.btnArama.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnArama.Location = new System.Drawing.Point(904, 134);
            this.btnArama.Name = "btnArama";
            this.btnArama.Size = new System.Drawing.Size(89, 24);
            this.btnArama.TabIndex = 89;
            this.btnArama.Text = "Ara";
            this.btnArama.UseVisualStyleBackColor = true;
            // 
            // btnSil
            // 
            this.btnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.Location = new System.Drawing.Point(904, 180);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(89, 25);
            this.btnSil.TabIndex = 88;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGuncelle.Location = new System.Drawing.Point(234, 177);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(81, 24);
            this.btnGuncelle.TabIndex = 87;
            this.btnGuncelle.Text = "Randevu Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.Location = new System.Drawing.Point(12, 180);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(105, 24);
            this.btnKaydet.TabIndex = 86;
            this.btnKaydet.Text = "Randevu Al";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.Location = new System.Drawing.Point(9, 98);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(54, 18);
            this.label14.TabIndex = 73;
            this.label14.Text = "Doktor";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.Location = new System.Drawing.Point(9, 57);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(66, 18);
            this.label15.TabIndex = 72;
            this.label15.Text = "Poliklinik";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label16.Location = new System.Drawing.Point(9, 18);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(47, 18);
            this.label16.TabIndex = 71;
            this.label16.Text = "Hasta";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(9, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 18);
            this.label1.TabIndex = 97;
            this.label1.Text = "Saat";
            // 
            // cbHasta
            // 
            this.cbHasta.FormattingEnabled = true;
            this.cbHasta.Location = new System.Drawing.Point(124, 14);
            this.cbHasta.Name = "cbHasta";
            this.cbHasta.Size = new System.Drawing.Size(191, 21);
            this.cbHasta.TabIndex = 98;
            // 
            // cbPoliklinik
            // 
            this.cbPoliklinik.FormattingEnabled = true;
            this.cbPoliklinik.Location = new System.Drawing.Point(124, 54);
            this.cbPoliklinik.Name = "cbPoliklinik";
            this.cbPoliklinik.Size = new System.Drawing.Size(191, 21);
            this.cbPoliklinik.TabIndex = 99;
            this.cbPoliklinik.SelectedIndexChanged += new System.EventHandler(this.cbPoliklinik_SelectedIndexChanged);
            // 
            // cbDoktor
            // 
            this.cbDoktor.FormattingEnabled = true;
            this.cbDoktor.Location = new System.Drawing.Point(124, 95);
            this.cbDoktor.Name = "cbDoktor";
            this.cbDoktor.Size = new System.Drawing.Size(191, 21);
            this.cbDoktor.TabIndex = 100;
            // 
            // cbSaat
            // 
            this.cbSaat.FormattingEnabled = true;
            this.cbSaat.Location = new System.Drawing.Point(124, 132);
            this.cbSaat.Name = "cbSaat";
            this.cbSaat.Size = new System.Drawing.Size(191, 21);
            this.cbSaat.TabIndex = 101;
            // 
            // dateTarih
            // 
            this.dateTarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateTarih.Location = new System.Drawing.Point(414, 11);
            this.dateTarih.Name = "dateTarih";
            this.dateTarih.Size = new System.Drawing.Size(200, 24);
            this.dateTarih.TabIndex = 102;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(357, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 18);
            this.label2.TabIndex = 103;
            this.label2.Text = "Tarih";
            // 
            // YoneticiPanelRandevu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 506);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTarih);
            this.Controls.Add(this.cbSaat);
            this.Controls.Add(this.cbDoktor);
            this.Controls.Add(this.cbPoliklinik);
            this.Controls.Add(this.cbHasta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAnasayfa);
            this.Controls.Add(this.txtAra);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtDoktorSilTc);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnArama);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Name = "YoneticiPanelRandevu";
            this.Text = "YoneticiPanelRandevu";
            this.Load += new System.EventHandler(this.YoneticiPanelRandevu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAnasayfa;
        private System.Windows.Forms.TextBox txtAra;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtDoktorSilTc;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnArama;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbHasta;
        private System.Windows.Forms.ComboBox cbPoliklinik;
        private System.Windows.Forms.ComboBox cbDoktor;
        private System.Windows.Forms.ComboBox cbSaat;
        private System.Windows.Forms.DateTimePicker dateTarih;
        private System.Windows.Forms.Label label2;
    }
}