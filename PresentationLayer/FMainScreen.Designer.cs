namespace PresentationLayer
{
    partial class FMainScreen
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
            this.panel_container = new System.Windows.Forms.Panel();
            this.panel_top = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label_bilgilendirme = new System.Windows.Forms.Label();
            this.dataGrid_student = new System.Windows.Forms.DataGridView();
            this.panel_top.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_student)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_container
            // 
            this.panel_container.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_container.Location = new System.Drawing.Point(241, 305);
            this.panel_container.Margin = new System.Windows.Forms.Padding(4);
            this.panel_container.Name = "panel_container";
            this.panel_container.Size = new System.Drawing.Size(548, 282);
            this.panel_container.TabIndex = 0;
            // 
            // panel_top
            // 
            this.panel_top.Controls.Add(this.tableLayoutPanel1);
            this.panel_top.Controls.Add(this.dataGrid_student);
            this.panel_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_top.Location = new System.Drawing.Point(0, 0);
            this.panel_top.Name = "panel_top";
            this.panel_top.Size = new System.Drawing.Size(1050, 262);
            this.panel_top.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label_bilgilendirme, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(7, 218);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1035, 55);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // label_bilgilendirme
            // 
            this.label_bilgilendirme.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_bilgilendirme.AutoSize = true;
            this.label_bilgilendirme.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_bilgilendirme.Location = new System.Drawing.Point(3, 0);
            this.label_bilgilendirme.Name = "label_bilgilendirme";
            this.label_bilgilendirme.Size = new System.Drawing.Size(1029, 24);
            this.label_bilgilendirme.TabIndex = 19;
            this.label_bilgilendirme.Text = "Bilgi";
            this.label_bilgilendirme.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dataGrid_student
            // 
            this.dataGrid_student.AllowUserToAddRows = false;
            this.dataGrid_student.AllowUserToDeleteRows = false;
            this.dataGrid_student.AllowUserToResizeColumns = false;
            this.dataGrid_student.AllowUserToResizeRows = false;
            this.dataGrid_student.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGrid_student.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGrid_student.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGrid_student.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGrid_student.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGrid_student.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrid_student.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGrid_student.ColumnHeadersHeight = 50;
            this.dataGrid_student.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGrid_student.GridColor = System.Drawing.Color.FloralWhite;
            this.dataGrid_student.Location = new System.Drawing.Point(7, 12);
            this.dataGrid_student.MultiSelect = false;
            this.dataGrid_student.Name = "dataGrid_student";
            this.dataGrid_student.ReadOnly = true;
            this.dataGrid_student.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGrid_student.RowHeadersVisible = false;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.dataGrid_student.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGrid_student.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGrid_student.Size = new System.Drawing.Size(1035, 218);
            this.dataGrid_student.TabIndex = 1;
            this.dataGrid_student.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_student_CellContentClick);
            this.dataGrid_student.ColumnAdded += new System.Windows.Forms.DataGridViewColumnEventHandler(this.dataGrid_student_ColumnAdded);
            // 
            // FMainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1050, 600);
            this.Controls.Add(this.panel_top);
            this.Controls.Add(this.panel_container);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FMainScreen";
            this.Text = "FMainScreen";
            this.Load += new System.EventHandler(this.FMainScreen_Load);
            this.panel_top.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_student)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_container;
        private System.Windows.Forms.Panel panel_top;
        private System.Windows.Forms.DataGridView dataGrid_student;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label_bilgilendirme;
    }
}