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
    public partial class FormHSX : Form
    {
        DialogResult rsl;
        int id;
        string ten;
        int tt;
        int ah;
        //FormThem fthem = new FormThem();
        public FormHSX()
        {
            InitializeComponent();
            
        }

        private void buttonThoat_Click(object sender, EventArgs e)
        {            
            this.Dispose();
        }

        private void FormHSX_Load(object sender, EventArgs e)
        {

            Frmload();
        }


        public void Frmload()
        {

            ConsumerWinform.WSSDT.WSSDT dtct = new ConsumerWinform.WSSDT.WSSDT();
            DataSet dts = new DataSet();
            DataTable table = new DataTable();
            string sql = "";

            sql = "SELECT idHSX, TenHSX, ThuTu, AnHien FROM HANGSANXUAT";// WHERE idHSX =" +"'"+txtIDHSX+"'";
            dts = dtct.SelectQuery(sql);
            table = dts.Tables[0];
            //ds = dtct.SelectQuery(sql);
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = table;            

        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
            if(txtTenHSX.Text!="" && txtThuTu.Text!="" && txtAnHien.Text!= "")
            {
                Them();
                Frmload();
            }
            else
            {
                rsl = MessageBox.Show(this, "Bạn Chưa Nhập Đủ Thông Tin...!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
        }
            public void Them()
            {
                //id = int.Parse(txtIDHSX.Text);
                ten =(string) txtTenHSX.Text;
                tt = int.Parse(txtThuTu.Text);
                ah = int.Parse(txtAnHien.Text);
                int rs;
                ConsumerWinform.WSSDT.WSSDT dtct = new ConsumerWinform.WSSDT.WSSDT();
                string sql = "";
                sql = "INSERT INTO HANGSANXUAT (TenHSX, ThuTu, AnHien) VALUES ('" + ten + "','" + tt + "','" + ah + "')";
                //MessageBox.Show(sql);
                rs = dtct.InsertDeleteQuery(sql);  

            }
        // kiem tra co phai la so hay khong
        public bool IsNumber(string testvalue)
        {
            foreach (char c in testvalue)
            {
                if (!Char.IsDigit(c))
                    return false;
            }
            return true;
        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {
           
            if (IsNumber(txtIDHSX.Text))
            {
                Xoa();
                Frmload();
            }
            else
            {
                rsl = MessageBox.Show(this, "ID Không Tồn Tại...!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
 
        }

        public void Xoa()
        {
            id = int.Parse(txtIDHSX.Text);
            int rs;
            ConsumerWinform.WSSDT.WSSDT dtct = new ConsumerWinform.WSSDT.WSSDT();
            string sql = "";
            sql = "DELETE FROM HANGSANXUAT WHERE idHSX='"+id+"'";
            //MessageBox.Show(sql);
            rsl = MessageBox.Show(this, "Bạn Có Muốn Xóa Không...?","Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rsl == DialogResult.Yes)
            {
                rs = dtct.InsertDeleteQuery(sql);
            }
            else { txtIDHSX.Text = ""; }
            txtIDHSX.Text = ""; 
        }

        private void txtIDHSX_MouseClick(object sender, MouseEventArgs e)
        {
            txtIDHSX.Text = "";
        }

        public void Sua()
        {
            ten = txtTenHSX.Text;
            tt = int.Parse(txtThuTu.Text);
            id = int.Parse(txtIDHSX.Text);
            ah = int.Parse(txtAnHien.Text);
            int rs;
            ConsumerWinform.WSSDT.WSSDT dtct = new ConsumerWinform.WSSDT.WSSDT();
            string sql = "";
            sql = "UPDATE HANGSANXUAT SET TenHSX=N'" + ten + "',ThuTu='" + tt + "',AnHien='" + ah + "' WHERE idHSX='" + id + "'";
            //MessageBox.Show(sql);
            rs = dtct.InsertDeleteQuery(sql);

        }

        private void buttonSua_Click(object sender, EventArgs e)
        {               
               Sua();            
               Frmload();
        }
        public void ReadData()
        {
            id = int.Parse(txtIDHSX.Text);
            ConsumerWinform.WSSDT.WSSDT dtct = new ConsumerWinform.WSSDT.WSSDT();
            //IDataReader reader = new IDataReader();
            DataSet dts = new DataSet();
            DataTable table = new DataTable();
            string sql = "";
            sql = "SELECT TenHSX, ThuTu, AnHien FROM HANGSANXUAT WHERE idHSX ='"+id+"'";
            dts = dtct.SelectQuery(sql);
            table = dts.Tables[0];
            //txtIDHSX.Text = table.Rows[0][0].ToString();
            txtTenHSX.Text = table.Rows[0][0].ToString();
            txtThuTu.Text = table.Rows[0][1].ToString();
            txtAnHien.Text = table.Rows[0][2].ToString();
        }


             
    }
}
