using System;
using Npgsql;
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
    public partial class Stok : Form
    {
        public Stok()
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.Stok_Load);
        }

        private void Stok_Load(object sender, EventArgs e)
        {

            string connectionString = "Host=localhost;Username=postgres;Password=1234;Database=dbstoktakip";

            using (var conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();

                using (var cmd = new NpgsqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = @"
                SELECT 
                    stokdurum.stokid AS ""Stok ID"",
                    urunler.urunad AS ""Ürün Adı"",
                    stokdurum.harekettarihi AS ""Hareket Tarihi"",
                    stokdurum.mevcutstok AS ""Mevcut Stok"",
                    stokdurum.harekettipi AS ""Hareket Tipi"",
                    stokdurum.miktar AS ""Miktar""
                FROM stokdurum
                JOIN urunler ON stokdurum.urunid = urunler.urunid";

                    using (var reader = cmd.ExecuteReader())
                    {
                        DataTable dt = new DataTable();
                        dt.Load(reader);
                        guna2DataGridView1.DataSource = dt;

                        guna2DataGridView1.Columns["Stok ID"].HeaderText = "Stok ID";
                        guna2DataGridView1.Columns["Ürün Adı"].HeaderText = "Ürün Adı";
                        guna2DataGridView1.Columns["Hareket Tarihi"].HeaderText = "Hareket Tarihi";
                        guna2DataGridView1.Columns["Mevcut Stok"].HeaderText = "Mevcut Stok";
                        guna2DataGridView1.Columns["Hareket Tipi"].HeaderText = "Hareket Tipi";
                        guna2DataGridView1.Columns["Miktar"].HeaderText = "Miktar";
                    }
                }
            }
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {

            string connectionString = "Host=localhost;Username=postgres;Password=1234;Database=dbstoktakip";
            int stokid;
            string hareket = txthareket.Text;
            int miktar;

          
            if (int.TryParse(txtstokid.Text, out stokid) &&
                int.TryParse(txtmiktar.Text, out miktar))
            {
                using (var conn = new NpgsqlConnection(connectionString))
                {
                    conn.Open();

                    
                    using (var cmd = new NpgsqlCommand())
                    {
                        cmd.Connection = conn;
                        cmd.CommandText = @"
                    SELECT mevcutstok 
                    FROM stokdurum 
                    WHERE stokid = @stokid";
                        cmd.Parameters.AddWithValue("stokid", stokid);

                        int mevcutStok = 0;
                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                mevcutStok = reader.GetInt32(0);
                            }
                        }
                        int yeniStok;
                        if (hareket == "giriş")
                        {
                            yeniStok = mevcutStok + miktar;
                        }
                        else if (hareket == "çıkış")
                        {
                            yeniStok = mevcutStok - miktar;
                        }
                        else
                        {
                            MessageBox.Show("Hareket türü 'giriş' veya 'çıkış' olmalıdır.");
                            return;
                        }

                        cmd.CommandText = @"
                    UPDATE stokdurum 
                    SET mevcutstok = @yeniStok, harekettipi = @harekettipi, miktar = @miktar 
                    WHERE stokid = @stokid";
                        cmd.Parameters.AddWithValue("yeniStok", yeniStok);
                        cmd.Parameters.AddWithValue("harekettipi", hareket);
                        cmd.Parameters.AddWithValue("miktar", miktar);
                        cmd.ExecuteNonQuery();
                    }

                    
                    using (var cmd = new NpgsqlCommand())
                    {
                        cmd.Connection = conn;
                        cmd.CommandText = @"
                    SELECT 
                        stokdurum.stokid AS ""Stok ID"",
                        urunler.urunad AS ""Ürün Adı"",
                        stokdurum.harekettarihi AS ""Hareket Tarihi"",
                        stokdurum.mevcutstok AS ""Mevcut Stok"",
                        stokdurum.harekettipi AS ""Hareket Tipi"",
                        stokdurum.miktar AS ""Miktar""
                    FROM stokdurum
                    JOIN urunler ON stokdurum.urunid = urunler.urunid";

                        using (var reader = cmd.ExecuteReader())
                        {
                            DataTable dt = new DataTable();
                            dt.Load(reader);
                            guna2DataGridView1.DataSource = dt;
                        }
                    }
                }
                MessageBox.Show("Stok bilgileri başarıyla güncellendi.");
            }
            else
            {
                MessageBox.Show("Lütfen geçerli bir stok ID'si ve miktar giriniz.");
            }
        }

        private void label11_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
    }
}
