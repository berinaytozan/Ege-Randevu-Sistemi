namespace Ege_Randevu_Sistemi
{
    partial class randevukutusu
    {
        /// <summary> 
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Bileşen Tasarımcısı üretimi kod

        /// <summary> 
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            lblGun = new Label();
            lblTarih = new Label();
            lblDoktor = new Label();
            btnDurum = new Button();
            SuspendLayout();
            // 
            // lblGun
            // 
            lblGun.AutoSize = true;
            lblGun.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblGun.Location = new Point(25, 20);
            lblGun.Name = "lblGun";
            lblGun.Size = new Size(47, 17);
            lblGun.TabIndex = 0;
            lblGun.Text = "label1";
            lblGun.Click += label1_Click;
            // 
            // lblTarih
            // 
            lblTarih.AutoSize = true;
            lblTarih.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblTarih.Location = new Point(25, 73);
            lblTarih.Name = "lblTarih";
            lblTarih.Size = new Size(42, 17);
            lblTarih.TabIndex = 1;
            lblTarih.Text = "label2";
            // 
            // lblDoktor
            // 
            lblDoktor.AutoSize = true;
            lblDoktor.Font = new Font("Times New Roman", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 162);
            lblDoktor.Location = new Point(25, 129);
            lblDoktor.Name = "lblDoktor";
            lblDoktor.Size = new Size(47, 17);
            lblDoktor.TabIndex = 2;
            lblDoktor.Text = "label3";
            // 
            // btnDurum
            // 
            btnDurum.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnDurum.Location = new Point(42, 162);
            btnDurum.Name = "btnDurum";
            btnDurum.Size = new Size(75, 23);
            btnDurum.TabIndex = 3;
            btnDurum.Text = "button1";
            btnDurum.UseVisualStyleBackColor = true;
            btnDurum.Click += btnDurum_Click;
            // 
            // randevukutusu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnDurum);
            Controls.Add(lblDoktor);
            Controls.Add(lblTarih);
            Controls.Add(lblGun);
            Name = "randevukutusu";
            Size = new Size(164, 198);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblGun;
        private Label lblTarih;
        private Label lblDoktor;
        private Button btnDurum;
    }
}
