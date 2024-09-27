using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Profil : Form
    {
        private string kullaniciAdi;

        public Profil(string kullaniciAdi)
        {
            InitializeComponent();
            this.kullaniciAdi = kullaniciAdi;
        }




        private void Profil_Load(object sender, EventArgs e)
        {
            labelkullaniciad.Text = kullaniciAdi;
        }

        private void Kullanici_Load(object sender, EventArgs e)
        {
            pictureBox3.Paint += new PaintEventHandler(pictureBox3_Paint);
            pictureBox3.Click += new EventHandler(pictureBox3_Click);
        }
        private void pictureBox3_Paint(object sender, PaintEventArgs e)
        {
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddEllipse(0, 0, pictureBox3.Width, pictureBox3.Height);
            pictureBox3.Region = new Region(path);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox3.Image = Image.FromFile(openFileDialog.FileName);
            }
        }

      
    }
}
