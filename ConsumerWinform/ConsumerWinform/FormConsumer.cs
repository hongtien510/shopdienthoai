using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace ComsumerWinform
{
     public partial class FormConsumer : Form
    {
         public void showformHSX()
         {
             FormHSX fhsx = new FormHSX();
             fhsx.Show();
         }
         public void showformthem()
         {
             FormThem fthem = new FormThem();
             fthem.Show();
         }

         public void showformTTCT()
         {
             FormTTChiTiet fttct = new FormTTChiTiet();
             fttct.Show();
         }
       
        //*******************************
        public FormConsumer()
        {
            InitializeComponent();          
            
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            /*
            //WSSDT dtct = new WSSDT();
            //ComsumerWinform.WSSDT.WSSDTSoapClient dtct = new ComsumerWinform.WSSDT.WSSDTSoapClient();
            ComsumerWinform.WSSDT.WSSDT dtct = new ComsumerWinform.WSSDT.WSSDT();
            DataSet ds = new DataSet();

            string sql = "";
            sql = "SELECT TenHSX, TenDT, Gia, MoTa, PhuKien, BaoHanh, KhuyenMai, NgayCapNhat ";
            sql += "FROM DIENTHOAI DT, HANGSANXUAT HSX ";
            sql += "WHERE DT.idHSX = HSX.idHSX ";

            ds = dtct.SelectQuery(sql);
           // Colum
            dataGridView1.DataSource = ds;
            */
        }


        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonThem_Click(object sender, EventArgs e)
        {

            showformthem();

        }



        private void buttonLoad_Click(object sender, EventArgs e)
        {
            //WSSDT dtct = new WSSDT();
            //ComsumerWinform.WSSDT.WSSDTSoapClient dtct = new ComsumerWinform.WSSDT.WSSDTSoapClient();
            ConsumerWinform.WSSDT.WSSDT dtct = new ConsumerWinform.WSSDT.WSSDT();
            DataSet dts = new DataSet();
            DataTable table = new DataTable();
            string sql = "";

            sql = "SELECT TenHSX, TenDT, Gia, MoTa, PhuKien, BaoHanh, KhuyenMai, NgayCapNhat ";
            sql += "FROM DIENTHOAI DT, HANGSANXUAT HSX ";
            sql += "WHERE DT.idHSX = HSX.idHSX ";

            dts = dtct.SelectQuery(sql);
            table = dts.Tables[0];
            //ds = dtct.SelectQuery(sql);
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = table;
            
        }

        private void buttonHSX_Click(object sender, EventArgs e)
        {
            showformHSX();
        }

        private void buttonThem_Click_1(object sender, EventArgs e)
        {
            showformthem();
        }

        private void buttonTTDT_Click(object sender, EventArgs e)
        {
            showformTTCT();
        }

    }
}
