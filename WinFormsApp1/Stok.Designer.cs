namespace WinFormsApp1
{
    partial class Stok
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Stok));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panel1 = new Panel();
            kullanici = new Label();
            labelstokdurum = new Label();
            labelkategori = new Label();
            urunlabel = new Label();
            panel2 = new Panel();
            cikis = new Label();
            panel3 = new Panel();
            label11 = new Label();
            label3 = new Label();
            hareket = new Label();
            stokdurum = new Label();
            degismetarih = new Label();
            urunadistok = new Label();
            labelurunliste = new Label();
            guna2DataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            miktar = new Label();
            btnguncelle = new Button();
            txtmiktar = new TextBox();
            labelfiyat = new Label();
            kategori = new Label();
            txtstokid = new TextBox();
            labelurun = new Label();
            label1 = new Label();
            txthareket = new TextBox();
            pictureBox1 = new PictureBox();
            guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)guna2DataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)guna2CirclePictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.MediumSlateBlue;
            panel1.Controls.Add(guna2CirclePictureBox1);
            panel1.Controls.Add(kullanici);
            panel1.Controls.Add(labelstokdurum);
            panel1.Controls.Add(labelkategori);
            panel1.Controls.Add(urunlabel);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(239, 748);
            panel1.TabIndex = 2;
            // 
            // kullanici
            // 
            kullanici.AutoSize = true;
            kullanici.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            kullanici.ForeColor = Color.White;
            kullanici.Location = new Point(43, 404);
            kullanici.Name = "kullanici";
            kullanici.Size = new Size(98, 25);
            kullanici.TabIndex = 2;
            kullanici.Text = "Kullanıcı";
            // 
            // labelstokdurum
            // 
            labelstokdurum.AutoSize = true;
            labelstokdurum.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            labelstokdurum.ForeColor = Color.White;
            labelstokdurum.Location = new Point(43, 339);
            labelstokdurum.Name = "labelstokdurum";
            labelstokdurum.Size = new Size(147, 25);
            labelstokdurum.TabIndex = 2;
            labelstokdurum.Text = "Stok Durumu";
            // 
            // labelkategori
            // 
            labelkategori.AutoSize = true;
            labelkategori.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            labelkategori.ForeColor = Color.White;
            labelkategori.Location = new Point(43, 274);
            labelkategori.Name = "labelkategori";
            labelkategori.Size = new Size(96, 25);
            labelkategori.TabIndex = 2;
            labelkategori.Text = "Kategori";
            // 
            // urunlabel
            // 
            urunlabel.AutoSize = true;
            urunlabel.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            urunlabel.ForeColor = Color.White;
            urunlabel.Location = new Point(45, 204);
            urunlabel.Name = "urunlabel";
            urunlabel.Size = new Size(62, 25);
            urunlabel.TabIndex = 2;
            urunlabel.Text = "Ürün";
            // 
            // panel2
            // 
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(cikis);
            panel2.Location = new Point(3, 688);
            panel2.Name = "panel2";
            panel2.Size = new Size(236, 57);
            panel2.TabIndex = 2;
            // 
            // cikis
            // 
            cikis.AutoSize = true;
            cikis.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            cikis.ForeColor = Color.White;
            cikis.Location = new Point(91, 14);
            cikis.Name = "cikis";
            cikis.Size = new Size(60, 25);
            cikis.TabIndex = 2;
            cikis.Text = "Çıkış";
            cikis.Click += cikis_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.MediumSlateBlue;
            panel3.Controls.Add(label11);
            panel3.Controls.Add(label3);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(239, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1144, 57);
            panel3.TabIndex = 5;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Verdana", 14F);
            label11.ForeColor = Color.White;
            label11.Location = new Point(1103, 18);
            label11.Name = "label11";
            label11.Size = new Size(29, 29);
            label11.TabIndex = 18;
            label11.Text = "X";
            label11.Click += label11_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label3.ForeColor = Color.White;
            label3.Location = new Point(476, 9);
            label3.Name = "label3";
            label3.Size = new Size(117, 25);
            label3.TabIndex = 2;
            label3.Text = "Stok Takip";
            // 
            // hareket
            // 
            hareket.AutoSize = true;
            hareket.Font = new Font("Verdana", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            hareket.Location = new Point(881, 355);
            hareket.Name = "hareket";
            hareket.Size = new Size(76, 20);
            hareket.TabIndex = 27;
            hareket.Text = "Hareket";
            // 
            // stokdurum
            // 
            stokdurum.AutoSize = true;
            stokdurum.Font = new Font("Verdana", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            stokdurum.Location = new Point(756, 355);
            stokdurum.Name = "stokdurum";
            stokdurum.Size = new Size(48, 20);
            stokdurum.TabIndex = 26;
            stokdurum.Text = "Stok";
            // 
            // degismetarih
            // 
            degismetarih.AutoSize = true;
            degismetarih.Font = new Font("Verdana", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            degismetarih.Location = new Point(561, 355);
            degismetarih.Name = "degismetarih";
            degismetarih.Size = new Size(136, 20);
            degismetarih.TabIndex = 25;
            degismetarih.Text = "Değişme Tarihi";
            // 
            // urunadistok
            // 
            urunadistok.AutoSize = true;
            urunadistok.Font = new Font("Verdana", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            urunadistok.Location = new Point(460, 355);
            urunadistok.Name = "urunadistok";
            urunadistok.Size = new Size(84, 20);
            urunadistok.TabIndex = 24;
            urunadistok.Text = "Ürün Adı";
            // 
            // labelurunliste
            // 
            labelurunliste.AutoSize = true;
            labelurunliste.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            labelurunliste.Location = new Point(668, 304);
            labelurunliste.Name = "labelurunliste";
            labelurunliste.Size = new Size(146, 25);
            labelurunliste.TabIndex = 23;
            labelurunliste.Text = "Ürün Listesi";
            // 
            // guna2DataGridView1
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            guna2DataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            guna2DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            guna2DataGridView1.ColumnHeadersHeight = 4;
            guna2DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            guna2DataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            guna2DataGridView1.GridColor = Color.FromArgb(231, 229, 255);
            guna2DataGridView1.Location = new Point(368, 383);
            guna2DataGridView1.Name = "guna2DataGridView1";
            guna2DataGridView1.RowHeadersVisible = false;
            guna2DataGridView1.RowHeadersWidth = 51;
            guna2DataGridView1.Size = new Size(830, 353);
            guna2DataGridView1.TabIndex = 22;
            guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.Font = null;
            guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            guna2DataGridView1.ThemeStyle.BackColor = Color.White;
            guna2DataGridView1.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            guna2DataGridView1.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            guna2DataGridView1.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            guna2DataGridView1.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            guna2DataGridView1.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            guna2DataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            guna2DataGridView1.ThemeStyle.HeaderStyle.Height = 4;
            guna2DataGridView1.ThemeStyle.ReadOnly = false;
            guna2DataGridView1.ThemeStyle.RowsStyle.BackColor = Color.White;
            guna2DataGridView1.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            guna2DataGridView1.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            guna2DataGridView1.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            guna2DataGridView1.ThemeStyle.RowsStyle.Height = 29;
            guna2DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            guna2DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            // 
            // miktar
            // 
            miktar.AutoSize = true;
            miktar.Font = new Font("Verdana", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            miktar.Location = new Point(1028, 355);
            miktar.Name = "miktar";
            miktar.Size = new Size(62, 20);
            miktar.TabIndex = 28;
            miktar.Text = "Miktar";
            // 
            // btnguncelle
            // 
            btnguncelle.BackColor = Color.White;
            btnguncelle.Font = new Font("Verdana", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnguncelle.Location = new Point(668, 219);
            btnguncelle.Name = "btnguncelle";
            btnguncelle.Size = new Size(136, 53);
            btnguncelle.TabIndex = 37;
            btnguncelle.Text = "Güncelle";
            btnguncelle.UseVisualStyleBackColor = false;
            btnguncelle.Click += btnguncelle_Click;
            // 
            // txtmiktar
            // 
            txtmiktar.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtmiktar.Location = new Point(934, 142);
            txtmiktar.Name = "txtmiktar";
            txtmiktar.Size = new Size(217, 31);
            txtmiktar.TabIndex = 33;
            // 
            // labelfiyat
            // 
            labelfiyat.AutoSize = true;
            labelfiyat.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            labelfiyat.Location = new Point(941, 101);
            labelfiyat.Name = "labelfiyat";
            labelfiyat.Size = new Size(76, 25);
            labelfiyat.TabIndex = 32;
            labelfiyat.Text = "Miktar";
            // 
            // kategori
            // 
            kategori.AutoSize = true;
            kategori.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            kategori.Location = new Point(615, 101);
            kategori.Name = "kategori";
            kategori.Size = new Size(92, 25);
            kategori.TabIndex = 31;
            kategori.Text = "Hareket";
            // 
            // txtstokid
            // 
            txtstokid.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtstokid.Location = new Point(346, 142);
            txtstokid.Name = "txtstokid";
            txtstokid.Size = new Size(217, 31);
            txtstokid.TabIndex = 30;
            // 
            // labelurun
            // 
            labelurun.AutoSize = true;
            labelurun.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            labelurun.Location = new Point(346, 101);
            labelurun.Name = "labelurun";
            labelurun.Size = new Size(85, 25);
            labelurun.TabIndex = 29;
            labelurun.Text = "Stok Id";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.Location = new Point(368, 355);
            label1.Name = "label1";
            label1.Size = new Size(73, 20);
            label1.TabIndex = 40;
            label1.Text = "Stok Id";
            // 
            // txthareket
            // 
            txthareket.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txthareket.Location = new Point(615, 142);
            txthareket.Name = "txthareket";
            txthareket.Size = new Size(217, 31);
            txthareket.TabIndex = 42;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(25, 8);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(60, 46);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 43;
            pictureBox1.TabStop = false;
            // 
            // guna2CirclePictureBox1
            // 
            guna2CirclePictureBox1.BackgroundImageLayout = ImageLayout.None;
            guna2CirclePictureBox1.BorderStyle = BorderStyle.Fixed3D;
            guna2CirclePictureBox1.Image = (Image)resources.GetObject("guna2CirclePictureBox1.Image");
            guna2CirclePictureBox1.ImageRotate = 0F;
            guna2CirclePictureBox1.Location = new Point(45, 18);
            guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            guna2CirclePictureBox1.ShadowDecoration.CustomizableEdges = customizableEdges1;
            guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            guna2CirclePictureBox1.Size = new Size(118, 107);
            guna2CirclePictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            guna2CirclePictureBox1.TabIndex = 23;
            guna2CirclePictureBox1.TabStop = false;
            // 
            // Stok
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1383, 748);
            Controls.Add(txthareket);
            Controls.Add(label1);
            Controls.Add(btnguncelle);
            Controls.Add(txtmiktar);
            Controls.Add(labelfiyat);
            Controls.Add(kategori);
            Controls.Add(txtstokid);
            Controls.Add(labelurun);
            Controls.Add(miktar);
            Controls.Add(hareket);
            Controls.Add(stokdurum);
            Controls.Add(degismetarih);
            Controls.Add(urunadistok);
            Controls.Add(labelurunliste);
            Controls.Add(guna2DataGridView1);
            Controls.Add(panel3);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Stok";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Stok";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)guna2DataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)guna2CirclePictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label kullanici;
        private Label labelstokdurum;
        private Label labelkategori;
        private Label urunlabel;
        private Panel panel2;
        private Label cikis;
        private Panel panel3;
        private Label label11;
        private Label label3;
        private Label hareket;
        private Label stokdurum;
        private Label degismetarih;
        private Label urunadistok;
        private Label labelurunliste;
        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView1;
        private Label miktar;
        private Button btnguncelle;
        private TextBox txtmiktar;
        private Label labelfiyat;
        private Label kategori;
        private TextBox txtstokid;
        private Label labelurun;
        private Label label1;
        private TextBox txthareket;
        private PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
    }
}