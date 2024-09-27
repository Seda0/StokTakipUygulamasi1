namespace WinFormsApp1
{
    partial class Kategorii
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kategorii));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            panel1 = new Panel();
            guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            kullanici = new Label();
            labelstokdurum = new Label();
            labelkategori = new Label();
            urunlabel = new Label();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            cikis = new Label();
            panel3 = new Panel();
            label11 = new Label();
            label3 = new Label();
            txtkategori = new TextBox();
            labelkatego = new Label();
            btnsil = new Button();
            btnekle = new Button();
            btnguncelle = new Button();
            guna2DataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            labelurunliste = new Label();
            label1 = new Label();
            label2 = new Label();
            txtyeni = new TextBox();
            yenikategori = new Label();
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
            panel1.Size = new Size(239, 795);
            panel1.TabIndex = 1;
            // 
            // guna2CirclePictureBox1
            // 
            guna2CirclePictureBox1.BackgroundImageLayout = ImageLayout.None;
            guna2CirclePictureBox1.BorderStyle = BorderStyle.Fixed3D;
            guna2CirclePictureBox1.Image = (Image)resources.GetObject("guna2CirclePictureBox1.Image");
            guna2CirclePictureBox1.ImageRotate = 0F;
            guna2CirclePictureBox1.Location = new Point(55, 12);
            guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            guna2CirclePictureBox1.ShadowDecoration.CustomizableEdges = customizableEdges1;
            guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            guna2CirclePictureBox1.Size = new Size(118, 107);
            guna2CirclePictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            guna2CirclePictureBox1.TabIndex = 23;
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
            urunlabel.Click += urunlabel_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(cikis);
            panel2.Location = new Point(3, 735);
            panel2.Name = "panel2";
            panel2.Size = new Size(236, 57);
            panel2.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(23, 3);
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
            cikis.Location = new Point(89, 14);
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
            panel3.Size = new Size(1162, 57);
            panel3.TabIndex = 4;
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
            // txtkategori
            // 
            txtkategori.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtkategori.Location = new Point(505, 161);
            txtkategori.Name = "txtkategori";
            txtkategori.Size = new Size(217, 31);
            txtkategori.TabIndex = 7;
            // 
            // labelkatego
            // 
            labelkatego.AutoSize = true;
            labelkatego.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            labelkatego.Location = new Point(510, 106);
            labelkatego.Name = "labelkatego";
            labelkatego.Size = new Size(96, 25);
            labelkatego.TabIndex = 6;
            labelkatego.Text = "Kategori";
            // 
            // btnsil
            // 
            btnsil.BackColor = SystemColors.AppWorkspace;
            btnsil.Font = new Font("Verdana", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnsil.Location = new Point(947, 262);
            btnsil.Name = "btnsil";
            btnsil.Size = new Size(136, 53);
            btnsil.TabIndex = 18;
            btnsil.Text = "Sil";
            btnsil.UseVisualStyleBackColor = false;
            btnsil.Click += btnsil_Click;
            // 
            // btnekle
            // 
            btnekle.Font = new Font("Verdana", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnekle.Location = new Point(696, 262);
            btnekle.Name = "btnekle";
            btnekle.Size = new Size(136, 53);
            btnekle.TabIndex = 17;
            btnekle.Text = "Ekle";
            btnekle.UseVisualStyleBackColor = true;
            btnekle.Click += btnekle_Click;
            // 
            // btnguncelle
            // 
            btnguncelle.BackColor = Color.White;
            btnguncelle.Font = new Font("Verdana", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnguncelle.Location = new Point(470, 262);
            btnguncelle.Name = "btnguncelle";
            btnguncelle.Size = new Size(136, 53);
            btnguncelle.TabIndex = 16;
            btnguncelle.Text = "Güncelle";
            btnguncelle.UseVisualStyleBackColor = false;
            btnguncelle.Click += btnguncelle_Click;
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
            guna2DataGridView1.Location = new Point(505, 470);
            guna2DataGridView1.Name = "guna2DataGridView1";
            guna2DataGridView1.RowHeadersVisible = false;
            guna2DataGridView1.RowHeadersWidth = 51;
            guna2DataGridView1.Size = new Size(510, 313);
            guna2DataGridView1.TabIndex = 19;
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
            labelurunliste.Location = new Point(645, 373);
            labelurunliste.Name = "labelurunliste";
            labelurunliste.Size = new Size(187, 25);
            labelurunliste.TabIndex = 20;
            labelurunliste.Text = "Kategori Listesi";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.Location = new Point(787, 422);
            label1.Name = "label1";
            label1.Size = new Size(135, 25);
            label1.TabIndex = 21;
            label1.Text = "Kategori Adı";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label2.Location = new Point(529, 422);
            label2.Name = "label2";
            label2.Size = new Size(123, 25);
            label2.TabIndex = 22;
            label2.Text = "Kategori Id";
            // 
            // txtyeni
            // 
            txtyeni.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtyeni.Location = new Point(798, 161);
            txtyeni.Name = "txtyeni";
            txtyeni.Size = new Size(217, 31);
            txtyeni.TabIndex = 23;
            // 
            // yenikategori
            // 
            yenikategori.AutoSize = true;
            yenikategori.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            yenikategori.Location = new Point(798, 106);
            yenikategori.Name = "yenikategori";
            yenikategori.Size = new Size(152, 25);
            yenikategori.TabIndex = 24;
            yenikategori.Text = " Yeni Kategori";
            // 
            // Kategorii
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1401, 795);
            Controls.Add(yenikategori);
            Controls.Add(txtyeni);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(labelurunliste);
            Controls.Add(guna2DataGridView1);
            Controls.Add(btnsil);
            Controls.Add(btnekle);
            Controls.Add(btnguncelle);
            Controls.Add(txtkategori);
            Controls.Add(labelkatego);
            Controls.Add(panel3);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Kategorii";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kategorii";
            Load += Kategorii_Load;
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
        private Label kullanici;
        private Label labelstokdurum;
        private Label labelkategori;
        private Label urunlabel;
        private Panel panel2;
        private Label cikis;
        private Panel panel3;
        private Label label11;
        private Label label3;
        private TextBox txtkategori;
        private Label labelkatego;
        private Button btnsil;
        private Button btnekle;
        private Button btnguncelle;
        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView1;
        private Label labelurunliste;
        private Label label1;
        private Label label2;
        private TextBox txtyeni;
        private Label yenikategori;
        private PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
    }
}