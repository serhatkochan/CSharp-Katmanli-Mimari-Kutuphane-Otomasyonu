namespace PresentationLayer
{
    partial class FBookGuncelle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FBookGuncelle));
            this.label_id = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.icon_minimize = new System.Windows.Forms.PictureBox();
            this.panelMenuHorizontal = new System.Windows.Forms.Panel();
            this.icon_delete = new System.Windows.Forms.PictureBox();
            this.panel_container = new System.Windows.Forms.Panel();
            this.txt_adeti = new System.Windows.Forms.TextBox();
            this.btn_guncelle = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_sayfasi = new System.Windows.Forms.TextBox();
            this.txt_yayinevi = new System.Windows.Forms.TextBox();
            this.txt_yazari = new System.Windows.Forms.TextBox();
            this.txt_turu = new System.Windows.Forms.TextBox();
            this.txt_ismi = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.icon_minimize)).BeginInit();
            this.panelMenuHorizontal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icon_delete)).BeginInit();
            this.panel_container.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_id
            // 
            this.label_id.AutoSize = true;
            this.label_id.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_id.Location = new System.Drawing.Point(220, 12);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(24, 21);
            this.label_id.TabIndex = 7;
            this.label_id.Text = "id";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(12, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(202, 21);
            this.label7.TabIndex = 6;
            this.label7.Text = "Güncellenecek Kitap ID :";
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
            // panelMenuHorizontal
            // 
            this.panelMenuHorizontal.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelMenuHorizontal.Controls.Add(this.label_id);
            this.panelMenuHorizontal.Controls.Add(this.label7);
            this.panelMenuHorizontal.Controls.Add(this.icon_minimize);
            this.panelMenuHorizontal.Controls.Add(this.icon_delete);
            this.panelMenuHorizontal.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMenuHorizontal.Location = new System.Drawing.Point(0, 0);
            this.panelMenuHorizontal.Name = "panelMenuHorizontal";
            this.panelMenuHorizontal.Size = new System.Drawing.Size(1034, 39);
            this.panelMenuHorizontal.TabIndex = 24;
            this.panelMenuHorizontal.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelMenuHorizontal_MouseDown);
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
            // panel_container
            // 
            this.panel_container.Controls.Add(this.txt_adeti);
            this.panel_container.Controls.Add(this.btn_guncelle);
            this.panel_container.Controls.Add(this.label6);
            this.panel_container.Controls.Add(this.label5);
            this.panel_container.Controls.Add(this.label4);
            this.panel_container.Controls.Add(this.label3);
            this.panel_container.Controls.Add(this.label2);
            this.panel_container.Controls.Add(this.label1);
            this.panel_container.Controls.Add(this.txt_sayfasi);
            this.panel_container.Controls.Add(this.txt_yayinevi);
            this.panel_container.Controls.Add(this.txt_yazari);
            this.panel_container.Controls.Add(this.txt_turu);
            this.panel_container.Controls.Add(this.txt_ismi);
            this.panel_container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_container.Location = new System.Drawing.Point(0, 39);
            this.panel_container.Name = "panel_container";
            this.panel_container.Size = new System.Drawing.Size(1034, 222);
            this.panel_container.TabIndex = 25;
            // 
            // txt_adeti
            // 
            this.txt_adeti.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_adeti.Location = new System.Drawing.Point(696, 160);
            this.txt_adeti.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.txt_adeti.Name = "txt_adeti";
            this.txt_adeti.Size = new System.Drawing.Size(190, 26);
            this.txt_adeti.TabIndex = 33;
            // 
            // btn_guncelle
            // 
            this.btn_guncelle.AutoSize = true;
            this.btn_guncelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btn_guncelle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_guncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_guncelle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_guncelle.ForeColor = System.Drawing.Color.White;
            this.btn_guncelle.Location = new System.Drawing.Point(896, 22);
            this.btn_guncelle.Name = "btn_guncelle";
            this.btn_guncelle.Size = new System.Drawing.Size(126, 164);
            this.btn_guncelle.TabIndex = 32;
            this.btn_guncelle.Text = "Güncelle";
            this.btn_guncelle.UseVisualStyleBackColor = false;
            this.btn_guncelle.Click += new System.EventHandler(this.btn_guncelle_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(447, 166);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 20);
            this.label6.TabIndex = 31;
            this.label6.Text = "Kitap Adeti";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(447, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 20);
            this.label5.TabIndex = 30;
            this.label5.Text = "Kitap Sayfası";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(447, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 20);
            this.label4.TabIndex = 29;
            this.label4.Text = "Kitap Yayınevi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(12, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 20);
            this.label3.TabIndex = 28;
            this.label3.Text = "Kitap Yazarı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(12, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 27;
            this.label2.Text = "Kitap Türü";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 20);
            this.label1.TabIndex = 26;
            this.label1.Text = "Kitap İsmi";
            // 
            // txt_sayfasi
            // 
            this.txt_sayfasi.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_sayfasi.Location = new System.Drawing.Point(696, 89);
            this.txt_sayfasi.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.txt_sayfasi.Name = "txt_sayfasi";
            this.txt_sayfasi.Size = new System.Drawing.Size(190, 26);
            this.txt_sayfasi.TabIndex = 25;
            // 
            // txt_yayinevi
            // 
            this.txt_yayinevi.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_yayinevi.Location = new System.Drawing.Point(696, 22);
            this.txt_yayinevi.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.txt_yayinevi.Name = "txt_yayinevi";
            this.txt_yayinevi.Size = new System.Drawing.Size(190, 26);
            this.txt_yayinevi.TabIndex = 24;
            // 
            // txt_yazari
            // 
            this.txt_yazari.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_yazari.Location = new System.Drawing.Point(176, 163);
            this.txt_yazari.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.txt_yazari.Name = "txt_yazari";
            this.txt_yazari.Size = new System.Drawing.Size(190, 26);
            this.txt_yazari.TabIndex = 23;
            // 
            // txt_turu
            // 
            this.txt_turu.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_turu.Location = new System.Drawing.Point(176, 92);
            this.txt_turu.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.txt_turu.Name = "txt_turu";
            this.txt_turu.Size = new System.Drawing.Size(190, 26);
            this.txt_turu.TabIndex = 22;
            // 
            // txt_ismi
            // 
            this.txt_ismi.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_ismi.Location = new System.Drawing.Point(176, 16);
            this.txt_ismi.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.txt_ismi.Name = "txt_ismi";
            this.txt_ismi.Size = new System.Drawing.Size(190, 26);
            this.txt_ismi.TabIndex = 15;
            // 
            // FBookGuncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1034, 261);
            this.Controls.Add(this.panel_container);
            this.Controls.Add(this.panelMenuHorizontal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FBookGuncelle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FBookGuncelle";
            ((System.ComponentModel.ISupportInitialize)(this.icon_minimize)).EndInit();
            this.panelMenuHorizontal.ResumeLayout(false);
            this.panelMenuHorizontal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icon_delete)).EndInit();
            this.panel_container.ResumeLayout(false);
            this.panel_container.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.Label label_id;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox icon_minimize;
        private System.Windows.Forms.Panel panelMenuHorizontal;
        private System.Windows.Forms.PictureBox icon_delete;
        private System.Windows.Forms.Panel panel_container;
        public System.Windows.Forms.TextBox txt_adeti;
        private System.Windows.Forms.Button btn_guncelle;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txt_sayfasi;
        public System.Windows.Forms.TextBox txt_yayinevi;
        public System.Windows.Forms.TextBox txt_yazari;
        public System.Windows.Forms.TextBox txt_turu;
        public System.Windows.Forms.TextBox txt_ismi;
    }
}