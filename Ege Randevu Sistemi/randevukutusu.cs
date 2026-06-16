using MySql.Data.MySqlClient;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Ege_Randevu_Sistemi
{
    public partial class randevukutusu : UserControl
    {
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int doktorid { get; set; }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public DateTime SecilenTarih { get; set; }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string Saat { get; set; }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string Gun
        {
            get { return lblGun.Text; }
            set { lblGun.Text = value; }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string Tarih
        {
            get { return lblTarih.Text; }
            set { lblTarih.Text = value; }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string Doktor
        {
            get { return lblDoktor.Text; }
            set { lblDoktor.Text = value; }
        }

        public void DurumAyarla(bool doluMu)
        {
            if (doluMu)
            {
                btnDurum.Text = "DOLU";
                btnDurum.BackColor = Color.IndianRed;
                btnDurum.ForeColor = Color.White;
                btnDurum.Enabled = false;
                this.BackColor = Color.LightCoral;
            }
            else
            {
                btnDurum.Text = "Talep Et";
                btnDurum.BackColor = Color.MediumSeaGreen;
                btnDurum.ForeColor = Color.White;
                btnDurum.Enabled = true;
                this.BackColor = Color.Honeydew;
            }
        }

        public randevukutusu()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e) { }

        private void btnDurum_Click(object sender, EventArgs e)
        {
            DialogResult onay = MessageBox.Show("Bu randevuyu onaylıyor musunuz?", "Randevu Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (onay == DialogResult.Yes)
            {
                try
                {
                    MySqlConnection baglanti = new MySqlConnection("Server=localhost;Database=ege_randevu_db;Uid=root;Pwd=root;");
                    baglanti.Open();

                    string sqlTarih = SecilenTarih.ToString("yyyy-MM-dd");

                    string sorgu = "INSERT INTO randevular (hasta_id, doktor_id, randevu_tarihi, randevu_saati) VALUES (@hId, @dId, @tar, @saat)";
                    MySqlCommand komut = new MySqlCommand(sorgu, baglanti);
                    komut.Parameters.AddWithValue("@hId", Formgiris.girenhastaid);
                    komut.Parameters.AddWithValue("@dId", this.doktorid);
                    komut.Parameters.AddWithValue("@tar", sqlTarih);
                    komut.Parameters.AddWithValue("@saat", this.Saat);

                    komut.ExecuteNonQuery();
                    baglanti.Close();

                    MessageBox.Show("Randevunuz başarıyla alınmıştır!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DurumAyarla(true);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }
        }
    }
}
