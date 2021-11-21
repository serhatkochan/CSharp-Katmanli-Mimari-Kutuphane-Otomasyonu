namespace PresentationLayer
{
    partial class FStudentEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FStudentEkle));
            this.panelMenuHorizontal = new System.Windows.Forms.Panel();
            this.icon_minimize = new System.Windows.Forms.PictureBox();
            this.icon_delete = new System.Windows.Forms.PictureBox();
            this.txt_adi = new System.Windows.Forms.TextBox();
            this.panel_container = new System.Windows.Forms.Panel();
            this.txt_cinsiyet = new System.Windows.Forms.TextBox();
            this.btn_ekle = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_okulNo = new System.Windows.Forms.TextBox();
            this.txt_tcNo = new System.Windows.Forms.TextBox();
            this.txt_bolumu = new System.Windows.Forms.TextBox();
            this.txt_soyadi = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panelMenuHorizontal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icon_minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon_delete)).BeginInit();
            this.panel_container.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenuHorizontal
            // 
            this.panelMenuHorizontal.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelMenuHorizontal.Controls.Add(this.label7);
            this.panelMenuHorizontal.Controls.Add(this.icon_minimize);
            this.panelMenuHorizontal.Controls.Add(this.icon_delete);
            this.panelMenuHorizontal.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMenuHorizontal.Location = new System.Drawing.Point(0, 0);
            this.panelMenuHorizontal.Name = "panelMenuHorizontal";
            this.panelMenuHorizontal.Size = new System.Drawing.Size(1034, 39);
            this.panelMenuHorizontal.TabIndex = 2;
            this.panelMenuHorizontal.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelMenuHorizontal_MouseDown_1);
            // 
            // icon_minimize
            // 
            this.icon_minimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.icon_minimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.icon_minimize.Image = ((System.Drawing.Image)(resources.GetObject("icon_minimize.Image")));
            this.icon_minimize.Location = new System.Drawing.Point(972, 7);
            this.icon_minimize.Name = "icon_minimize";
            this.icon_minimize.Size = new System.Drawing.Size(26, 26);
            this.icon_minimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.icon_minimize.TabIndex = 5;
            this.icon_minimize.TabStop = false;
            this.icon_minimize.Click += new System.EventHandler(this.icon_minimize_Click);
            // 
            // icon_delete
            // 
            this.icon_delete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.icon_delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.icon_delete.Image = ((System.Drawing.Image)(resources.GetObject("icon_delete.Image")));
            this.icon_delete.Location = new System.Drawing.Point(1004, 9);
            this.icon_delete.Name = "icon_delete";
            this.icon_delete.Size = new System.Drawing.Size(22, 22);
            this.icon_delete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.icon_delete.TabIndex = 4;
            this.icon_delete.TabStop = false;
            this.icon_delete.Click += new System.EventHandler(this.icon_delete_Click);
            // 
            // txt_adi
            // 
            this.txt_adi.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_adi.Location = new System.Drawing.Point(176, 16);
            this.txt_adi.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.txt_adi.Name = "txt_adi";
            this.txt_adi.Size = new System.Drawing.Size(190, 26);
            this.txt_adi.TabIndex = 15;
            // 
            // panel_container
            // 
            this.panel_container.Controls.Add(this.txt_cinsiyet);
            this.panel_container.Controls.Add(this.btn_ekle);
            this.panel_container.Controls.Add(this.label6);
            this.panel_container.Controls.Add(this.label5);
            this.panel_container.Controls.Add(this.label4);
            this.panel_container.Controls.Add(this.label3);
            this.panel_container.Controls.Add(this.label2);
            this.panel_container.Controls.Add(this.label1);
            this.panel_container.Controls.Add(this.txt_okulNo);
            this.panel_container.Controls.Add(this.txt_tcNo);
            this.panel_container.Controls.Add(this.txt_bolumu);
            this.panel_container.Controls.Add(this.txt_soyadi);
            this.panel_container.Controls.Add(this.txt_adi);
            this.panel_container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_container.Location = new System.Drawing.Point(0, 39);
            this.panel_container.Name = "panel_container";
            this.panel_container.Size = new System.Drawing.Size(1034, 222);
            this.panel_container.TabIndex = 22;
            // 
            // txt_cinsiyet
            // 
            this.txt_cinsiyet.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_cinsiyet.Location = new System.Drawing.Point(696, 160);
            this.txt_cinsiyet.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.txt_cinsiyet.Name = "txt_cinsiyet";
            this.txt_cinsiyet.Size = new System.Drawing.Size(190, 26);
            this.txt_cinsiyet.TabIndex = 33;
            // 
            // btn_ekle
            // 
            this.btn_ekle.AutoSize = true;
            this.btn_ekle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btn_ekle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ekle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ekle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_ekle.ForeColor = System.Drawing.Color.White;
            this.btn_ekle.Location = new System.Drawing.Point(896, 22);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(126, 164);
            this.btn_ekle.TabIndex = 32;
            this.btn_ekle.Text = "Ekle";
            this.btn_ekle.UseVisualStyleBackColor = false;
            this.btn_ekle.Click += new System.EventHandler(this.btn_ekle_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(447, 166);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 20);
            this.label6.TabIndex = 31;
            this.label6.Text = "Öğrenci Cinsiyeti";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(447, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(177, 20);
            this.label5.TabIndex = 30;
            this.label5.Text = "Öğrenci Okul Numarası";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(447, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 20);
            this.label4.TabIndex = 29;
            this.label4.Text = "Öğrenci TC Numarası";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(12, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 20);
            this.label3.TabIndex = 28;
            this.label3.Text = "Öğrenci Bölümü";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(12, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 20);
            this.label2.TabIndex = 27;
            this.label2.Text = "Öğrenci Soyadı";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 20);
            this.label1.TabIndex = 26;
            this.label1.Text = "Öğrenci Adı";
            // 
            // txt_okulNo
            // 
            this.txt_okulNo.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_okulNo.Location = new System.Drawing.Point(696, 89);
            this.txt_okulNo.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.txt_okulNo.Name = "txt_okulNo";
            this.txt_okulNo.Size = new System.Drawing.Size(190, 26);
            this.txt_okulNo.TabIndex = 25;
            // 
            // txt_tcNo
            // 
            this.txt_tcNo.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_tcNo.Location = new System.Drawing.Point(696, 22);
            this.txt_tcNo.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.txt_tcNo.Name = "txt_tcNo";
            this.txt_tcNo.Size = new System.Drawing.Size(190, 26);
            this.txt_tcNo.TabIndex = 24;
            // 
            // txt_bolumu
            // 
            this.txt_bolumu.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_bolumu.Location = new System.Drawing.Point(176, 163);
            this.txt_bolumu.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.txt_bolumu.Name = "txt_bolumu";
            this.txt_bolumu.Size = new System.Drawing.Size(190, 26);
            this.txt_bolumu.TabIndex = 23;
            // 
            // txt_soyadi
            // 
            this.txt_soyadi.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_soyadi.Location = new System.Drawing.Point(176, 92);
            this.txt_soyadi.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.txt_soyadi.Name = "txt_soyadi";
            this.txt_soyadi.Size = new System.Drawing.Size(190, 26);
            this.txt_soyadi.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(3, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(196, 21);
            this.label7.TabIndex = 7;
            this.label7.Text = "Öğrenci Ekleme İşlemleri";
            // 
            // FStudentEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1034, 261);
            this.Controls.Add(this.panel_container);
            this.Controls.Add(this.panelMenuHorizontal);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FStudentEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FStudentEkle";
            this.panelMenuHorizontal.ResumeLayout(false);
            this.panelMenuHorizontal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icon_minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon_delete)).EndInit();
            this.panel_container.ResumeLayout(false);
            this.panel_container.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenuHorizontal;
        private System.Windows.Forms.PictureBox icon_minimize;
        private System.Windows.Forms.PictureBox icon_delete;
        private System.Windows.Forms.TextBox txt_adi;
        private System.Windows.Forms.Panel panel_container;
        private System.Windows.Forms.TextBox txt_okulNo;
        private System.Windows.Forms.TextBox txt_tcNo;
        private System.Windows.Forms.TextBox txt_bolumu;
        private System.Windows.Forms.TextBox txt_soyadi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_ekle;
        private System.Windows.Forms.TextBox txt_cinsiyet;
        private System.Windows.Forms.Label label7;
    }
}