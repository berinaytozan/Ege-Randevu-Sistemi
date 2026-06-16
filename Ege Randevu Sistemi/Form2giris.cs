using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Ege_Randevu_Sistemi
{
    public partial class Formgiris : Form
    {
        public static string hasta_tc = "";
        public static string hasta_adsoyad = "";
        public static string hasta_telefon = "";
        public static int girenhastaid;



        private const string baglantiCumlesi = "Server=localhost;Database=ege_randevu_db;Uid=root;Pwd=root";

        public Formgiris()
        {
            InitializeComponent();
        }

        private void Formgiris_Load(object sender, EventArgs e)
        {
            txtkimlik.UseSystemPasswordChar = true;

        }

        private void btngiris_Click(object sender, EventArgs e)
        {
            string tc = txtkimlik.Text.Replace(" ", "");
            if (tc.Length != 11)
            {
                MessageBox.Show("Lütfen 11 haneli TC Kimlik Numaranızı eksiksiz girin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // --- 1. Boşluk kontrolü ---
            if (string.IsNullOrWhiteSpace(txtadsoyad.Text) || string.IsNullOrWhiteSpace(txttelefon.Text))
            {
                MessageBox.Show(
                    "Lütfen Ad Soyad ve Telefon bilgilerini eksiksiz girin.",
                    "Uyarı",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            // --- 2. Telefon format kontrolü (sadece rakam, 05 ile başlayan, 11 hane) ---
            string telefon = txttelefon.Text.Trim();
            if (!telefon.StartsWith("05") || telefon.Length != 11
                )
            {
                MessageBox.Show(
                    "Lütfen telefon numaranızı '05' ile başlayan 11 haneli formatta girin.\nÖrnek: 05321234567",
                    "Hatalı Format",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            // --- 3. Veritabanı işlemleri ---
            try
            {
                using (MySqlConnection baglanti = new MySqlConnection(baglantiCumlesi))
                {
                    baglanti.Open();

                    // Önce aynı telefon numarasıyla kayıtlı hasta var mı kontrol et
                    string sorgu = "SELECT hasta_id, ad_soyad, telefon FROM hastalar WHERE tc_kimlik = @tc LIMIT 1";
                    MySqlCommand sorguKomut = new MySqlCommand(sorgu, baglanti);
                    sorguKomut.Parameters.AddWithValue("@tc", tc);

                    using (MySqlDataReader dr = sorguKomut.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            // Hasta zaten var → mevcut kaydı kullan
                            girenhastaid = Convert.ToInt32(dr["hasta_id"]);
                            hasta_adsoyad = dr["ad_soyad"].ToString();
                            hasta_telefon = telefon;
                        }
                        else
                        {
                            // Hasta yok → yeni kayıt ekle
                            dr.Close();

                            MySqlCommand ekleKomut = new MySqlCommand(
                        "INSERT INTO hastalar (tc_kimlik, ad_soyad, telefon) VALUES (@tc, @ad, @tel)",
                        baglanti);
                            ekleKomut.Parameters.AddWithValue("@tc", tc);
                            ekleKomut.Parameters.AddWithValue("@ad", txtadsoyad.Text.Trim());
                            ekleKomut.Parameters.AddWithValue("@tel", telefon);
                            ekleKomut.ExecuteNonQuery();

                            girenhastaid = Convert.ToInt32(ekleKomut.LastInsertedId);
                            hasta_adsoyad = txtadsoyad.Text.Trim();
                            hasta_telefon = telefon;
                            hasta_tc = tc;
                        }
                    }
                } // using → bağlantı otomatik kapanır

                // --- 4. Ana ekrana geç ---
                Form1 anaekran = new Form1();
                anaekran.Show();
                this.Hide();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(
                    "Veritabanı bağlantısında hata oluştu:\n" + ex.Message,
                    "Bağlantı Hatası",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Beklenmeyen bir hata oluştu:\n" + ex.Message,
                    "Hata",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void txttelefon_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Sadece rakam ve kontrol karakterlerine (Backspace gibi) izin ver
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}