namespace ComsumerWinform
{
    partial class FormHSX
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panelHSX = new System.Windows.Forms.Panel();
            this.txtAnHien = new System.Windows.Forms.TextBox();
            this.txtThuTu = new System.Windows.Forms.TextBox();
            this.txtTenHSX = new System.Windows.Forms.TextBox();
            this.txtIDHSX = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonThem = new System.Windows.Forms.Button();
            this.buttonThoat = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonSua = new System.Windows.Forms.Button();
            this.buttonXoa = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.panelHSX.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panelHSX);
            this.groupBox1.Location = new System.Drawing.Point(11, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(320, 166);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hãng Sản Xuất";
            // 
            // panelHSX
            // 
            this.panelHSX.Controls.Add(this.txtAnHien);
            this.panelHSX.Controls.Add(this.txtThuTu);
            this.panelHSX.Controls.Add(this.txtTenHSX);
            this.panelHSX.Controls.Add(this.txtIDHSX);
            this.panelHSX.Controls.Add(this.label4);
            this.panelHSX.Controls.Add(this.label3);
            this.panelHSX.Controls.Add(this.label2);
            this.panelHSX.Controls.Add(this.label1);
            this.panelHSX.Location = new System.Drawing.Point(6, 19);
            this.panelHSX.Name = "panelHSX";
            this.panelHSX.Size = new System.Drawing.Size(300, 134);
            this.panelHSX.TabIndex = 0;
            // 
            // txtAnHien
            // 
            this.txtAnHien.Location = new System.Drawing.Point(130, 102);
            this.txtAnHien.Name = "txtAnHien";
            this.txtAnHien.Size = new System.Drawing.Size(149, 20);
            this.txtAnHien.TabIndex = 4;
            // 
            // txtThuTu
            // 
            this.txtThuTu.Location = new System.Drawing.Point(130, 68);
            this.txtThuTu.Name = "txtThuTu";
            this.txtThuTu.Size = new System.Drawing.Size(149, 20);
            this.txtThuTu.TabIndex = 3;
            // 
            // txtTenHSX
            // 
            this.txtTenHSX.Location = new System.Drawing.Point(130, 39);
            this.txtTenHSX.Name = "txtTenHSX";
            this.txtTenHSX.Size = new System.Drawing.Size(149, 20);
            this.txtTenHSX.TabIndex = 2;
            // 
            // txtIDHSX
            // 
            this.txtIDHSX.Location = new System.Drawing.Point(130, 8);
            this.txtIDHSX.Name = "txtIDHSX";
            this.txtIDHSX.Size = new System.Drawing.Size(149, 20);
            this.txtIDHSX.TabIndex = 1;
            this.txtIDHSX.Text = "ID Cần Sửa Hay Xóa .!";
            this.txtIDHSX.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtIDHSX_MouseClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Ẩn /Hiện :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Thứ Tự :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên Hãng Sản Xuất :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID Hãng Sản Xuất :";
            // 
            // buttonThem
            // 
            this.buttonThem.Location = new System.Drawing.Point(378, 18);
            this.buttonThem.Name = "buttonThem";
            this.buttonThem.Size = new System.Drawing.Size(75, 23);
            this.buttonThem.TabIndex = 5;
            this.buttonThem.Text = "Thêm";
            this.buttonThem.UseVisualStyleBackColor = true;
            this.buttonThem.Click += new System.EventHandler(this.buttonThem_Click);
            // 
            // buttonThoat
            // 
            this.buttonThoat.Location = new System.Drawing.Point(378, 154);
            this.buttonThoat.Name = "buttonThoat";
            this.buttonThoat.Size = new System.Drawing.Size(75, 23);
            this.buttonThoat.TabIndex = 6;
            this.buttonThoat.Text = "Thoát";
            this.buttonThoat.UseVisualStyleBackColor = true;
            this.buttonThoat.Click += new System.EventHandler(this.buttonThoat_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(7, 192);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(452, 189);
            this.panel1.TabIndex = 8;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridView1.Location = new System.Drawing.Point(3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(444, 180);
            this.dataGridView1.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "idHSX";
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "TenHSX";
            this.Column2.HeaderText = "Tên HSX";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "ThuTu";
            this.Column3.HeaderText = "Thứ Tự";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "AnHien";
            this.Column4.HeaderText = "Ẩn /Hiện";
            this.Column4.Name = "Column4";
            // 
            // buttonSua
            // 
            this.buttonSua.Location = new System.Drawing.Point(378, 57);
            this.buttonSua.Name = "buttonSua";
            this.buttonSua.Size = new System.Drawing.Size(75, 23);
            this.buttonSua.TabIndex = 9;
            this.buttonSua.Text = "Sửa";
            this.buttonSua.UseVisualStyleBackColor = true;
            this.buttonSua.Click += new System.EventHandler(this.buttonSua_Click);
            // 
            // buttonXoa
            // 
            this.buttonXoa.Location = new System.Drawing.Point(378, 125);
            this.buttonXoa.Name = "buttonXoa";
            this.buttonXoa.Size = new System.Drawing.Size(75, 23);
            this.buttonXoa.TabIndex = 10;
            this.buttonXoa.Text = "Xóa";
            this.buttonXoa.UseVisualStyleBackColor = true;
            this.buttonXoa.Click += new System.EventHandler(this.buttonXoa_Click);
            // 
            // FormHSX
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 387);
            this.Controls.Add(this.buttonXoa);
            this.Controls.Add(this.buttonSua);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonThoat);
            this.Controls.Add(this.buttonThem);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormHSX";
            this.Text = "Hãng Sản Xuất";
            this.Load += new System.EventHandler(this.FormHSX_Load);
            this.groupBox1.ResumeLayout(false);
            this.panelHSX.ResumeLayout(false);
            this.panelHSX.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panelHSX;
        private System.Windows.Forms.TextBox txtAnHien;
        private System.Windows.Forms.TextBox txtThuTu;
        private System.Windows.Forms.TextBox txtTenHSX;
        private System.Windows.Forms.TextBox txtIDHSX;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonThem;
        private System.Windows.Forms.Button buttonThoat;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Button buttonSua;
        private System.Windows.Forms.Button buttonXoa;
    }
}