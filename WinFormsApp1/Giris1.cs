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
    public partial class Giris1 : Form
    {
        private string? connectionString;

        public Giris1()
        {
            InitializeComponent();
            LoadData();
            LoadCategories();
            comboBoxkategori.DropDown += comboBoxkategori_DropDown;

        }

        private void LoadData(string category = null)
        {
            string connectionString = "Host=localhost;Username=postgres;Password=1234;Database=dbstoktakip";

            using (var connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                string query = @"SELECT u.urunad, k.kategoriad, u.stok, u.fiyat 
                         FROM urunler u
                         JOIN kategoriler k ON u.kategoriid = k.kategoriid";

                if (category != null)
                {
                    query += " WHERE k.kategoriad = @kategoriad";
                }

                using (var command = new NpgsqlCommand(query, connection))
                {
                    if (category != null)
                    {
                        command.Parameters.AddWithValue("kategoriad", category);
                    }

                    using (var reader = command.ExecuteReader())
                    {
                        DataTable datatable = new DataTable();
                        datatable.Load(reader);
                        guna2DataGridView1.DataSource = datatable;
                    }
                }
            }
        }

        private void LoadCategories()
        {
            string connectionString = "Host=localhost;Username=postgres;Password=1234;Database=dbstoktakip";

            using (var connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT DISTINCT kategoriad FROM kategoriler";
                using (var command = new NpgsqlCommand(query, connection))
                using (var reader = command.ExecuteReader())
                {
                    comboBoxkategori.Items.Clear();
                    while (reader.Read())
                    {
                        comboBoxkategori.Items.Add(reader.GetString(0));
                    }
                }
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

        private void label2_Click(object sender, EventArgs e)
        {
            Giris1 girisform = new Giris1();
            girisform.Show();
        }

        private void labelkategori_Click(object sender, EventArgs e)
        {
            Kategorii kategoriForm = new Kategorii();
            kategoriForm.Show();
        }

        private void comboBoxkategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedCategory = comboBoxkategori.SelectedItem.ToString();
            LoadData(selectedCategory);
        }

        private void comboBoxkategori_DropDown(object sender, EventArgs e)
        {
            LoadCategories();

        }
        private void btnekle_Click(object sender, EventArgs e)
        {
            string urunad = txturun.Text;

            if (comboBoxkategori.SelectedItem == null)
            {
                MessageBox.Show("Lütfen bir kategori seçiniz.");
                return;
            }

            string kategoriad = comboBoxkategori.SelectedItem.ToString();

            decimal fiyat;
            int stok;

            if (!decimal.TryParse(txtfiyat.Text, out fiyat))
            {
                MessageBox.Show("Lütfen geçerli bir fiyat giriniz.");
                return;
            }

            if (!int.TryParse(txtstok.Text, out stok))
            {
                MessageBox.Show("Lütfen geçerli bir stok miktarı giriniz.");
                return;
            }

            string connectionString = "Host=localhost;Username=postgres;Password=1234;Database=dbstoktakip";
            using (var connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();


                string queryKategoriId = "SELECT kategoriid FROM kategoriler WHERE kategoriad = @kategoriad";
                int kategoriid;

                using (var commandKategori = new NpgsqlCommand(queryKategoriId, connection))
                {
                    commandKategori.Parameters.AddWithValue("@kategoriad", kategoriad);
                    var result = commandKategori.ExecuteScalar();

                    if (result != null)
                    {
                        kategoriid = (int)result;
                    }
                    else
                    {
                        MessageBox.Show("Seçilen kategori mevcut değil.");
                        return;
                    }
                }

                // Ürünü ekle
                string queryInsertUrun = "INSERT INTO urunler (urunad, kategoriid, fiyat, stok) VALUES (@urunad, @kategoriid, @fiyat, @stok)";

                using (var commandUrun = new NpgsqlCommand(queryInsertUrun, connection))
                {
                    commandUrun.Parameters.AddWithValue("@urunad", urunad);
                    commandUrun.Parameters.AddWithValue("@kategoriid", kategoriid);
                    commandUrun.Parameters.AddWithValue("@fiyat", fiyat);
                    commandUrun.Parameters.AddWithValue("@stok", stok);

                    try
                    {
                        int rowsAffected = commandUrun.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Ürün başarıyla eklendi.");
                            LoadData();
                        }
                        else
                        {
                            MessageBox.Show("Ürün eklenirken bir hata oluştu.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Hata: " + ex.Message);
                    }
                }
            }
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {

            string urunad = txturun.Text;


            if (comboBoxkategori.SelectedItem == null)
            {
                MessageBox.Show("Lütfen bir kategori seçiniz.");
                return;
            }

            string kategoriad = comboBoxkategori.SelectedItem.ToString();

            decimal fiyat;
            int stok;


            if (!decimal.TryParse(txtfiyat.Text, out fiyat))
            {
                MessageBox.Show("Lütfen geçerli bir fiyat giriniz.");
                return;
            }

            if (!int.TryParse(txtstok.Text, out stok))
            {
                MessageBox.Show("Lütfen geçerli bir stok miktarı giriniz.");
                return;
            }

            string connectionString = "Host=localhost;Username=postgres;Password=1234;Database=dbstoktakip";
            using (var connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();


                string queryKategoriId = "SELECT kategoriid FROM kategoriler WHERE kategoriad = @kategoriad";
                int kategoriid;

                using (var commandKategori = new NpgsqlCommand(queryKategoriId, connection))
                {
                    commandKategori.Parameters.AddWithValue("@kategoriad", kategoriad);
                    var result = commandKategori.ExecuteScalar();

                    if (result != null)
                    {
                        kategoriid = (int)result;
                    }
                    else
                    {
                        MessageBox.Show("Seçilen kategori mevcut değil.");
                        return;
                    }
                }

                // Ürünü güncelle
                string queryUpdateUrun = @"
            UPDATE urunler
            SET kategoriid = @kategoriid, fiyat = @fiyat, stok = @stok
            WHERE urunad = @urunad AND kategoriid = @kategoriid";

                using (var commandUrun = new NpgsqlCommand(queryUpdateUrun, connection))
                {
                    commandUrun.Parameters.AddWithValue("@urunad", urunad);
                    commandUrun.Parameters.AddWithValue("@kategoriid", kategoriid);
                    commandUrun.Parameters.AddWithValue("@fiyat", fiyat);
                    commandUrun.Parameters.AddWithValue("@stok", stok);

                    try
                    {
                        int rowsAffected = commandUrun.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Ürün başarıyla güncellendi.");
                            LoadData();
                        }
                        else
                        {
                            MessageBox.Show("Ürün güncellenirken bir hata oluştu.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Hata: " + ex.Message);
                    }
                }
            }
        }

        private void btnsil_Click(object sender, EventArgs e)
        {


            string urunad = txturun.Text;


            if (comboBoxkategori.SelectedItem == null)
            {
                MessageBox.Show("Lütfen bir kategori seçiniz.");
                return;
            }

            string kategoriad = comboBoxkategori.SelectedItem.ToString();

            string connectionString = "Host=localhost;Username=postgres;Password=1234;Database=dbstoktakip";
            using (var connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();


                string queryKategoriId = "SELECT kategoriid FROM kategoriler WHERE kategoriad = @kategoriad";
                int kategoriid;

                using (var commandKategori = new NpgsqlCommand(queryKategoriId, connection))
                {
                    commandKategori.Parameters.AddWithValue("@kategoriad", kategoriad);
                    var result = commandKategori.ExecuteScalar();

                    if (result != null)
                    {
                        kategoriid = (int)result;
                    }
                    else
                    {
                        MessageBox.Show("Seçilen kategori mevcut değil.");
                        return;
                    }
                }

                // Ürünü sil
                string queryDeleteUrun = @"
            DELETE FROM urunler
            WHERE urunad = @urunad AND kategoriid = @kategoriid";

                using (var commandUrun = new NpgsqlCommand(queryDeleteUrun, connection))
                {
                    commandUrun.Parameters.AddWithValue("@urunad", urunad);
                    commandUrun.Parameters.AddWithValue("@kategoriid", kategoriid);

                    try
                    {
                        int rowsAffected = commandUrun.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Ürün başarıyla silindi.");
                            LoadData();
                        }
                        else
                        {
                            MessageBox.Show("Ürün silinirken bir hata oluştu.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Hata: " + ex.Message);
                    }
                }
            }
        }

        private void labelstokdurum_Click(object sender, EventArgs e)
        {
            Stok stokForm = new Stok();
            stokForm.Show();
        }
        private void Giris1_Load(object sender, EventArgs e)
        {

        }

        private void kullanici_Click(object sender, EventArgs e)
        {
            Profil profilForm = new Profil();
            profilForm.Show();
        }
    }
}
