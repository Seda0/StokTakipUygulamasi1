namespace WinFormsApp1
{
    partial class Kullanici
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kullanici));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panel1 = new Panel();
            panel4 = new Panel();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            label1 = new Label();
            labelstokdurum = new Label();
            labelkategori = new Label();
            urunlabel = new Label();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            cikis = new Label();
            panel3 = new Panel();
            label11 = new Label();
            label3 = new Label();
            labelsifre = new Label();
            txtsifree = new TextBox();
            btngiris = new Button();
            txtad = new TextBox();
            labelkullanici = new Label();
            labelkayıt = new Label();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)guna2CirclePictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.MediumSlateBlue;
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(guna2CirclePictureBox1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(labelstokdurum);
            panel1.Controls.Add(labelkategori);
            panel1.Controls.Add(urunlabel);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(239, 715);
            panel1.TabIndex = 2;
            // 
            // panel4
            // 
            panel4.Controls.Add(pictureBox2);
            panel4.Controls.Add(label2);
            panel4.Location = new Point(3, 644);
            panel4.Name = "panel4";
            panel4.Size = new Size(236, 57);
            panel4.TabIndex = 24;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(9, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(60, 46);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 44;
            pictureBox2.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label2.ForeColor = Color.White;
            label2.Location = new Point(89, 14);
            label2.Name = "label2";
            label2.Size = new Size(60, 25);
            label2.TabIndex = 2;
            label2.Text = "Çıkış";
            label2.Click += label2_Click;
            // 
            // guna2CirclePictureBox1
            // 
            guna2CirclePictureBox1.BackgroundImageLayout = ImageLayout.None;
            guna2CirclePictureBox1.BorderStyle = BorderStyle.Fixed3D;
            guna2CirclePictureBox1.Image = (Image)resources.GetObject("guna2CirclePictureBox1.Image");
            guna2CirclePictureBox1.ImageRotate = 0F;
            guna2CirclePictureBox1.Location = new Point(55, 12);
            guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            guna2CirclePictureBox1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            guna2CirclePictureBox1.Size = new Size(118, 107);
            guna2CirclePictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            guna2CirclePictureBox1.TabIndex = 23;
            guna2CirclePictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.White;
            label1.Location = new Point(43, 404);
            label1.Name = "label1";
            label1.Size = new Size(98, 25);
            label1.TabIndex = 2;
            label1.Text = "Kullanıcı";
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
            // 
            // panel3
            // 
            panel3.BackColor = Color.MediumSlateBlue;
            panel3.Controls.Add(label11);
            panel3.Controls.Add(label3);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(239, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1126, 57);
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
            // labelsifre
            // 
            labelsifre.AutoSize = true;
            labelsifre.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            labelsifre.Location = new Point(860, 274);
            labelsifre.Name = "labelsifre";
            labelsifre.Size = new Size(60, 25);
            labelsifre.TabIndex = 31;
            labelsifre.Text = "Şifre";
            // 
            // txtsifree
            // 
            txtsifree.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtsifree.Location = new Point(860, 329);
            txtsifree.Name = "txtsifree";
            txtsifree.Size = new Size(217, 31);
            txtsifree.TabIndex = 30;
            // 
            // btngiris
            // 
            btngiris.Font = new Font("Verdana", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btngiris.Location = new Point(740, 415);
            btngiris.Name = "btngiris";
            btngiris.Size = new Size(136, 53);
            btngiris.TabIndex = 28;
            btngiris.Text = "Giriş";
            btngiris.UseVisualStyleBackColor = true;
            btngiris.Click += btngiris_Click;
            // 
            // txtad
            // 
            txtad.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtad.Location = new Point(567, 329);
            txtad.Name = "txtad";
            txtad.Size = new Size(217, 31);
            txtad.TabIndex = 26;
            // 
            // labelkullanici
            // 
            labelkullanici.AutoSize = true;
            labelkullanici.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            labelkullanici.Location = new Point(572, 274);
            labelkullanici.Name = "labelkullanici";
            labelkullanici.Size = new Size(137, 25);
            labelkullanici.TabIndex = 25;
            labelkullanici.Text = "Kullanıcı Adı";
            // 
            // labelkayıt
            // 
            labelkayıt.AutoSize = true;
            labelkayıt.Font = new Font("Verdana", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            labelkayıt.Location = new Point(776, 488);
            labelkayıt.Name = "labelkayıt";
            labelkayıt.Size = new Size(67, 20);
            labelkayıt.TabIndex = 32;
            labelkayıt.Text = "Kaydol";
            labelkayıt.Click += labelkayıt_Click;
            // 
            // Kullanici
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1365, 715);
            Controls.Add(labelkayıt);
            Controls.Add(labelsifre);
            Controls.Add(txtsifree);
            Controls.Add(btngiris);
            Controls.Add(txtad);
            Controls.Add(labelkullanici);
            Controls.Add(panel3);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Kullanici";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kullanici";
            Load += Kullanici_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)guna2CirclePictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private Label label1;
        private Label labelstokdurum;
        private Label labelkategori;
        private Label urunlabel;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Label cikis;
        private Panel panel3;
        private Label label11;
        private Label label3;
        private Panel panel4;
        private PictureBox pictureBox2;
        private Label label2;
        private Label labelsifre;
        private TextBox txtsifree;
        private Button btngiris;
        private TextBox txtad;
        private Label labelkullanici;
        private Label labelkayıt;
    }
}