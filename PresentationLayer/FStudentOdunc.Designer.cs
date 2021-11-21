namespace PresentationLayer
{
    partial class FStudentOdunc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FStudentOdunc));
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
            this.txt_aranacakKitap = new System.Windows.Forms.TextBox();
            this.btn_kitapAra = new System.Windows.Forms.Button();
            this.btn_aldigimKitap = new System.Windows.Forms.Button();
            this.label_bilgilendirme = new System.Windows.Forms.Label();
            this.btn_oduncAl = new System.Windows.Forms.Button();
            this.btn_iadeEt = new System.Windows.Forms.Button();
            this.btn_kitaplar = new System.Windows.Forms.Button();
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
            this.panelMenuHorizontal.TabIndex = 4;
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
            this.label7.Size = new System.Drawing.Size(293, 21);
            this.label7.TabIndex = 6;
            this.label7.Text = "Ödünç İşlemleri Yapılan Öğrenci  ID :";
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
            this.panel_container.TabIndex = 5;
            // 
            // panel_menu
            // 
            this.panel_menu.Controls.Add(this.groupBox_arama);
            this.panel_menu.Controls.Add(this.btn_aldigimKitap);
            this.panel_menu.Controls.Add(this.label_bilgilendirme);
            this.panel_menu.Controls.Add(this.btn_oduncAl);
            this.panel_menu.Controls.Add(this.btn_iadeEt);
            this.panel_menu.Controls.Add(this.btn_kitaplar);
            this.panel_menu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_menu.Location = new System.Drawing.Point(0, 0);
            this.panel_menu.Name = "panel_menu";
            this.panel_menu.Size = new System.Drawing.Size(1050, 100);
            this.panel_menu.TabIndex = 18;
            // 
            // groupBox_arama
            // 
            this.groupBox_arama.Controls.Add(this.txt_aranacakKitap);
            this.groupBox_arama.Controls.Add(this.btn_kitapAra);
            this.groupBox_arama.Location = new System.Drawing.Point(677, 5);
            this.groupBox_arama.Name = "groupBox_arama";
            this.groupBox_arama.Size = new System.Drawing.Size(370, 92);
            this.groupBox_arama.TabIndex = 19;
            // 
            // txt_aranacakKitap
            // 
            this.txt_aranacakKitap.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_aranacakKitap.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_aranacakKitap.Location = new System.Drawing.Point(47, 35);
            this.txt_aranacakKitap.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.txt_aranacakKitap.Name = "txt_aranacakKitap";
            this.txt_aranacakKitap.Size = new System.Drawing.Size(162, 23);
            this.txt_aranacakKitap.TabIndex = 14;
            this.txt_aranacakKitap.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_aranacakKitap.Enter += new System.EventHandler(this.txt_aranacakKitap_Enter);
            this.txt_aranacakKitap.Leave += new System.EventHandler(this.txt_aranacakKitap_Leave);
            // 
            // btn_kitapAra
            // 
            this.btn_kitapAra.AutoSize = true;
            this.btn_kitapAra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btn_kitapAra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_kitapAra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_kitapAra.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_kitapAra.ForeColor = System.Drawing.Color.White;
            this.btn_kitapAra.Location = new System.Drawing.Point(215, 32);
            this.btn_kitapAra.Name = "btn_kitapAra";
            this.btn_kitapAra.Size = new System.Drawing.Size(142, 30);
            this.btn_kitapAra.TabIndex = 6;
            this.btn_kitapAra.Text = "Kitap Ara";
            this.btn_kitapAra.UseVisualStyleBackColor = false;
            this.btn_kitapAra.Click += new System.EventHandler(this.btn_kitapAra_Click);
            // 
            // btn_aldigimKitap
            // 
            this.btn_aldigimKitap.AutoSize = true;
            this.btn_aldigimKitap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btn_aldigimKitap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_aldigimKitap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_aldigimKitap.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_aldigimKitap.ForeColor = System.Drawing.Color.White;
            this.btn_aldigimKitap.Location = new System.Drawing.Point(13, 31);
            this.btn_aldigimKitap.Name = "btn_aldigimKitap";
            this.btn_aldigimKitap.Size = new System.Drawing.Size(141, 30);
            this.btn_aldigimKitap.TabIndex = 11;
            this.btn_aldigimKitap.Text = "Aldığım Kitaplar";
            this.btn_aldigimKitap.UseVisualStyleBackColor = false;
            this.btn_aldigimKitap.Click += new System.EventHandler(this.btn_aldigimKitap_Click);
            // 
            // label_bilgilendirme
            // 
            this.label_bilgilendirme.AutoSize = true;
            this.label_bilgilendirme.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_bilgilendirme.Location = new System.Drawing.Point(382, 76);
            this.label_bilgilendirme.Name = "label_bilgilendirme";
            this.label_bilgilendirme.Size = new System.Drawing.Size(274, 24);
            this.label_bilgilendirme.TabIndex = 17;
            this.label_bilgilendirme.Text = "Ödünç aldığınız kitap yok.";
            this.label_bilgilendirme.Visible = false;
            // 
            // btn_oduncAl
            // 
            this.btn_oduncAl.AutoSize = true;
            this.btn_oduncAl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btn_oduncAl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_oduncAl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_oduncAl.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_oduncAl.ForeColor = System.Drawing.Color.White;
            this.btn_oduncAl.Location = new System.Drawing.Point(307, 31);
            this.btn_oduncAl.Name = "btn_oduncAl";
            this.btn_oduncAl.Size = new System.Drawing.Size(141, 30);
            this.btn_oduncAl.TabIndex = 10;
            this.btn_oduncAl.Text = "Ödünç Al";
            this.btn_oduncAl.UseVisualStyleBackColor = false;
            this.btn_oduncAl.Visible = false;
            this.btn_oduncAl.Click += new System.EventHandler(this.btn_oduncAl_Click);
            // 
            // btn_iadeEt
            // 
            this.btn_iadeEt.AutoSize = true;
            this.btn_iadeEt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btn_iadeEt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_iadeEt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_iadeEt.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_iadeEt.ForeColor = System.Drawing.Color.White;
            this.btn_iadeEt.Location = new System.Drawing.Point(160, 31);
            this.btn_iadeEt.Name = "btn_iadeEt";
            this.btn_iadeEt.Size = new System.Drawing.Size(141, 30);
            this.btn_iadeEt.TabIndex = 7;
            this.btn_iadeEt.Text = "Kitaplar";
            this.btn_iadeEt.UseVisualStyleBackColor = false;
            this.btn_iadeEt.Click += new System.EventHandler(this.btn_kitaplar_Click);
            // 
            // btn_kitaplar
            // 
            this.btn_kitaplar.AutoSize = true;
            this.btn_kitaplar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btn_kitaplar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_kitaplar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_kitaplar.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_kitaplar.ForeColor = System.Drawing.Color.White;
            this.btn_kitaplar.Location = new System.Drawing.Point(307, 31);
            this.btn_kitaplar.Name = "btn_kitaplar";
            this.btn_kitaplar.Size = new System.Drawing.Size(141, 30);
            this.btn_kitaplar.TabIndex = 9;
            this.btn_kitaplar.Text = "İade Et";
            this.btn_kitaplar.UseVisualStyleBackColor = false;
            this.btn_kitaplar.Click += new System.EventHandler(this.btn_iadeEt_Click);
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
            // FStudentOdunc
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
            this.Name = "FStudentOdunc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FStudentOdunc";
            this.Load += new System.EventHandler(this.FStudentOdunc_Load);
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
        private System.Windows.Forms.DataGridView dataGrid_odunc;
        private System.Windows.Forms.Button btn_kitapAra;
        private System.Windows.Forms.Button btn_aldigimKitap;
        private System.Windows.Forms.Button btn_kitaplar;
        private System.Windows.Forms.Button btn_iadeEt;
        private System.Windows.Forms.TextBox txt_aranacakKitap;
        private System.Windows.Forms.Label label_bilgilendirme;
        private System.Windows.Forms.Button btn_oduncAl;
        private System.Windows.Forms.Panel panel_menu;
        private System.Windows.Forms.Panel groupBox_arama;
    }
}