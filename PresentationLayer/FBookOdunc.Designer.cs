namespace PresentationLayer
{
    partial class FBookOdunc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FBookOdunc));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelMenuHorizontal = new System.Windows.Forms.Panel();
            this.label_id = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.icon_minimize = new System.Windows.Forms.PictureBox();
            this.icon_delete = new System.Windows.Forms.PictureBox();
            this.panel_container = new System.Windows.Forms.Panel();
            this.panel_menu = new System.Windows.Forms.Panel();
            this.groupBox_arama = new System.Windows.Forms.Panel();
            this.txt_aranacakOgrenci = new System.Windows.Forms.TextBox();
            this.btn_ogrenciAra = new System.Windows.Forms.Button();
            this.btn_alanOgrenciler = new System.Windows.Forms.Button();
            this.label_bilgilendirme = new System.Windows.Forms.Label();
            this.btn_oduncVer = new System.Windows.Forms.Button();
            this.btn_ogrenciler = new System.Windows.Forms.Button();
            this.btn_iadeAl = new System.Windows.Forms.Button();
            this.dataGrid_odunc = new System.Windows.Forms.DataGridView();
            this.panelMenuHorizontal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icon_minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon_delete)).BeginInit();
            this.panel_container.SuspendLayout();
            this.panel_menu.SuspendLayout();
            this.groupBox_arama.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_odunc)).BeginInit();
            this.SuspendLayout();
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
            this.panelMenuHorizontal.Size = new System.Drawing.Size(1050, 39);
            this.panelMenuHorizontal.TabIndex = 5;
            this.panelMenuHorizontal.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelMenuHorizontal_MouseDown);
            // 
            // label_id
            // 
            this.label_id.AutoSize = true;
            this.label_id.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_id.Location = new System.Drawing.Point(317, 10);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(24, 21);
            this.label_id.TabIndex = 7;
            this.label_id.Text = "id";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(3, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(271, 21);
            this.label7.TabIndex = 6;
            this.label7.Text = "Ödünç İşlemleri Yapılan Kitap  ID :";
            // 
            // icon_minimize
            // 
            this.icon_minimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.icon_minimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.icon_minimize.Image = ((System.Drawing.Image)(resources.GetObject("icon_minimize.Image")));
            this.icon_minimize.Location = new System.Drawing.Point(988, 7);
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
            this.icon_delete.Location = new System.Drawing.Point(1020, 9);
            this.icon_delete.Name = "icon_delete";
            this.icon_delete.Size = new System.Drawing.Size(22, 22);
            this.icon_delete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.icon_delete.TabIndex = 4;
            this.icon_delete.TabStop = false;
            this.icon_delete.Click += new System.EventHandler(this.icon_delete_Click);
            // 
            // panel_container
            // 
            this.panel_container.Controls.Add(this.panel_menu);
            this.panel_container.Controls.Add(this.dataGrid_odunc);
            this.panel_container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_container.Location = new System.Drawing.Point(0, 39);
            this.panel_container.Name = "panel_container";
            this.panel_container.Size = new System.Drawing.Size(1050, 561);
            this.panel_container.TabIndex = 6;
            // 
            // panel_menu
            // 
            this.panel_menu.Controls.Add(this.groupBox_arama);
            this.panel_menu.Controls.Add(this.btn_alanOgrenciler);
            this.panel_menu.Controls.Add(this.label_bilgilendirme);
            this.panel_menu.Controls.Add(this.btn_oduncVer);
            this.panel_menu.Controls.Add(this.btn_ogrenciler);
            this.panel_menu.Controls.Add(this.btn_iadeAl);
            this.panel_menu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_menu.Location = new System.Drawing.Point(0, 0);
            this.panel_menu.Name = "panel_menu";
            this.panel_menu.Size = new System.Drawing.Size(1050, 100);
            this.panel_menu.TabIndex = 18;
            // 
            // groupBox_arama
            // 
            this.groupBox_arama.Controls.Add(this.txt_aranacakOgrenci);
            this.groupBox_arama.Controls.Add(this.btn_ogrenciAra);
            this.groupBox_arama.Location = new System.Drawing.Point(677, 5);
            this.groupBox_arama.Name = "groupBox_arama";
            this.groupBox_arama.Size = new System.Drawing.Size(370, 92);
            this.groupBox_arama.TabIndex = 19;
            // 
            // txt_aranacakOgrenci
            // 
            this.txt_aranacakOgrenci.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_aranacakOgrenci.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_aranacakOgrenci.Location = new System.Drawing.Point(47, 35);
            this.txt_aranacakOgrenci.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.txt_aranacakOgrenci.Name = "txt_aranacakOgrenci";
            this.txt_aranacakOgrenci.Size = new System.Drawing.Size(162, 23);
            this.txt_aranacakOgrenci.TabIndex = 14;
            this.txt_aranacakOgrenci.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_aranacakOgrenci.Enter += new System.EventHandler(this.txt_aranacakOgrenci_Enter);
            this.txt_aranacakOgrenci.Leave += new System.EventHandler(this.txt_aranacakOgrenci_Leave);
            // 
            // btn_ogrenciAra
            // 
            this.btn_ogrenciAra.AutoSize = true;
            this.btn_ogrenciAra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btn_ogrenciAra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ogrenciAra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ogrenciAra.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_ogrenciAra.ForeColor = System.Drawing.Color.White;
            this.btn_ogrenciAra.Location = new System.Drawing.Point(215, 32);
            this.btn_ogrenciAra.Name = "btn_ogrenciAra";
            this.btn_ogrenciAra.Size = new System.Drawing.Size(142, 30);
            this.btn_ogrenciAra.TabIndex = 6;
            this.btn_ogrenciAra.Text = "Öğrenci Ara";
            this.btn_ogrenciAra.UseVisualStyleBackColor = false;
            this.btn_ogrenciAra.Click += new System.EventHandler(this.btn_ogrenciAra_Click);
            // 
            // btn_alanOgrenciler
            // 
            this.btn_alanOgrenciler.AutoSize = true;
            this.btn_alanOgrenciler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btn_alanOgrenciler.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_alanOgrenciler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_alanOgrenciler.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_alanOgrenciler.ForeColor = System.Drawing.Color.White;
            this.btn_alanOgrenciler.Location = new System.Drawing.Point(13, 31);
            this.btn_alanOgrenciler.Name = "btn_alanOgrenciler";
            this.btn_alanOgrenciler.Size = new System.Drawing.Size(141, 30);
            this.btn_alanOgrenciler.TabIndex = 11;
            this.btn_alanOgrenciler.Text = "Alan Öğrenciler";
            this.btn_alanOgrenciler.UseVisualStyleBackColor = false;
            this.btn_alanOgrenciler.Click += new System.EventHandler(this.btn_alanOgrenciler_Click);
            // 
            // label_bilgilendirme
            // 
            this.label_bilgilendirme.AutoSize = true;
            this.label_bilgilendirme.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_bilgilendirme.Location = new System.Drawing.Point(382, 76);
            this.label_bilgilendirme.Name = "label_bilgilendirme";
            this.label_bilgilendirme.Size = new System.Drawing.Size(265, 24);
            this.label_bilgilendirme.TabIndex = 17;
            this.label_bilgilendirme.Text = "Ödünç alan öğrenci yok.";
            this.label_bilgilendirme.Visible = false;
            // 
            // btn_oduncVer
            // 
            this.btn_oduncVer.AutoSize = true;
            this.btn_oduncVer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btn_oduncVer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_oduncVer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_oduncVer.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_oduncVer.ForeColor = System.Drawing.Color.White;
            this.btn_oduncVer.Location = new System.Drawing.Point(307, 31);
            this.btn_oduncVer.Name = "btn_oduncVer";
            this.btn_oduncVer.Size = new System.Drawing.Size(141, 30);
            this.btn_oduncVer.TabIndex = 10;
            this.btn_oduncVer.Text = "Ödünç Ver";
            this.btn_oduncVer.UseVisualStyleBackColor = false;
            this.btn_oduncVer.Visible = false;
            this.btn_oduncVer.Click += new System.EventHandler(this.btn_oduncVer_Click);
            // 
            // btn_ogrenciler
            // 
            this.btn_ogrenciler.AutoSize = true;
            this.btn_ogrenciler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btn_ogrenciler.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ogrenciler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ogrenciler.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_ogrenciler.ForeColor = System.Drawing.Color.White;
            this.btn_ogrenciler.Location = new System.Drawing.Point(160, 31);
            this.btn_ogrenciler.Name = "btn_ogrenciler";
            this.btn_ogrenciler.Size = new System.Drawing.Size(141, 30);
            this.btn_ogrenciler.TabIndex = 7;
            this.btn_ogrenciler.Text = "Öğrenciler";
            this.btn_ogrenciler.UseVisualStyleBackColor = false;
            this.btn_ogrenciler.Click += new System.EventHandler(this.btn_ogrenciler_Click);
            // 
            // btn_iadeAl
            // 
            this.btn_iadeAl.AutoSize = true;
            this.btn_iadeAl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btn_iadeAl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_iadeAl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_iadeAl.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_iadeAl.ForeColor = System.Drawing.Color.White;
            this.btn_iadeAl.Location = new System.Drawing.Point(307, 31);
            this.btn_iadeAl.Name = "btn_iadeAl";
            this.btn_iadeAl.Size = new System.Drawing.Size(141, 30);
            this.btn_iadeAl.TabIndex = 9;
            this.btn_iadeAl.Text = "İade Al";
            this.btn_iadeAl.UseVisualStyleBackColor = false;
            this.btn_iadeAl.Click += new System.EventHandler(this.btn_iadeAl_Click);
            // 
            // dataGrid_odunc
            // 
            this.dataGrid_odunc.AllowUserToAddRows = false;
            this.dataGrid_odunc.AllowUserToDeleteRows = false;
            this.dataGrid_odunc.AllowUserToResizeColumns = false;
            this.dataGrid_odunc.AllowUserToResizeRows = false;
            this.dataGrid_odunc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGrid_odunc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGrid_odunc.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGrid_odunc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGrid_odunc.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGrid_odunc.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrid_odunc.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGrid_odunc.ColumnHeadersHeight = 50;
            this.dataGrid_odunc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGrid_odunc.GridColor = System.Drawing.Color.FloralWhite;
            this.dataGrid_odunc.Location = new System.Drawing.Point(14, 103);
            this.dataGrid_odunc.MultiSelect = false;
            this.dataGrid_odunc.Name = "dataGrid_odunc";
            this.dataGrid_odunc.ReadOnly = true;
            this.dataGrid_odunc.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGrid_odunc.RowHeadersVisible = false;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.dataGrid_odunc.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGrid_odunc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGrid_odunc.Size = new System.Drawing.Size(1024, 455);
            this.dataGrid_odunc.TabIndex = 1;
            this.dataGrid_odunc.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_odunc_CellDoubleClick);
            this.dataGrid_odunc.ColumnAdded += new System.Windows.Forms.DataGridViewColumnEventHandler(this.dataGrid_odunc_ColumnAdded);
            // 
            // FBookOdunc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1050, 600);
            this.Controls.Add(this.panel_container);
            this.Controls.Add(this.panelMenuHorizontal);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FBookOdunc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FBookOdunc";
            this.Load += new System.EventHandler(this.FBookOdunc_Load);
            this.panelMenuHorizontal.ResumeLayout(false);
            this.panelMenuHorizontal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icon_minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon_delete)).EndInit();
            this.panel_container.ResumeLayout(false);
            this.panel_menu.ResumeLayout(false);
            this.panel_menu.PerformLayout();
            this.groupBox_arama.ResumeLayout(false);
            this.groupBox_arama.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_odunc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenuHorizontal;
        public System.Windows.Forms.Label label_id;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox icon_minimize;
        private System.Windows.Forms.PictureBox icon_delete;
        private System.Windows.Forms.Panel panel_container;
        private System.Windows.Forms.Panel panel_menu;
        private System.Windows.Forms.Panel groupBox_arama;
        private System.Windows.Forms.TextBox txt_aranacakOgrenci;
        private System.Windows.Forms.Button btn_ogrenciAra;
        private System.Windows.Forms.Button btn_alanOgrenciler;
        private System.Windows.Forms.Label label_bilgilendirme;
        private System.Windows.Forms.Button btn_oduncVer;
        private System.Windows.Forms.Button btn_ogrenciler;
        private System.Windows.Forms.Button btn_iadeAl;
        private System.Windows.Forms.DataGridView dataGrid_odunc;
    }
}