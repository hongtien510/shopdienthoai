namespace ComsumerWinform
{
    partial class FormConsumer
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColumnHSX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnMoTa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPhuKien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnBH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnKM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNCP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.buttonExit = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonThem = new System.Windows.Forms.Button();
            this.buttonHSX = new System.Windows.Forms.Button();
            this.buttonTTDT = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(730, 377);
            this.panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnHSX,
            this.ColumnTDT,
            this.ColumnGia,
            this.ColumnMoTa,
            this.ColumnPhuKien,
            this.ColumnBH,
            this.ColumnKM,
            this.ColumnNCP});
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(723, 377);
            this.dataGridView1.TabIndex = 0;
            // 
            // ColumnHSX
            // 
            this.ColumnHSX.DataPropertyName = "TenHSX";
            this.ColumnHSX.HeaderText = "Hãng Sản Xuất";
            this.ColumnHSX.Name = "ColumnHSX";
            this.ColumnHSX.ReadOnly = true;
            // 
            // ColumnTDT
            // 
            this.ColumnTDT.DataPropertyName = "TenDT";
            this.ColumnTDT.HeaderText = "Tên Điện Thoại";
            this.ColumnTDT.Name = "ColumnTDT";
            this.ColumnTDT.ReadOnly = true;
            // 
            // ColumnGia
            // 
            this.ColumnGia.DataPropertyName = "Gia";
            this.ColumnGia.HeaderText = "Giá";
            this.ColumnGia.Name = "ColumnGia";
            this.ColumnGia.ReadOnly = true;
            // 
            // ColumnMoTa
            // 
            this.ColumnMoTa.DataPropertyName = "MoTa";
            this.ColumnMoTa.HeaderText = "Mô Tả";
            this.ColumnMoTa.Name = "ColumnMoTa";
            this.ColumnMoTa.ReadOnly = true;
            // 
            // ColumnPhuKien
            // 
            this.ColumnPhuKien.DataPropertyName = "PhuKien";
            this.ColumnPhuKien.HeaderText = "Phụ Kiện";
            this.ColumnPhuKien.Name = "ColumnPhuKien";
            this.ColumnPhuKien.ReadOnly = true;
            // 
            // ColumnBH
            // 
            this.ColumnBH.DataPropertyName = "BaoHanh";
            this.ColumnBH.HeaderText = "Bảo Hành";
            this.ColumnBH.Name = "ColumnBH";
            this.ColumnBH.ReadOnly = true;
            // 
            // ColumnKM
            // 
            this.ColumnKM.DataPropertyName = "KhuyenMai";
            this.ColumnKM.HeaderText = "Khuyến Mãi";
            this.ColumnKM.Name = "ColumnKM";
            this.ColumnKM.ReadOnly = true;
            // 
            // ColumnNCP
            // 
            this.ColumnNCP.DataPropertyName = "NgayCapNhat";
            this.ColumnNCP.HeaderText = "Ngày Cập Nhật";
            this.ColumnNCP.Name = "ColumnNCP";
            this.ColumnNCP.ReadOnly = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.buttonLoad);
            this.panel2.Location = new System.Drawing.Point(760, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(109, 41);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // buttonLoad
            // 
            this.buttonLoad.Location = new System.Drawing.Point(16, 9);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(75, 23);
            this.buttonLoad.TabIndex = 0;
            this.buttonLoad.Text = "Load";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.buttonExit);
            this.panel3.Location = new System.Drawing.Point(760, 348);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(109, 41);
            this.panel3.TabIndex = 1;
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(16, 9);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 23);
            this.buttonExit.TabIndex = 0;
            this.buttonExit.Text = "Thoát";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonTTDT);
            this.groupBox1.Controls.Add(this.buttonHSX);
            this.groupBox1.Controls.Add(this.buttonThem);
            this.groupBox1.Location = new System.Drawing.Point(760, 74);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(109, 145);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dữ Liệu";
            // 
            // buttonThem
            // 
            this.buttonThem.Location = new System.Drawing.Point(16, 24);
            this.buttonThem.Name = "buttonThem";
            this.buttonThem.Size = new System.Drawing.Size(75, 23);
            this.buttonThem.TabIndex = 1;
            this.buttonThem.Text = "Điện Thoại";
            this.buttonThem.UseVisualStyleBackColor = true;
            this.buttonThem.Click += new System.EventHandler(this.buttonThem_Click_1);
            // 
            // buttonHSX
            // 
            this.buttonHSX.Location = new System.Drawing.Point(16, 63);
            this.buttonHSX.Name = "buttonHSX";
            this.buttonHSX.Size = new System.Drawing.Size(75, 23);
            this.buttonHSX.TabIndex = 2;
            this.buttonHSX.Text = "HSX";
            this.buttonHSX.UseVisualStyleBackColor = true;
            this.buttonHSX.Click += new System.EventHandler(this.buttonHSX_Click);
            // 
            // buttonTTDT
            // 
            this.buttonTTDT.Location = new System.Drawing.Point(16, 104);
            this.buttonTTDT.Name = "buttonTTDT";
            this.buttonTTDT.Size = new System.Drawing.Size(75, 23);
            this.buttonTTDT.TabIndex = 3;
            this.buttonTTDT.Text = "TT ĐT";
            this.buttonTTDT.UseVisualStyleBackColor = true;
            this.buttonTTDT.Click += new System.EventHandler(this.buttonTTDT_Click);
            // 
            // FormConsumer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(881, 404);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FormConsumer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConsumerWinform";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnHSX;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnMoTa;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPhuKien;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnBH;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnKM;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNCP;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonThem;
        private System.Windows.Forms.Button buttonHSX;
        private System.Windows.Forms.Button buttonTTDT;


    }
}

