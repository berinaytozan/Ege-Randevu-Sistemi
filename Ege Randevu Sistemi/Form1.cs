using MySql.Data.MySqlClient;

namespace Ege_Randevu_Sistemi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void label3_Click(object sender, EventArgs e) { }
        private void pictureBox2_Click(object sender, EventArgs e) { }
        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

            if (e.Node != null && e.Node.Parent != null)
            {
                // Seçilen doktorun ID'sini al
                int dId = Convert.ToInt32(e.Node.Tag);

                // Ekrandaki mevcut tarih ile seçilen doktorun randevularını getir
                RandevuSaatleriniGetir(dId, dtpTarih.Value);

                // Ekran geçişini yap: Doktor listesini gizle, randevu panelini göster
                treeView1.Visible = false;
                flowLayoutPanel1.Visible = true;


            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            lblhastaadi.Text = "AD SOYAD";
            lblhastatelefon.Text = "TELEFON";

            // Giriş ekranındaki static değişkenlerden hasta bilgisini al ve üst label'lara yaz
            lblhastaadi.Text = Formgiris.hasta_adsoyad + " - Hasta Bilgileri";
            lblhastatelefon.Text = Formgiris.hasta_telefon;




            MySqlConnection baglanti = new MySqlConnection("Server=localhost;Database=ege_randevu_db;Uid=root;Pwd=root");
            baglanti.Open();

            MySqlCommand komut = new MySqlCommand("SELECT * FROM bolumler", baglanti);
            MySqlDataReader dr = komut.ExecuteReader();

            treeView1.Nodes.Clear();// Her yüklemede temiz başla, eski düğümler çift görünmesin

            while (dr.Read())
            {
                TreeNode dal = new TreeNode(dr["bolum_adi"].ToString());
                dal.Tag = dr["bolum_id"].ToString(); // ID görünmez ama doktor sorgusunda şart

                treeView1.Nodes.Add(dal);
            }

            baglanti.Close();
        }

        private void treeView1_AfterSelect_1(object sender, TreeViewEventArgs e)
        {

            // Parent != null ise tıklanan bir doktor düğümüdür, bölüm değil — tekrar sorgu atma
            if (e.Node.Parent != null) return;
            // Bölüm ID'sini Tag'den oku
            string secilenbolumid = e.Node.Tag.ToString();
            e.Node.Nodes.Clear(); // Aynı bölüme 2. kez tıklanınca doktorlar çift eklenmesini önle

            MySqlConnection baglanti = new MySqlConnection("Server=localhost;Database=ege_randevu_db;Uid=root;Pwd=root");
            baglanti.Open();

            MySqlCommand komut = new MySqlCommand("SELECT * FROM doktorlar WHERE bolum_id = @id", baglanti);
            komut.Parameters.AddWithValue("@id", secilenbolumid);
            MySqlDataReader dr = komut.ExecuteReader();

            while (dr.Read())
            {
                TreeNode doktordal = new TreeNode(dr["ad_soyad"].ToString());
                doktordal.Tag = dr["doktor_id"].ToString();//Randevu sorgusunda bu ID kullanılacak
                e.Node.Nodes.Add(doktordal);
            }

            baglanti.Close();
            e.Node.Expand(); // Bölümü aç, altındaki doktorlar görünsün




        }

        // Seçilen doktor + tarihe ait tüm saatleri ekrana basar
        public void RandevuSaatleriniGetir(int doktorId, DateTime secilenTarih)
        {
            flowLayoutPanel1.Controls.Clear();
            string[] saatler = { "09:00", "10:00", "11:00", "13:00", "14:00", "15:00", "16:00" };

            foreach (string saat in saatler)
            {
                randevukutusu kutu = new randevukutusu();
                kutu.Gun = secilenTarih.ToString("dddd").ToUpper();
                kutu.Tarih = secilenTarih.ToString("dd MMMM") + " - " + saat;
                kutu.Doktor = treeView1.SelectedNode.Text;
                kutu.doktorid = doktorId;
                kutu.SecilenTarih = secilenTarih;  // ← Gerçek DateTime
                kutu.Saat = saat;                   // ← Sadece saat string'i

                MySqlConnection baglanti = new MySqlConnection("Server=localhost;Database=ege_randevu_db;Uid=root;Pwd=root");
                baglanti.Open();

                string sqlTarih = secilenTarih.ToString("yyyy-MM-dd");
                // Bu doktor + tarih + saat kombinasyonu dolu mu? COUNT=0 → boş, COUNT>0 → dolu
                string sorgu = "SELECT COUNT(*) FROM randevular WHERE doktor_id=@dId AND randevu_tarihi=@tar AND randevu_saati=@saat";
                MySqlCommand komut = new MySqlCommand(sorgu, baglanti);
                komut.Parameters.AddWithValue("@dId", doktorId);
                komut.Parameters.AddWithValue("@tar", sqlTarih);
                komut.Parameters.AddWithValue("@saat", saat);

                int kayitSayisi = Convert.ToInt32(komut.ExecuteScalar());
                kutu.DurumAyarla(kayitSayisi > 0);

                baglanti.Close();
                flowLayoutPanel1.Controls.Add(kutu);
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e) { }

        private void dtpTarih_ValueChanged(object sender, EventArgs e)
        {
            //İki koşul birlikte olmalı
            if (treeView1.SelectedNode != null && treeView1.SelectedNode.Parent != null)
            {
                int dId = Convert.ToInt32(treeView1.SelectedNode.Tag);

                // Sadece randevuları yenile, çünkü zaten randevu ekranındayız
                // Eski randevu kutularını silmeyi unutma ki üst üste binmesinler!
                flowLayoutPanel1.Controls.Clear();
                RandevuSaatleriniGetir(dId, dtpTarih.Value);

                treeView1.Visible = false;
            }
        }

        private void btngeri_Click(object sender, EventArgs e) { }

        private void btnGeri_Click_1(object sender, EventArgs e)
        {
            treeView1.SelectedNode = null;

            // Acik dallari kapat
            treeView1.CollapseAll();

            flowLayoutPanel1.Visible = false;
            treeView1.Visible = true;

            flowLayoutPanel1.Controls.Clear();


        }


        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnrandevularım_Click(object sender, EventArgs e)
        {
            Formrandevularim randevuformu = new Formrandevularim();

            // ShowDialog() kullanıyoruz ki bu pencere kapanmadan arkadaki ana form tıklanamasın, daha temiz bir görünüm olur
            randevuformu.ShowDialog();
        }
    }
}