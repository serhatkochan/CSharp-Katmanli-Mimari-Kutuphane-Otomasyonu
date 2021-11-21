namespace PresentationLayer
{
    partial class FBook
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGrid_book = new System.Windows.Forms.DataGridView();
            this.btn_kitapListele = new System.Windows.Forms.Button();
            this.btn_kitapAra = new System.Windows.Forms.Button();
            this.btn_kitapEkle = new System.Windows.Forms.Button();
            this.btn_kitapGuncelle = new System.Windows.Forms.Button();
            this.btn_kitapSil = new System.Windows.Forms.Button();
            this.btn_oduncIslemleri = new System.Windows.Forms.Button();
            this.txt_aranacakKitap = new System.Windows.Forms.TextBox();
            this.panel_menu = new System.Windows.Forms.TableLayoutPanel();
            this.panel_container = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_book)).BeginInit();
            this.panel_menu.SuspendLayout();
            this.panel_container.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGrid_book
            // 
            this.dataGrid_book.AllowUserToAddRows = false;
            this.dataGrid_book.AllowUserToDeleteRows = false;
            this.dataGrid_book.AllowUserToResizeColumns = false;
            this.dataGrid_book.AllowUserToResizeRows = false;
            this.dataGrid_book.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGrid_book.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGrid_book.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGrid_book.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGrid_book.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGrid_book.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrid_book.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGrid_book.ColumnHeadersHeight = 50;
            this.dataGrid_book.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGrid_book.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGrid_book.GridColor = System.Drawing.Color.FloralWhite;
            this.dataGrid_book.Location = new System.Drawing.Point(13, 69);
            this.dataGrid_book.MultiSelect = false;
            this.dataGrid_book.Name = "dataGrid_book";
            this.dataGrid_book.ReadOnly = true;
            this.dataGrid_book.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrid_book.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGrid_book.RowHeadersVisible = false;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.dataGrid_book.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGrid_book.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGrid_book.Size = new System.Drawing.Size(1024, 519);
            this.dataGrid_book.TabIndex = 0;
            this.dataGrid_book.ColumnAdded += new System.Windows.Forms.DataGridViewColumnEventHandler(this.dataGrid_book_ColumnAdded);
            // 
            // btn_kitapListele
            // 
            this.btn_kitapListele.AutoSize = true;
            this.btn_kitapListele.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btn_kitapListele.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_kitapListele.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_kitapListele.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_kitapListele.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_kitapListele.ForeColor = System.Drawing.Color.White;
            this.btn_kitapListele.Location = new System.Drawing.Point(601, 13);
            this.btn_kitapListele.Name = "btn_kitapListele";
            this.btn_kitapListele.Size = new System.Drawing.Size(141, 30);
            this.btn_kitapListele.TabIndex = 8;
            this.btn_kitapListele.Text = "Kitap Listele";
            this.btn_kitapListele.UseVisualStyleBackColor = false;
            this.btn_kitapListele.Click += new System.EventHandler(this.btn_kitapListele_Click);
            // 
            // btn_kitapAra
            // 
            this.btn_kitapAra.AutoSize = true;
            this.btn_kitapAra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btn_kitapAra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_kitapAra.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_kitapAra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_kitapAra.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_kitapAra.ForeColor = System.Drawing.Color.White;
            this.btn_kitapAra.Location = new System.Drawing.Point(895, 13);
            this.btn_kitapAra.Name = "btn_kitapAra";
            this.btn_kitapAra.Size = new System.Drawing.Size(142, 30);
            this.btn_kitapAra.TabIndex = 6;
            this.btn_kitapAra.Text = "Kitap Ara";
            this.btn_kitapAra.UseVisualStyleBackColor = false;
            this.btn_kitapAra.Click += new System.EventHandler(this.btn_kitapAra_Click);
            // 
            // btn_kitapEkle
            // 
            this.btn_kitapEkle.AutoSize = true;
            this.btn_kitapEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btn_kitapEkle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_kitapEkle.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_kitapEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_kitapEkle.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_kitapEkle.ForeColor = System.Drawing.Color.White;
            this.btn_kitapEkle.Location = new System.Drawing.Point(13, 13);
            this.btn_kitapEkle.Name = "btn_kitapEkle";
            this.btn_kitapEkle.Size = new System.Drawing.Size(141, 30);
            this.btn_kitapEkle.TabIndex = 11;
            this.btn_kitapEkle.Text = "Kitap Ekle";
            this.btn_kitapEkle.UseVisualStyleBackColor = false;
            this.btn_kitapEkle.Click += new System.EventHandler(this.btn_kitapEkle_Click);
            // 
            // btn_kitapGuncelle
            // 
            this.btn_kitapGuncelle.AutoSize = true;
            this.btn_kitapGuncelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btn_kitapGuncelle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_kitapGuncelle.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_kitapGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_kitapGuncelle.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_kitapGuncelle.ForeColor = System.Drawing.Color.White;
            this.btn_kitapGuncelle.Location = new System.Drawing.Point(160, 13);
            this.btn_kitapGuncelle.Name = "btn_kitapGuncelle";
            this.btn_kitapGuncelle.Size = new System.Drawing.Size(141, 30);
            this.btn_kitapGuncelle.TabIndex = 9;
            this.btn_kitapGuncelle.Text = "Kitap Güncelle";
            this.btn_kitapGuncelle.UseVisualStyleBackColor = false;
            this.btn_kitapGuncelle.Click += new System.EventHandler(this.btn_kitapGuncelle_Click);
            // 
            // btn_kitapSil
            // 
            this.btn_kitapSil.AutoSize = true;
            this.btn_kitapSil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btn_kitapSil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_kitapSil.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_kitapSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_kitapSil.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_kitapSil.ForeColor = System.Drawing.Color.White;
            this.btn_kitapSil.Location = new System.Drawing.Point(307, 13);
            this.btn_kitapSil.Name = "btn_kitapSil";
            this.btn_kitapSil.Size = new System.Drawing.Size(141, 30);
            this.btn_kitapSil.TabIndex = 7;
            this.btn_kitapSil.Text = "Kitap Sil";
            this.btn_kitapSil.UseVisualStyleBackColor = false;
            this.btn_kitapSil.Click += new System.EventHandler(this.btn_kitapSil_Click);
            // 
            // btn_oduncIslemleri
            // 
            this.btn_oduncIslemleri.AutoSize = true;
            this.btn_oduncIslemleri.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btn_oduncIslemleri.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_oduncIslemleri.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_oduncIslemleri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_oduncIslemleri.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_oduncIslemleri.ForeColor = System.Drawing.Color.White;
            this.btn_oduncIslemleri.Location = new System.Drawing.Point(454, 13);
            this.btn_oduncIslemleri.Name = "btn_oduncIslemleri";
            this.btn_oduncIslemleri.Size = new System.Drawing.Size(141, 30);
            this.btn_oduncIslemleri.TabIndex = 10;
            this.btn_oduncIslemleri.Text = "Odunc İşlemleri";
            this.btn_oduncIslemleri.UseVisualStyleBackColor = false;
            this.btn_oduncIslemleri.Click += new System.EventHandler(this.btn_oduncIslemleri_Click);
            // 
            // txt_aranacakKitap
            // 
            this.txt_aranacakKitap.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_aranacakKitap.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_aranacakKitap.Location = new System.Drawing.Point(748, 20);
            this.txt_aranacakKitap.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.txt_aranacakKitap.Name = "txt_aranacakKitap";
            this.txt_aranacakKitap.Size = new System.Drawing.Size(141, 23);
            this.txt_aranacakKitap.TabIndex = 14;
            this.txt_aranacakKitap.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_aranacakKitap.Enter += new System.EventHandler(this.txt_aranacakKitap_Enter);
            this.txt_aranacakKitap.Leave += new System.EventHandler(this.txt_aranacakKitap_Leave);
            // 
            // panel_menu
            // 
            this.panel_menu.ColumnCount = 7;
            this.panel_menu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.panel_menu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.panel_menu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.panel_menu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.panel_menu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.panel_menu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.panel_menu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.panel_menu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.panel_menu.Controls.Add(this.btn_kitapListele, 4, 0);
            this.panel_menu.Controls.Add(this.btn_kitapAra, 6, 0);
            this.panel_menu.Controls.Add(this.btn_kitapEkle, 0, 0);
            this.panel_menu.Controls.Add(this.btn_kitapGuncelle, 1, 0);
            this.panel_menu.Controls.Add(this.btn_kitapSil, 2, 0);
            this.panel_menu.Controls.Add(this.btn_oduncIslemleri, 3, 0);
            this.panel_menu.Controls.Add(this.txt_aranacakKitap, 5, 0);
            this.panel_menu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_menu.Location = new System.Drawing.Point(0, 0);
            this.panel_menu.Name = "panel_menu";
            this.panel_menu.Padding = new System.Windows.Forms.Padding(10);
            this.panel_menu.RowCount = 1;
            this.panel_menu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panel_menu.Size = new System.Drawing.Size(1050, 63);
            this.panel_menu.TabIndex = 17;
            // 
            // panel_container
            // 
            this.panel_container.Controls.Add(this.dataGrid_book);
            this.panel_container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_container.Location = new System.Drawing.Point(0, 0);
            this.panel_container.Name = "panel_container";
            this.panel_container.Size = new System.Drawing.Size(1050, 600);
            this.panel_container.TabIndex = 16;
            // 
            // FBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1050, 600);
            this.Controls.Add(this.panel_menu);
            this.Controls.Add(this.panel_container);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FBook";
            this.Text = "                                  ";
            this.Load += new System.EventHandler(this.FBook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_book)).EndInit();
            this.panel_menu.ResumeLayout(false);
            this.panel_menu.PerformLayout();
            this.panel_container.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGrid_book;
        private System.Windows.Forms.Button btn_kitapListele;
        private System.Windows.Forms.Button btn_kitapAra;
        private System.Windows.Forms.Button btn_kitapEkle;
        private System.Windows.Forms.Button btn_kitapGuncelle;
        private System.Windows.Forms.Button btn_kitapSil;
        private System.Windows.Forms.Button btn_oduncIslemleri;
        private System.Windows.Forms.TextBox txt_aranacakKitap;
        private System.Windows.Forms.TableLayoutPanel panel_menu;
        private System.Windows.Forms.Panel panel_container;
    }
}