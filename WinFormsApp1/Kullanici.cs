using Npgsql;
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
    public partial class Kullanici : Form
    {
        public Kullanici()
        {
            InitializeComponent();
        }

        private void Kullanici_Load(object sender, EventArgs e)
        {

        }

        private void labelkayıt_Click(object sender, EventArgs e)
        {
            Kayit kayitform = new Kayit();
            kayitform.Show();
        }

        private void btngiris_Click(object sender, EventArgs e)
        {
            string connectionString = "Host=localhost;Username=postgres;Password=1234;Database=dbstoktakip";
            using (var conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM kullanicilar WHERE kullaniciad = @kullaniciad AND parola = @parola";
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("kullaniciad", txtad.Text);
                    cmd.Parameters.AddWithValue("parola", txtsifree.Text);
                    int userCount = Convert.ToInt32(cmd.ExecuteScalar());
                    if (userCount > 0)
                    {
                        Giris1 girisform = new Giris1();
                        girisform.Show();
                    }
                    else
                    {
                        MessageBox.Show("Kullanıcı adı veya şifre yanlış.");
                    }
                }
            }
        
    }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label11_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
