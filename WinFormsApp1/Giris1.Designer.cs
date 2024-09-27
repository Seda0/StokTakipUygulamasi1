namespace WinFormsApp1
{
    partial class Giris1
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Giris1));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            panel1 = new Panel();
            guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            kullanici = new Label();
            labelstokdurum = new Label();
            labelkategori = new Label();
            urunlabel = new Label();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            cikis = new Label();
            guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(components);
            panel3 = new Panel();
            label11 = new Label();
            label3 = new Label();
            labelurun = new Label();
            txturun = new TextBox();
            kategori = new Label();
            txtfiyat = new TextBox();
            labelfiyat = new Label();
            txtstok = new TextBox();
            labelstok = new Label();
            comboBoxkategori = new ComboBox();
            btnguncelle = new Button();
            btnekle = new Button();
            btnsil = new Button();
            guna2DataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            labelurunliste = new Label();
            npgsqlDataAdapter1 = new Npgsql.NpgsqlDataAdapter();
            urunadi = new Label();
            kategorii = new Label();
            stokk = new Label();
            fiyatt = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)guna2CirclePictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)guna2DataGridView1).BeginInit();
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
            panel1.TabIndex = 0;
            // 
            // guna2CirclePictureBox1
            // 
            guna2CirclePictureBox1.BackgroundImageLayout = ImageLayout.None;
            guna2CirclePictureBox1.BorderStyle = BorderStyle.Fixed3D;
            guna2CirclePictureBox1.Image = (Image)resources.GetObject("guna2CirclePictureBox1.Image");
            guna2CirclePictureBox1.ImageRotate = 0F;
            guna2CirclePictureBox1.Location = new Point(43, 12);
            guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            guna2CirclePictureBox1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            guna2CirclePictureBox1.Size = new Size(118, 107);
            guna2CirclePictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            guna2CirclePictureBox1.TabIndex = 22;
            guna2CirclePictureBox1.TabStop = false;
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
            kullanici.Click += kullanici_Click;
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
            labelstokdurum.Click += labelstokdurum_Click;
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
            labelkategori.Click += labelkategori_Click;
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
            urunlabel.Click += label2_Click;
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
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(24, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(60, 46);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 44;
            pictureBox1.TabStop = false;
            // 
            // cikis
            // 
            cikis.AutoSize = true;
            cikis.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            cikis.ForeColor = Color.White;
            cikis.Location = new Point(90, 14);
            cikis.Name = "cikis";
            cikis.Size = new Size(60, 25);
            cikis.TabIndex = 2;
            cikis.Text = "Çıkış";
            cikis.Click += cikis_Click;
            // 
            // guna2Elipse1
            // 
            guna2Elipse1.BorderRadius = 15;
            guna2Elipse1.TargetControl = this;
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
            panel3.TabIndex = 3;
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
            // labelurun
            // 
            labelurun.AutoSize = true;
            labelurun.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            labelurun.Location = new Point(266, 124);
            labelurun.Name = "labelurun";
            labelurun.Size = new Size(62, 25);
            labelurun.TabIndex = 4;
            labelurun.Text = "Ürün";
            // 
            // txturun
            // 
            txturun.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txturun.Location = new Point(266, 161);
            txturun.Name = "txturun";
            txturun.Size = new Size(217, 31);
            txturun.TabIndex = 5;
            // 
            // kategori
            // 
            kategori.AutoSize = true;
            kategori.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            kategori.Location = new Point(520, 124);
            kategori.Name = "kategori";
            kategori.Size = new Size(96, 25);
            kategori.TabIndex = 6;
            kategori.Text = "Kategori";
            // 
            // txtfiyat
            // 
            txtfiyat.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtfiyat.Location = new Point(1055, 165);
            txtfiyat.Name = "txtfiyat";
            txtfiyat.Size = new Size(217, 31);
            txtfiyat.TabIndex = 9;
            // 
            // labelfiyat
            // 
            labelfiyat.AutoSize = true;
            labelfiyat.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            labelfiyat.Location = new Point(1055, 124);
            labelfiyat.Name = "labelfiyat";
            labelfiyat.Size = new Size(62, 25);
            labelfiyat.TabIndex = 8;
            labelfiyat.Text = "Fiyat";
            // 
            // txtstok
            // 
            txtstok.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtstok.Location = new Point(789, 165);
            txtstok.Name = "txtstok";
            txtstok.Size = new Size(217, 31);
            txtstok.TabIndex = 11;
            // 
            // labelstok
            // 
            labelstok.AutoSize = true;
            labelstok.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            labelstok.Location = new Point(789, 124);
            labelstok.Name = "labelstok";
            labelstok.Size = new Size(58, 25);
            labelstok.TabIndex = 10;
            labelstok.Text = "Stok";
            // 
            // comboBoxkategori
            // 
            comboBoxkategori.FormattingEnabled = true;
            comboBoxkategori.Location = new Point(520, 165);
            comboBoxkategori.Name = "comboBoxkategori";
            comboBoxkategori.Size = new Size(218, 28);
            comboBoxkategori.TabIndex = 12;
            comboBoxkategori.DropDown += comboBoxkategori_DropDown;
            comboBoxkategori.SelectedIndexChanged += comboBoxkategori_SelectedIndexChanged;
            // 
            // btnguncelle
            // 
            btnguncelle.BackColor = Color.White;
            btnguncelle.Font = new Font("Verdana", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnguncelle.Location = new Point(489, 262);
            btnguncelle.Name = "btnguncelle";
            btnguncelle.Size = new Size(136, 53);
            btnguncelle.TabIndex = 13;
            btnguncelle.Text = "Güncelle";
            btnguncelle.UseVisualStyleBackColor = false;
            btnguncelle.Click += btnguncelle_Click;
            // 
            // btnekle
            // 
            btnekle.Font = new Font("Verdana", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnekle.Location = new Point(715, 262);
            btnekle.Name = "btnekle";
            btnekle.Size = new Size(136, 53);
            btnekle.TabIndex = 14;
            btnekle.Text = "Ekle";
            btnekle.UseVisualStyleBackColor = true;
            btnekle.Click += btnekle_Click;
            // 
            // btnsil
            // 
            btnsil.BackColor = SystemColors.AppWorkspace;
            btnsil.Font = new Font("Verdana", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnsil.Location = new Point(966, 262);
            btnsil.Name = "btnsil";
            btnsil.Size = new Size(136, 53);
            btnsil.TabIndex = 15;
            btnsil.Text = "Sil";
            btnsil.UseVisualStyleBackColor = false;
            btnsil.Click += btnsil_Click;
            // 
            // guna2DataGridView1
            // 
            dataGridViewCellStyle4.BackColor = Color.White;
            guna2DataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            guna2DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            guna2DataGridView1.ColumnHeadersHeight = 4;
            guna2DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.White;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            guna2DataGridView1.DefaultCellStyle = dataGridViewCellStyle6;
            guna2DataGridView1.GridColor = Color.FromArgb(231, 229, 255);
            guna2DataGridView1.Location = new Point(364, 432);
            guna2DataGridView1.Name = "guna2DataGridView1";
            guna2DataGridView1.RowHeadersVisible = false;
            guna2DataGridView1.RowHeadersWidth = 51;
            guna2DataGridView1.Size = new Size(873, 353);
            guna2DataGridView1.TabIndex = 16;
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
            // labelurunliste
            // 
            labelurunliste.AutoSize = true;
            labelurunliste.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            labelurunliste.Location = new Point(719, 355);
            labelurunliste.Name = "labelurunliste";
            labelurunliste.Size = new Size(146, 25);
            labelurunliste.TabIndex = 17;
            labelurunliste.Text = "Ürün Listesi";
            // 
            // npgsqlDataAdapter1
            // 
            npgsqlDataAdapter1.DeleteCommand = null;
            npgsqlDataAdapter1.InsertCommand = null;
            npgsqlDataAdapter1.SelectCommand = null;
            npgsqlDataAdapter1.UpdateCommand = null;
            // 
            // urunadi
            // 
            urunadi.AutoSize = true;
            urunadi.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            urunadi.Location = new Point(405, 404);
            urunadi.Name = "urunadi";
            urunadi.Size = new Size(101, 25);
            urunadi.TabIndex = 18;
            urunadi.Text = "Ürün Adı";
            // 
            // kategorii
            // 
            kategorii.AutoSize = true;
            kategorii.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            kategorii.Location = new Point(573, 404);
            kategorii.Name = "kategorii";
            kategorii.Size = new Size(96, 25);
            kategorii.TabIndex = 19;
            kategorii.Text = "Kategori";
            // 
            // stokk
            // 
            stokk.AutoSize = true;
            stokk.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            stokk.Location = new Point(774, 404);
            stokk.Name = "stokk";
            stokk.Size = new Size(58, 25);
            stokk.TabIndex = 20;
            stokk.Text = "Stok";
            // 
            // fiyatt
            // 
            fiyatt.AutoSize = true;
            fiyatt.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            fiyatt.Location = new Point(999, 404);
            fiyatt.Name = "fiyatt";
            fiyatt.Size = new Size(62, 25);
            fiyatt.TabIndex = 21;
            fiyatt.Text = "Fiyat";
            // 
            // Giris1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1383, 748);
            Controls.Add(fiyatt);
            Controls.Add(stokk);
            Controls.Add(kategorii);
            Controls.Add(urunadi);
            Controls.Add(labelurunliste);
            Controls.Add(guna2DataGridView1);
            Controls.Add(btnsil);
            Controls.Add(btnekle);
            Controls.Add(btnguncelle);
            Controls.Add(comboBoxkategori);
            Controls.Add(txtstok);
            Controls.Add(labelstok);
            Controls.Add(txtfiyat);
            Controls.Add(labelfiyat);
            Controls.Add(kategori);
            Controls.Add(txturun);
            Controls.Add(labelurun);
            Controls.Add(panel3);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Giris1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Giris1";
            Load += Giris1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)guna2CirclePictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)guna2DataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Panel panel2;
        private Label cikis;
        private Label urunlabel;
        private Label kullanici;
        private Label labelstokdurum;
        private Label labelkategori;
        private Panel panel3;
        private Label label3;
        private Button btnguncelle;
        private ComboBox comboBoxkategori;
        private TextBox txtstok;
        private Label labelstok;
        private TextBox txtfiyat;
        private Label labelfiyat;
        private Label kategori;
        private TextBox txturun;
        private Label labelurun;
        private Label labelurunliste;
        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView1;
        private Button btnsil;
        private Button btnekle;
        private Label label11;
        private Npgsql.NpgsqlDataAdapter npgsqlDataAdapter1;
        private Label stokk;
        private Label kategorii;
        private Label urunadi;
        private Label fiyatt;
        private PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
    }
}