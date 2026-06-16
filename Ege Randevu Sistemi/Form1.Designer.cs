namespace Ege_Randevu_Sistemi
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            flowLayoutPanel1 = new FlowLayoutPanel();
            treeView1 = new TreeView();
            panel3 = new Panel();
            lblhastatelefon = new Label();
            lblhastaadi = new Label();
            flowLayoutPanel3 = new FlowLayoutPanel();
            flowLayoutPanel2 = new FlowLayoutPanel();
            lbltelefon = new Label();
            label4 = new Label();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            btnGeri = new Button();
            dtpTarih = new DateTimePicker();
            panel1 = new Panel();
            btnrandevularım = new Button();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.BackColor = SystemColors.ControlLight;
            flowLayoutPanel1.Dock = DockStyle.Right;
            flowLayoutPanel1.Location = new Point(60, 122);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1404, 635);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // treeView1
            // 
            treeView1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            treeView1.Location = new Point(12, 128);
            treeView1.Name = "treeView1";
            treeView1.Size = new Size(575, 547);
            treeView1.TabIndex = 2;
            treeView1.AfterSelect += treeView1_AfterSelect_1;
            // 
            // panel3
            // 
            panel3.Controls.Add(lblhastatelefon);
            panel3.Controls.Add(lblhastaadi);
            panel3.Controls.Add(flowLayoutPanel3);
            panel3.Controls.Add(flowLayoutPanel2);
            panel3.Controls.Add(lbltelefon);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 78);
            panel3.Name = "panel3";
            panel3.Size = new Size(1464, 44);
            panel3.TabIndex = 2;
            // 
            // lblhastatelefon
            // 
            lblhastatelefon.AutoSize = true;
            lblhastatelefon.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblhastatelefon.Location = new Point(338, 15);
            lblhastatelefon.Name = "lblhastatelefon";
            lblhastatelefon.Size = new Size(74, 17);
            lblhastatelefon.TabIndex = 4;
            lblhastatelefon.Text = "TELEFON";
            // 
            // lblhastaadi
            // 
            lblhastaadi.AutoSize = true;
            lblhastaadi.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblhastaadi.Location = new Point(62, 17);
            lblhastaadi.Name = "lblhastaadi";
            lblhastaadi.Size = new Size(84, 17);
            lblhastaadi.TabIndex = 0;
            lblhastaadi.Text = "AD SOYAD";
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.Location = new Point(489, 57);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Size = new Size(200, 100);
            flowLayoutPanel3.TabIndex = 3;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Location = new Point(391, 57);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(394, 300);
            flowLayoutPanel2.TabIndex = 3;
            // 
            // lbltelefon
            // 
            lbltelefon.AutoSize = true;
            lbltelefon.Location = new Point(629, 15);
            lbltelefon.Name = "lbltelefon";
            lbltelefon.Size = new Size(0, 15);
            lbltelefon.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label4.Location = new Point(453, 9);
            label4.Margin = new Padding(7, 0, 7, 0);
            label4.Name = "label4";
            label4.Size = new Size(366, 24);
            label4.TabIndex = 1;
            label4.Text = "Ege Üniversitesi Tıp Fakültesi Hastanesi";
            label4.TextAlign = ContentAlignment.TopCenter;
            label4.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.Location = new Point(555, 41);
            label3.Name = "label3";
            label3.Size = new Size(165, 22);
            label3.TabIndex = 2;
            label3.Text = "E-Randevu Sistemi";
            label3.Click += label3_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(65, 19);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(105, 53);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(1309, 19);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(104, 52);
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // btnGeri
            // 
            btnGeri.BackColor = SystemColors.ScrollBar;
            btnGeri.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnGeri.ForeColor = SystemColors.HotTrack;
            btnGeri.Location = new Point(3, 0);
            btnGeri.Name = "btnGeri";
            btnGeri.Size = new Size(75, 23);
            btnGeri.TabIndex = 3;
            btnGeri.Text = "← Geri";
            btnGeri.UseVisualStyleBackColor = false;
            btnGeri.Click += btnGeri_Click_1;
            // 
            // dtpTarih
            // 
            dtpTarih.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            dtpTarih.Format = DateTimePickerFormat.Short;
            dtpTarih.Location = new Point(1090, 41);
            dtpTarih.Name = "dtpTarih";
            dtpTarih.Size = new Size(120, 26);
            dtpTarih.TabIndex = 3;
            dtpTarih.ValueChanged += dtpTarih_ValueChanged;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.GradientInactiveCaption;
            panel1.Controls.Add(btnrandevularım);
            panel1.Controls.Add(dtpTarih);
            panel1.Controls.Add(btnGeri);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label4);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1464, 78);
            panel1.TabIndex = 0;
            // 
            // btnrandevularım
            // 
            btnrandevularım.BackColor = SystemColors.ScrollBar;
            btnrandevularım.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnrandevularım.ForeColor = SystemColors.HotTrack;
            btnrandevularım.Location = new Point(1038, 10);
            btnrandevularım.Name = "btnrandevularım";
            btnrandevularım.Size = new Size(211, 23);
            btnrandevularım.TabIndex = 5;
            btnrandevularım.Text = "Randevularım";
            btnrandevularım.UseVisualStyleBackColor = false;
            btnrandevularım.Click += btnrandevularım_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1464, 757);
            Controls.Add(treeView1);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private FlowLayoutPanel flowLayoutPanel1;
        private TreeView treeView1;
        private Panel panel3;
        private Label lblhastatelefon;
        private Label lblhastaadi;
        private FlowLayoutPanel flowLayoutPanel3;
        private FlowLayoutPanel flowLayoutPanel2;
        private Label lbltelefon;
        private Label label4;
        private Label label3;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button btnGeri;
        private DateTimePicker dtpTarih;
        private Panel panel1;
        private Button btnrandevularım;
    }
}
