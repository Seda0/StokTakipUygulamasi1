using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace WinFormsApp1
{
    public partial class Kayit : Form
    {
        public Kayit()
        {
            InitializeComponent();
        }

        private void labelgiris_Click(object sender, EventArgs e)
        {
            Kullanici girform = new Kullanici();
            girform.Show();
        }

        private void btnkayıt_Click(object sender, EventArgs e)
        {
            // TextBox'lardaki verileri alıyoruz
            string kullaniciad = txtkullaniciad.Text;
            string parola = txtsifre.Text;

            // PostgreSQL bağlantı dizesi (sizin veritabanı bilgilerinize göre düzenlemeniz gerekir)
            string connString = "Host=localhost;Username=postgres;Password=1234;Database=dbstoktakip";

            // Bağlantı nesnesi
            using (var conn = new NpgsqlConnection(connString))
            {
                try
                {
                    conn.Open(); // Bağlantıyı açıyoruz

                    // SQL komutunu hazırlıyoruz
                    string sql = "INSERT INTO kullanicilar (kullaniciad, parola) VALUES (@kullaniciad, @parola)";

                    // SQL komutunu çalıştırmak için bir NpgsqlCommand oluşturuyoruz
                    using (var cmd = new NpgsqlCommand(sql, conn))
                    {
                        // Parametreleri ekliyoruz
                        cmd.Parameters.AddWithValue("kullaniciad", kullaniciad);
                        cmd.Parameters.AddWithValue("parola", parola);

                        // Komutu çalıştırıyoruz
                        int result = cmd.ExecuteNonQuery();

                        if (result > 0)
                        {
                            MessageBox.Show("Kayıt başarıyla eklendi.");
                        }
                        else
                        {
                            MessageBox.Show("Kayıt eklenemedi.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }
        }

        private void label11_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
