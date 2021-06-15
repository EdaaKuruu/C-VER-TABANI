
namespace ARACIM_KİRALA
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtsoyadi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtveristarihi = new System.Windows.Forms.TextBox();
            this.txtalistarihi = new System.Windows.Forms.TextBox();
            this.txttel = new System.Windows.Forms.TextBox();
            this.txtadi = new System.Windows.Forms.TextBox();
            this.txtücret = new System.Windows.Forms.TextBox();
            this.txtrenk = new System.Windows.Forms.TextBox();
            this.txtplaka = new System.Windows.Forms.TextBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.txtmarka = new System.Windows.Forms.TextBox();
            this.txt_tel = new System.Windows.Forms.Label();
            this.txta_tarih = new System.Windows.Forms.Label();
            this.txtv_tarih = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.Label();
            this.txt_plaka = new System.Windows.Forms.Label();
            this.txt_renk = new System.Windows.Forms.Label();
            this.txt_ücret = new System.Windows.Forms.Label();
            this.txt_ad = new System.Windows.Forms.Label();
            this.txt_marka = new System.Windows.Forms.Label();
            this.buttonarabam = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnsil = new System.Windows.Forms.Button();
            this.btngüncelle = new System.Windows.Forms.Button();
            this.btngöster = new System.Windows.Forms.Button();
            this.btnekle = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtsoyadi);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtveristarihi);
            this.groupBox1.Controls.Add(this.txtalistarihi);
            this.groupBox1.Controls.Add(this.txttel);
            this.groupBox1.Controls.Add(this.txtadi);
            this.groupBox1.Controls.Add(this.txtücret);
            this.groupBox1.Controls.Add(this.txtrenk);
            this.groupBox1.Controls.Add(this.txtplaka);
            this.groupBox1.Controls.Add(this.txtid);
            this.groupBox1.Controls.Add(this.txtmarka);
            this.groupBox1.Controls.Add(this.txt_tel);
            this.groupBox1.Controls.Add(this.txta_tarih);
            this.groupBox1.Controls.Add(this.txtv_tarih);
            this.groupBox1.Controls.Add(this.txt_id);
            this.groupBox1.Controls.Add(this.txt_plaka);
            this.groupBox1.Controls.Add(this.txt_renk);
            this.groupBox1.Controls.Add(this.txt_ücret);
            this.groupBox1.Controls.Add(this.txt_ad);
            this.groupBox1.Controls.Add(this.txt_marka);
            this.groupBox1.Controls.Add(this.buttonarabam);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(25, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(685, 1117);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Araç Bilgileri";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtsoyadi
            // 
            this.txtsoyadi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtsoyadi.Location = new System.Drawing.Point(336, 764);
            this.txtsoyadi.Name = "txtsoyadi";
            this.txtsoyadi.Size = new System.Drawing.Size(207, 41);
            this.txtsoyadi.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(45, 765);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(285, 40);
            this.label2.TabIndex = 20;
            this.label2.Text = "Müşteri  Soyadı :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtveristarihi
            // 
            this.txtveristarihi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtveristarihi.Location = new System.Drawing.Point(270, 1015);
            this.txtveristarihi.Name = "txtveristarihi";
            this.txtveristarihi.Size = new System.Drawing.Size(207, 41);
            this.txtveristarihi.TabIndex = 19;
            // 
            // txtalistarihi
            // 
            this.txtalistarihi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtalistarihi.Location = new System.Drawing.Point(254, 929);
            this.txtalistarihi.Name = "txtalistarihi";
            this.txtalistarihi.Size = new System.Drawing.Size(207, 41);
            this.txtalistarihi.TabIndex = 18;
            // 
            // txttel
            // 
            this.txttel.Location = new System.Drawing.Point(270, 848);
            this.txttel.Name = "txttel";
            this.txttel.Size = new System.Drawing.Size(207, 38);
            this.txttel.TabIndex = 17;
            // 
            // txtadi
            // 
            this.txtadi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtadi.Location = new System.Drawing.Point(282, 671);
            this.txtadi.Name = "txtadi";
            this.txtadi.Size = new System.Drawing.Size(207, 41);
            this.txtadi.TabIndex = 16;
            // 
            // txtücret
            // 
            this.txtücret.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtücret.Location = new System.Drawing.Point(289, 596);
            this.txtücret.Name = "txtücret";
            this.txtücret.Size = new System.Drawing.Size(207, 41);
            this.txtücret.TabIndex = 15;
            // 
            // txtrenk
            // 
            this.txtrenk.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtrenk.Location = new System.Drawing.Point(289, 533);
            this.txtrenk.Name = "txtrenk";
            this.txtrenk.Size = new System.Drawing.Size(207, 41);
            this.txtrenk.TabIndex = 14;
            // 
            // txtplaka
            // 
            this.txtplaka.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtplaka.Location = new System.Drawing.Point(289, 451);
            this.txtplaka.Name = "txtplaka";
            this.txtplaka.Size = new System.Drawing.Size(207, 41);
            this.txtplaka.TabIndex = 13;
            // 
            // txtid
            // 
            this.txtid.Enabled = false;
            this.txtid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtid.Location = new System.Drawing.Point(241, 363);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(207, 41);
            this.txtid.TabIndex = 12;
            // 
            // txtmarka
            // 
            this.txtmarka.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtmarka.Location = new System.Drawing.Point(212, 293);
            this.txtmarka.Name = "txtmarka";
            this.txtmarka.Size = new System.Drawing.Size(207, 41);
            this.txtmarka.TabIndex = 11;
            // 
            // txt_tel
            // 
            this.txt_tel.AutoSize = true;
            this.txt_tel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_tel.Location = new System.Drawing.Point(49, 844);
            this.txt_tel.Name = "txt_tel";
            this.txt_tel.Size = new System.Drawing.Size(215, 40);
            this.txt_tel.TabIndex = 10;
            this.txt_tel.Text = "Müşteri Tel :";
            // 
            // txta_tarih
            // 
            this.txta_tarih.AutoSize = true;
            this.txta_tarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txta_tarih.Location = new System.Drawing.Point(45, 928);
            this.txta_tarih.Name = "txta_tarih";
            this.txta_tarih.Size = new System.Drawing.Size(195, 40);
            this.txta_tarih.TabIndex = 9;
            this.txta_tarih.Text = "Alış Tarihi :";
            // 
            // txtv_tarih
            // 
            this.txtv_tarih.AutoSize = true;
            this.txtv_tarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtv_tarih.Location = new System.Drawing.Point(45, 1014);
            this.txtv_tarih.Name = "txtv_tarih";
            this.txtv_tarih.Size = new System.Drawing.Size(219, 40);
            this.txtv_tarih.TabIndex = 8;
            this.txtv_tarih.Text = "Veriş Tarihi :";
            // 
            // txt_id
            // 
            this.txt_id.AutoSize = true;
            this.txt_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_id.Location = new System.Drawing.Point(69, 362);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(166, 40);
            this.txt_id.TabIndex = 7;
            this.txt_id.Text = "Araç_ID :";
            // 
            // txt_plaka
            // 
            this.txt_plaka.AutoSize = true;
            this.txt_plaka.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_plaka.Location = new System.Drawing.Point(59, 444);
            this.txt_plaka.Name = "txt_plaka";
            this.txt_plaka.Size = new System.Drawing.Size(211, 40);
            this.txt_plaka.TabIndex = 6;
            this.txt_plaka.Text = "Araç Plaka :";
            // 
            // txt_renk
            // 
            this.txt_renk.AutoSize = true;
            this.txt_renk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_renk.Location = new System.Drawing.Point(59, 520);
            this.txt_renk.Name = "txt_renk";
            this.txt_renk.Size = new System.Drawing.Size(205, 40);
            this.txt_renk.TabIndex = 5;
            this.txt_renk.Text = "Araç Renk :";
            // 
            // txt_ücret
            // 
            this.txt_ücret.AutoSize = true;
            this.txt_ücret.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_ücret.Location = new System.Drawing.Point(59, 595);
            this.txt_ücret.Name = "txt_ücret";
            this.txt_ücret.Size = new System.Drawing.Size(197, 40);
            this.txt_ücret.TabIndex = 4;
            this.txt_ücret.Text = "Kira Ücret :";
            // 
            // txt_ad
            // 
            this.txt_ad.AutoSize = true;
            this.txt_ad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_ad.Location = new System.Drawing.Point(59, 670);
            this.txt_ad.Name = "txt_ad";
            this.txt_ad.Size = new System.Drawing.Size(217, 40);
            this.txt_ad.TabIndex = 3;
            this.txt_ad.Text = "Müşteri Adı :";
            this.txt_ad.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.txt_ad.Click += new System.EventHandler(this.txtad_Click);
            // 
            // txt_marka
            // 
            this.txt_marka.AutoSize = true;
            this.txt_marka.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_marka.Location = new System.Drawing.Point(69, 292);
            this.txt_marka.Name = "txt_marka";
            this.txt_marka.Size = new System.Drawing.Size(137, 40);
            this.txt_marka.TabIndex = 2;
            this.txt_marka.Text = "Marka :";
            // 
            // buttonarabam
            // 
            this.buttonarabam.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.buttonarabam.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonarabam.BackgroundImage")));
            this.buttonarabam.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonarabam.Location = new System.Drawing.Point(42, 152);
            this.buttonarabam.Name = "buttonarabam";
            this.buttonarabam.Size = new System.Drawing.Size(196, 112);
            this.buttonarabam.TabIndex = 1;
            this.buttonarabam.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(42, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(454, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Araç Temel Bilgileri";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.DeepSkyBlue;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(807, 150);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 92;
            this.dataGridView1.RowTemplate.Height = 37;
            this.dataGridView1.Size = new System.Drawing.Size(1139, 375);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEnter);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(796, 56);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(477, 63);
            this.label11.TabIndex = 2;
            this.label11.Text = "ARAÇ KİRALAMA";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnsil);
            this.groupBox2.Controls.Add(this.btngüncelle);
            this.groupBox2.Controls.Add(this.btngöster);
            this.groupBox2.Controls.Add(this.btnekle);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(1265, 554);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(564, 574);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Butonlar";
            // 
            // btnsil
            // 
            this.btnsil.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnsil.Location = new System.Drawing.Point(294, 481);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(210, 68);
            this.btnsil.TabIndex = 4;
            this.btnsil.Text = "SİL";
            this.btnsil.UseVisualStyleBackColor = false;
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // btngüncelle
            // 
            this.btngüncelle.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btngüncelle.Location = new System.Drawing.Point(294, 248);
            this.btngüncelle.Name = "btngüncelle";
            this.btngüncelle.Size = new System.Drawing.Size(210, 68);
            this.btngüncelle.TabIndex = 3;
            this.btngüncelle.Text = "GÜNCELLE";
            this.btngüncelle.UseVisualStyleBackColor = false;
            this.btngüncelle.Click += new System.EventHandler(this.btngüncelle_Click);
            // 
            // btngöster
            // 
            this.btngöster.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btngöster.Location = new System.Drawing.Point(44, 393);
            this.btngöster.Name = "btngöster";
            this.btngöster.Size = new System.Drawing.Size(210, 68);
            this.btngöster.TabIndex = 2;
            this.btngöster.Text = "GÖSTER";
            this.btngöster.UseVisualStyleBackColor = false;
            this.btngöster.Click += new System.EventHandler(this.btngöster_Click);
            // 
            // btnekle
            // 
            this.btnekle.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnekle.Location = new System.Drawing.Point(44, 149);
            this.btnekle.Name = "btnekle";
            this.btnekle.Size = new System.Drawing.Size(210, 68);
            this.btnekle.TabIndex = 1;
            this.btnekle.Text = "EKLE";
            this.btnekle.UseVisualStyleBackColor = false;
            this.btnekle.Click += new System.EventHandler(this.btnekle_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(68, 58);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(427, 40);
            this.label12.TabIndex = 0;
            this.label12.Text = "Diğer Yapılacak İşlemler";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(2326, 1185);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "ARAÇ KİRALAMA";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtadi;
        private System.Windows.Forms.TextBox txtücret;
        private System.Windows.Forms.TextBox txtrenk;
        private System.Windows.Forms.TextBox txtplaka;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.TextBox txtmarka;
        private System.Windows.Forms.Label txt_tel;
        private System.Windows.Forms.Label txta_tarih;
        private System.Windows.Forms.Label txtv_tarih;
        private System.Windows.Forms.Label txt_id;
        private System.Windows.Forms.Label txt_plaka;
        private System.Windows.Forms.Label txt_renk;
        private System.Windows.Forms.Label txt_ücret;
        private System.Windows.Forms.Label txt_ad;
        private System.Windows.Forms.Label txt_marka;
        private System.Windows.Forms.Button buttonarabam;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtveristarihi;
        private System.Windows.Forms.TextBox txtalistarihi;
        private System.Windows.Forms.TextBox txttel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.Button btngüncelle;
        private System.Windows.Forms.Button btngöster;
        private System.Windows.Forms.Button btnekle;
        private System.Windows.Forms.TextBox txtsoyadi;
        private System.Windows.Forms.Label label2;
    }
}

