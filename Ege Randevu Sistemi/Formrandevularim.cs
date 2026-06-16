using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Ege_Randevu_Sistemi
{
    public partial class Formrandevularim : Form
    {

        private const string baglantiYolu = "Server=localhost;Database=ege_randevu_db;Uid=root;Pwd=root";
        public Formrandevularim()
        {
            InitializeComponent();
        }

        private void lblrandevular_Click(object sender, EventArgs e)
        {

        }

        private void Formrandevularim_Load(object sender, EventArgs e)
        {
            BolumleriGetir();
            dtpfiltertarih.Checked = false;
            RandevulariFiltrele();
        }

        private void BolumleriGetir()
        {
            using (MySqlConnection baglanti = new MySqlConnection(baglantiYolu))
            {
                MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM bolumler", baglanti);
                DataTable dt = new DataTable();
                da.Fill(dt);

                // Görseldeki gibi listenin en başına "Tümü" seçeneğini ekliyoruz
                DataRow dr = dt.NewRow();
                dr["bolum_id"] = 0;
                dr["bolum_adi"] = "Tümü";
                dt.Rows.InsertAt(dr, 0);

                cmbfilterbolum.DataSource = dt;
                cmbfilterbolum.DisplayMember = "bolum_adi";
                cmbfilterbolum.ValueMember = "bolum_id";
            }

        }

        private void cmbfilterbolum_SelectedIndexChanged(object sender, EventArgs e)
        { }

        private void RandevulariFiltrele()
        {
            using (MySqlConnection baglanti = new MySqlConnection(baglantiYolu))
            {
                string sorgu = @"SELECT r.randevu_id, 
                               r.randevu_tarihi AS 'Tarih', 
                               r.randevu_saati AS 'Saat', 
                               b.bolum_adi AS 'Bölüm', 
                               d.ad_soyad AS 'Doktor',
                               IF(r.randevu_tarihi >= CURDATE(), 'Aktif', 'Geçmiş') AS 'Durum'
                        FROM randevular r
                        INNER JOIN doktorlar d ON r.doktor_id = d.doktor_id
                        INNER JOIN bolumler b ON d.bolum_id = b.bolum_id
                        WHERE r.hasta_id = @hastaId";

                // ComboBox değerlerini güvenli bir şekilde int tipine çeviriyoruz
                int bolumId = 0;
                if (cmbfilterbolum.SelectedValue != null)
                    int.TryParse(cmbfilterbolum.SelectedValue.ToString(), out bolumId);

                int doktorId = 0;
                if (cmbfilterdoktor.SelectedValue != null)
                    int.TryParse(cmbfilterdoktor.SelectedValue.ToString(), out doktorId);

                // Koşulları dinamik olarak sorguya ekliyoruz
                if (dtpfiltertarih.Checked)
                {
                    sorgu += " AND r.randevu_tarihi = @tarih";
                }
                if (bolumId > 0)
                {
                    sorgu += " AND d.bolum_id = @bolumId";
                }
                if (doktorId > 0)
                {
                    sorgu += " AND r.doktor_id = @doktorId";
                }

                sorgu += " ORDER BY r.randevu_tarihi ASC, r.randevu_saati ASC";

                using (MySqlCommand komut = new MySqlCommand(sorgu, baglanti))
                {
                    komut.Parameters.AddWithValue("@hastaId", Formgiris.girenhastaid);

                    if (dtpfiltertarih.Checked)
                        komut.Parameters.AddWithValue("@tarih", dtpfiltertarih.Value.ToString("yyyy-MM-dd"));
                    if (bolumId > 0)
                        komut.Parameters.AddWithValue("@bolumId", bolumId);
                    if (doktorId > 0)
                        komut.Parameters.AddWithValue("@doktorId", doktorId);

                    MySqlDataAdapter da = new MySqlDataAdapter(komut);
                    DataTable dt = new DataTable();
                    baglanti.Open();
                    da.Fill(dt);

                    dgvrandevular.DataSource = dt;

                    if (dgvrandevular.Columns["randevu_id"] != null)
                        dgvrandevular.Columns["randevu_id"].Visible = false;
                }
            }
        }

        private void btnara_Click(object sender, EventArgs e)
        {
            RandevulariFiltrele();
        }

        private void btntemizle_Click(object sender, EventArgs e)
        {
            dtpfiltertarih.Checked = false;
            cmbfilterbolum.SelectedIndex = 0;
            if (cmbfilterdoktor.Items.Count > 0) cmbfilterdoktor.SelectedIndex = 0;
            RandevulariFiltrele();
        }

        private void btniptalet_Click(object sender, EventArgs e)
        {
            if (dgvrandevular.CurrentRow == null)
            {
                MessageBox.Show("Lütfen iptal etmek istediğiniz randevuyu tablodan seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Seçilen satırdaki randevu_id'yi alıyoruz
            int randevuId = Convert.ToInt32(dgvrandevular.CurrentRow.Cells["randevu_id"].Value);
            string randevuDurumu = dgvrandevular.CurrentRow.Cells["Durum"].Value.ToString();

            if (randevuDurumu == "Geçmiş")
            {
                MessageBox.Show("Geçmiş tarihandling randevuları iptal edemezsiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult eminMisiniz = MessageBox.Show("Bu randevuyu iptal etmek istediğinize emin misiniz?", "Randevu İptali", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (eminMisiniz == DialogResult.Yes)
            {
                using (MySqlConnection baglanti = new MySqlConnection(baglantiYolu))
                {
                    string silmeSorgusu = "DELETE FROM randevular WHERE randevu_id = @rId";
                    using (MySqlCommand komut = new MySqlCommand(silmeSorgusu, baglanti))
                    {
                        komut.Parameters.AddWithValue("@rId", randevuId);
                        baglanti.Open();
                        komut.ExecuteNonQuery();

                        MessageBox.Show("Randevunuz başarıyla iptal edilmiştir.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        RandevulariFiltrele(); // Tabloyu yeniliyoruz
                    }
                }
            }
        }

        private void btndetay_Click(object sender, EventArgs e)
        {
            if (dgvrandevular.CurrentRow == null)
            {
                MessageBox.Show("Lütfen detayını görmek istediğiniz randevuyu seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string tarih = dgvrandevular.CurrentRow.Cells["Tarih"].Value.ToString();
            string saat = dgvrandevular.CurrentRow.Cells["Saat"].Value.ToString();
            string bolum = dgvrandevular.CurrentRow.Cells["Bölüm"].Value.ToString();
            string doktor = dgvrandevular.CurrentRow.Cells["Doktor"].Value.ToString();

            MessageBox.Show($"Randevu Detay Bilgisi:\n\nHasta: {Formgiris.hasta_adsoyad}\nBölüm: {bolum}\nDoktor: {doktor}\nTarih: {tarih}\nSaat: {saat}", "Randevu Detayı", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void cmbfilterbolum_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cmbfilterbolum.SelectedValue == null) return;

            int secilenBolumId;
            if (!int.TryParse(cmbfilterbolum.SelectedValue.ToString(), out secilenBolumId)) return;

            using (MySqlConnection baglanti = new MySqlConnection(baglantiYolu))
            {
                string sorgu = "SELECT * FROM doktorlar";
                if (secilenBolumId > 0) sorgu += " WHERE bolum_id = @bolumId";

                MySqlCommand komut = new MySqlCommand(sorgu, baglanti);
                if (secilenBolumId > 0) komut.Parameters.AddWithValue("@bolumId", secilenBolumId);

                MySqlDataAdapter da = new MySqlDataAdapter(komut);
                DataTable dt = new DataTable();
                da.Fill(dt);

                // Doktorların başına da "Tümü" seçeneği ekliyoruz
                DataRow dr = dt.NewRow();
                dr["doktor_id"] = 0;
                dr["ad_soyad"] = "Tümü";
                dt.Rows.InsertAt(dr, 0);

                // Aynı kural doktor ComboBox'ı için de geçerli: DataSource en sona!
                cmbfilterdoktor.DisplayMember = "ad_soyad";
                cmbfilterdoktor.ValueMember = "doktor_id";
                cmbfilterdoktor.DataSource = dt;
            }
        }
    }
}
