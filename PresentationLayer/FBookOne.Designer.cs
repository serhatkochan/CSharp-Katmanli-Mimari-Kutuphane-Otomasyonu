namespace PresentationLayer
{
    partial class FBookOne
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FBookOne));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelMenuHorizontal = new System.Windows.Forms.Panel();
            this.label_id = new System.Windows.Forms.Label();
            this.label_bilgilendirme_id = new System.Windows.Forms.Label();
            this.icon_minimize = new System.Windows.Forms.PictureBox();
            this.icon_delete = new System.Windows.Forms.PictureBox();
            this.panel_container = new System.Windows.Forms.Panel();
            this.dataGrid_book = new System.Windows.Forms.DataGridView();
            this.panelMenuHorizontal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icon_minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon_delete)).BeginInit();
            this.panel_container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_book)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenuHorizontal
            // 
            this.panelMenuHorizontal.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelMenuHorizontal.Controls.Add(this.label_id);
            this.panelMenuHorizontal.Controls.Add(this.label_bilgilendirme_id);
            this.panelMenuHorizontal.Controls.Add(this.icon_minimize);
            this.panelMenuHorizontal.Controls.Add(this.icon_delete);
            this.panelMenuHorizontal.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMenuHorizontal.Location = new System.Drawing.Point(0, 0);
            this.panelMenuHorizontal.Name = "panelMenuHorizontal";
            this.panelMenuHorizontal.Size = new System.Drawing.Size(1034, 39);
            this.panelMenuHorizontal.TabIndex = 25;
            this.panelMenuHorizontal.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelMenuHorizontal_MouseDown);
            // 
            // label_id
            // 
            this.label_id.AutoSize = true;
            this.label_id.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_id.Location = new System.Drawing.Point(117, 12);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(24, 21);
            this.label_id.TabIndex = 7;
            this.label_id.Text = "id";
            this.label_id.Click += new System.EventHandler(this.label_id_Click);
            // 
            // label_bilgilendirme_id
            // 
            this.label_bilgilendirme_id.AutoSize = true;
            this.label_bilgilendirme_id.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_bilgilendirme_id.Location = new System.Drawing.Point(12, 12);
            this.label_bilgilendirme_id.Name = "label_bilgilendirme_id";
            this.label_bilgilendirme_id.Size = new System.Drawing.Size(80, 21);
            this.label_bilgilendirme_id.TabIndex = 6;
            this.label_bilgilendirme_id.Text = "Kitap ID :";
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
            // panel_container
            // 
            this.panel_container.Controls.Add(this.dataGrid_book);
            this.panel_container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_container.Location = new System.Drawing.Point(0, 39);
            this.panel_container.Name = "panel_container";
            this.panel_container.Size = new System.Drawing.Size(1034, 222);
            this.panel_container.TabIndex = 26;
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
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Schoolbook", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrid_book.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGrid_book.ColumnHeadersHeight = 50;
            this.dataGrid_book.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGrid_book.GridColor = System.Drawing.Color.FloralWhite;
            this.dataGrid_book.Location = new System.Drawing.Point(7, 15);
            this.dataGrid_book.MultiSelect = false;
            this.dataGrid_book.Name = "dataGrid_book";
            this.dataGrid_book.ReadOnly = true;
            this.dataGrid_book.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGrid_book.RowHeadersVisible = false;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.dataGrid_book.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGrid_book.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGrid_book.Size = new System.Drawing.Size(1019, 195);
            this.dataGrid_book.TabIndex = 1;
            // 
            // FBookOne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1034, 261);
            this.Controls.Add(this.panel_container);
            this.Controls.Add(this.panelMenuHorizontal);
            this.Font = new System.Drawing.Font("Century Schoolbook", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FBookOne";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FBookOne";
            this.Load += new System.EventHandler(this.FBookOne_Load);
            this.panelMenuHorizontal.ResumeLayout(false);
            this.panelMenuHorizontal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icon_minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon_delete)).EndInit();
            this.panel_container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_book)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenuHorizontal;
        public System.Windows.Forms.Label label_id;
        private System.Windows.Forms.PictureBox icon_minimize;
        private System.Windows.Forms.PictureBox icon_delete;
        private System.Windows.Forms.Panel panel_container;
        private System.Windows.Forms.DataGridView dataGrid_book;
        public System.Windows.Forms.Label label_bilgilendirme_id;
    }
}