using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ComsumerWinform
{
    public partial class FormTTChiTiet : Form
    {
        DialogResult rsl;
        DataSet dts;
        DataTable table;
        ConsumerWinform.WSSDT.WSSDT dtct; 
        public FormTTChiTiet()
        {
            InitializeComponent();
        }

        private void panelTTChiTiet_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonThoat_Click(object sender, EventArgs e)
        {
            //FormTTChiTiet fTT = new FormTTChiTiet();
            this.Dispose();
        }

        private void FormTTChiTiet_Load(object sender, EventArgs e)
        {
            Frmload();
        }
        public void Frmload()
        {

            dtct = new ConsumerWinform.WSSDT.WSSDT();
            dts = new DataSet();
            table = new DataTable();
            string sql = "";

            sql = "SELECT idDT, TenDT FROM DIENTHOAI";// WHERE idHSX =" +"'"+txtIDHSX+"'";
            dts = dtct.SelectQuery(sql);
            table = dts.Tables[0];
            //ds = dtct.SelectQuery(sql);

            comboBoxDT.DisplayMember = "TenDT";
            comboBoxDT.ValueMember = "idDT";
            comboBoxDT.DataSource = table;

        }

        private void comboBoxDT_SelectedIndexChanged(object sender, EventArgs e)
        {
            ReadData();
        }
        public void ReadData()
        {            
            int id = int.Parse(comboBoxDT.SelectedValue.ToString());
            ConsumerWinform.WSSDT.WSSDT dtct = new ConsumerWinform.WSSDT.WSSDT();
            //IDataReader reader = new IDataReader();
            dts = new DataSet();
            table = new DataTable();
            // table dien thoai
            string dt = "";
            dt = "SELECT BaiViet  FROM ThongTinChiTiet  WHERE idDT ='" + id + "'";
            dts = dtct.SelectQuery(dt);
            //MessageBox.Show(dt);
            table = dts.Tables[0];
            if (table.Rows.Count > 0)
            {
                txtBaiViet.Text = table.Rows[0][0].ToString();
            }
            else
            {
                rsl = MessageBox.Show(this, "Điện thoại này chưa có bài viết. Nhấn Ok để viết bài..!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
                txtBaiViet.Text = "";
            }
        }
        int id; string noidung;
        public void add()
        {          
            
            id =int.Parse( comboBoxDT.SelectedValue.ToString());
            noidung = txtBaiViet.Text;
            int rs;
            ConsumerWinform.WSSDT.WSSDT dtct = new ConsumerWinform.WSSDT.WSSDT();
            string sql = "";
            sql = "INSERT INTO ThongTinChiTiet (idDT, BaiViet) VALUES ('"+id+"', '" + noidung + "')";
            //MessageBox.Show(sql);
            rs = dtct.InsertDeleteQuery(sql);  
        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
            add();
            Frmload();
        }

        public void Xoa()
        {
            id = int.Parse(comboBoxDT.SelectedValue.ToString());
            
            int rs;
            ConsumerWinform.WSSDT.WSSDT dtct = new ConsumerWinform.WSSDT.WSSDT();
            string sql = "";
            sql = "DELETE FROM THONGTINCHITIET WHERE IDDT='" + id + "'";
            //MessageBox.Show(sql);
            rsl = MessageBox.Show(this, "Bạn Có Muốn Xóa Không...?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(rsl == DialogResult.Yes)
            {
             rs = dtct.InsertDeleteQuery(sql);  
            }
            else
            {
                Frmload();
            }
        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            Xoa();
            Frmload();
        }

        public void edit()
        {
            id = int.Parse(comboBoxDT.SelectedValue.ToString());
            noidung = txtBaiViet.Text;
            int rs;
            ConsumerWinform.WSSDT.WSSDT dtct = new ConsumerWinform.WSSDT.WSSDT();
            string sql = "";
            sql = "UPDATE THONGTINCHITIET SET BAIVIET='"+noidung+"' WHERE IDDT='" + id + "'";
            rs = dtct.InsertDeleteQuery(sql);
        }

        private void buttonSua_Click(object sender, EventArgs e)
        {
            edit();
            Frmload();
        }
           
    }
}
