namespace Ege_Randevu_Sistemi
{
    partial class Formrandevularim
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            lblrandevular = new Label();
            lbltarih_r = new Label();
            lblbolum_r = new Label();
            lbldoktor_r = new Label();
            cmbfilterbolum = new ComboBox();
            cmbfilterdoktor = new ComboBox();
            dtpfiltertarih = new DateTimePicker();
            btnara = new Button();
            btntemizle = new Button();
            dgvrandevular = new DataGridView();
            btniptalet = new Button();
            btndetay = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvrandevular).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.MidnightBlue;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Top;
            dataGridView1.GridColor = SystemColors.MenuHighlight;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(1113, 121);
            dataGridView1.TabIndex = 0;
            // 
            // lblrandevular
            // 
            lblrandevular.AutoSize = true;
            lblrandevular.BackColor = Color.Azure;
            lblrandevular.Font = new Font("Times New Roman", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblrandevular.ForeColor = Color.Navy;
            lblrandevular.Location = new Point(61, 40);
            lblrandevular.Name = "lblrandevular";
            lblrandevular.Size = new Size(333, 42);
            lblrandevular.TabIndex = 1;
            lblrandevular.Text = "RANDEVULARIM";
            lblrandevular.Click += lblrandevular_Click;
            // 
            // lbltarih_r
            // 
            lbltarih_r.AutoSize = true;
            lbltarih_r.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lbltarih_r.Location = new Point(81, 167);
            lbltarih_r.Name = "lbltarih_r";
            lbltarih_r.Size = new Size(57, 21);
            lbltarih_r.TabIndex = 2;
            lbltarih_r.Text = "Tarih :";
            // 
            // lblbolum_r
            // 
            lblbolum_r.AutoSize = true;
            lblbolum_r.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblbolum_r.Location = new Point(70, 228);
            lblbolum_r.Name = "lblbolum_r";
            lblbolum_r.Size = new Size(68, 21);
            lblbolum_r.TabIndex = 3;
            lblbolum_r.Text = "Bölüm :";
            // 
            // lbldoktor_r
            // 
            lbldoktor_r.AutoSize = true;
            lbldoktor_r.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lbldoktor_r.Location = new Point(66, 291);
            lbldoktor_r.Name = "lbldoktor_r";
            lbldoktor_r.Size = new Size(72, 21);
            lbldoktor_r.TabIndex = 4;
            lbldoktor_r.Text = "Doktor :";
            // 
            // cmbfilterbolum
            // 
            cmbfilterbolum.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            cmbfilterbolum.FormattingEnabled = true;
            cmbfilterbolum.Location = new Point(154, 225);
            cmbfilterbolum.Name = "cmbfilterbolum";
            cmbfilterbolum.Size = new Size(121, 29);
            cmbfilterbolum.TabIndex = 5;
            cmbfilterbolum.SelectedIndexChanged += cmbfilterbolum_SelectedIndexChanged_1;
            // 
            // cmbfilterdoktor
            // 
            cmbfilterdoktor.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            cmbfilterdoktor.FormattingEnabled = true;
            cmbfilterdoktor.Location = new Point(154, 288);
            cmbfilterdoktor.Name = "cmbfilterdoktor";
            cmbfilterdoktor.Size = new Size(121, 29);
            cmbfilterdoktor.TabIndex = 6;
            // 
            // dtpfiltertarih
            // 
            dtpfiltertarih.CalendarFont = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            dtpfiltertarih.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            dtpfiltertarih.Format = DateTimePickerFormat.Short;
            dtpfiltertarih.Location = new Point(154, 167);
            dtpfiltertarih.Name = "dtpfiltertarih";
            dtpfiltertarih.Size = new Size(121, 29);
            dtpfiltertarih.TabIndex = 7;
            // 
            // btnara
            // 
            btnara.BackColor = Color.LightSkyBlue;
            btnara.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnara.Location = new Point(255, 333);
            btnara.Name = "btnara";
            btnara.Size = new Size(74, 33);
            btnara.TabIndex = 8;
            btnara.Text = "Ara";
            btnara.UseVisualStyleBackColor = false;
            btnara.Click += btnara_Click;
            // 
            // btntemizle
            // 
            btntemizle.BackColor = Color.LightCoral;
            btntemizle.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btntemizle.Location = new Point(344, 333);
            btntemizle.Name = "btntemizle";
            btntemizle.Size = new Size(85, 33);
            btntemizle.TabIndex = 9;
            btntemizle.Text = "Temizle";
            btntemizle.UseVisualStyleBackColor = false;
            btntemizle.Click += btntemizle_Click;
            // 
            // dgvrandevular
            // 
            dgvrandevular.BackgroundColor = Color.Lavender;
            dgvrandevular.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvrandevular.Dock = DockStyle.Bottom;
            dgvrandevular.Location = new Point(0, 372);
            dgvrandevular.Name = "dgvrandevular";
            dgvrandevular.Size = new Size(1113, 312);
            dgvrandevular.TabIndex = 10;
            // 
            // btniptalet
            // 
            btniptalet.BackColor = Color.LightCoral;
            btniptalet.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btniptalet.Location = new Point(28, 639);
            btniptalet.Name = "btniptalet";
            btniptalet.Size = new Size(74, 33);
            btniptalet.TabIndex = 11;
            btniptalet.Text = "İptal Et";
            btniptalet.UseVisualStyleBackColor = false;
            btniptalet.Click += btniptalet_Click;
            // 
            // btndetay
            // 
            btndetay.BackColor = Color.HotPink;
            btndetay.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btndetay.Location = new Point(121, 639);
            btndetay.Name = "btndetay";
            btndetay.Size = new Size(154, 33);
            btndetay.TabIndex = 12;
            btndetay.Text = "Detay Görüntüle";
            btndetay.UseVisualStyleBackColor = false;
            btndetay.Click += btndetay_Click;
            // 
            // Formrandevularim
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1113, 684);
            Controls.Add(btndetay);
            Controls.Add(btniptalet);
            Controls.Add(dgvrandevular);
            Controls.Add(btntemizle);
            Controls.Add(btnara);
            Controls.Add(dtpfiltertarih);
            Controls.Add(cmbfilterdoktor);
            Controls.Add(cmbfilterbolum);
            Controls.Add(lbldoktor_r);
            Controls.Add(lblbolum_r);
            Controls.Add(lbltarih_r);
            Controls.Add(lblrandevular);
            Controls.Add(dataGridView1);
            Name = "Formrandevularim";
            Text = "Formrandevularim";
            Load += Formrandevularim_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvrandevular).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label lblrandevular;
        private Label lbltarih_r;
        private Label lblbolum_r;
        private Label lbldoktor_r;
        private ComboBox cmbfilterbolum;
        private ComboBox cmbfilterdoktor;
        private DateTimePicker dtpfiltertarih;
        private Button btnara;
        private Button btntemizle;
        private DataGridView dgvrandevular;
        private Button btniptalet;
        private Button btndetay;
    }
}