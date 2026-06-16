namespace Ege_Randevu_Sistemi
{
    partial class Formgiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Formgiris));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtadsoyad = new TextBox();
            label4 = new Label();
            txttelefon = new TextBox();
            btngiris = new Button();
            txtkimlik = new MaskedTextBox();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(213, 54);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(117, 98);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(336, 75);
            label1.Name = "label1";
            label1.Size = new Size(158, 24);
            label1.TabIndex = 1;
            label1.Text = "Ege Üniversitesi ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label2.Location = new Point(336, 109);
            label2.Name = "label2";
            label2.Size = new Size(175, 19);
            label2.TabIndex = 2;
            label2.Text = "Randevu Oluşturma Sistemi";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label3.Location = new Point(203, 197);
            label3.Name = "label3";
            label3.Size = new Size(78, 19);
            label3.TabIndex = 3;
            label3.Text = "Ad Soyad :";
            // 
            // txtadsoyad
            // 
            txtadsoyad.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtadsoyad.Location = new Point(297, 190);
            txtadsoyad.Name = "txtadsoyad";
            txtadsoyad.Size = new Size(231, 26);
            txtadsoyad.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label4.Location = new Point(221, 299);
            label4.Name = "label4";
            label4.Size = new Size(60, 19);
            label4.TabIndex = 5;
            label4.Text = "Telefon :";
            // 
            // txttelefon
            // 
            txttelefon.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txttelefon.Location = new Point(297, 296);
            txttelefon.MaxLength = 11;
            txttelefon.Name = "txttelefon";
            txttelefon.Size = new Size(231, 26);
            txttelefon.TabIndex = 6;
            txttelefon.KeyPress += txttelefon_KeyPress;
            // 
            // btngiris
            // 
            btngiris.BackColor = SystemColors.GradientActiveCaption;
            btngiris.FlatStyle = FlatStyle.Flat;
            btngiris.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btngiris.Location = new Point(425, 353);
            btngiris.Name = "btngiris";
            btngiris.Size = new Size(103, 31);
            btngiris.TabIndex = 7;
            btngiris.Text = "Giriş";
            btngiris.UseVisualStyleBackColor = false;
            btngiris.Click += btngiris_Click;
            // 
            // txtkimlik
            // 
            txtkimlik.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtkimlik.Location = new Point(297, 244);
            txtkimlik.Name = "txtkimlik";
            txtkimlik.Size = new Size(231, 26);
            txtkimlik.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label5.Location = new Point(194, 247);
            label5.Name = "label5";
            label5.Size = new Size(87, 19);
            label5.TabIndex = 9;
            label5.Text = "T.C. Kimlik :";
            label5.Click += label5_Click;
            // 
            // Formgiris
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(txtkimlik);
            Controls.Add(btngiris);
            Controls.Add(txttelefon);
            Controls.Add(label4);
            Controls.Add(txtadsoyad);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "Formgiris";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2giris";
            Load += Formgiris_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtadsoyad;
        private Label label4;
        private TextBox txttelefon;
        private Button btngiris;
        private MaskedTextBox txtkimlik;
        private Label label5;
    }
}