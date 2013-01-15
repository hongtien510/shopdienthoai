using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace ShopDienThoai
{
    public partial class dienthoaichitietForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ShowDienThoaiChiTiet();
                ShowThongTinChiTiet();
                ShowDienThoaiDongGia();
                ShowTinhNangDienThoai();
            }
        }

        public void ShowDienThoaiChiTiet()
        {
            string idDT = Request.QueryString["idDT"].ToString();

            WSSDT.WSSDT dtct = new WSSDT.WSSDT();
            DataSet ds = new DataSet();

            string sql="";
            sql  = "SELECT idDT, TenDT, TenHSX, Gia, HinhAnh, MoTa, PhuKien, BaoHanh, KhuyenMai, NgayCapNhat ";
            sql += "FROM DIENTHOAI DT, HANGSANXUAT HSX ";
            sql += "WHERE DT.idHSX = HSX.idHSX AND DT.idDT = " + idDT;

            //Response.Write(sql);
            ds = dtct.SelectQuery(sql);

            DienThoaiChiTiet.DataSource = ds;
            DienThoaiChiTiet.DataBind();
        }

        public void ShowThongTinChiTiet()
        {
            string idDT = Request.QueryString["idDT"].ToString();

            WSSDT.WSSDT dtct = new WSSDT.WSSDT();
            DataSet ds = new DataSet();

            string sql = "";
            sql = "SELECT BaiViet ";
            sql += "FROM THONGTINCHITIET ";
            sql += "WHERE idDT = " + idDT;

            //Response.Write(sql);
            ds = dtct.SelectQuery(sql);

            ThongTinChiTiet.DataSource = ds;
            ThongTinChiTiet.DataBind();
        }

        public void ShowDienThoaiDongGia()
        {
            string idDT = Request.QueryString["idDT"].ToString();

            WSSDT.WSSDT dtdg = new WSSDT.WSSDT();
            DataSet ds = new DataSet();

            string sql = "";

            sql  = "SELECT idDT, TenDT, Gia ";
            sql += "FROM DIENTHOAI ";
            sql += "WHERE Gia >= ((SELECT Gia FROM DIENTHOAI WHERE idDT = " + idDT + ") - 1000000) ";
            sql += "AND Gia <= ((SELECT Gia FROM DIENTHOAI WHERE idDT = " + idDT + ") + 1000000)";

            //Response.Write(sql);
            ds = dtdg.SelectQuery(sql);

            DienThoaiDongGia.DataSource = ds;
            DienThoaiDongGia.DataBind();
        }

        public void ShowTinhNangDienThoai()
        {
            string idDT = Request.QueryString["idDT"].ToString();

            WSSDT.WSSDT dtct = new WSSDT.WSSDT();
            DataSet ds = new DataSet();

            string sql = "";
            sql = "SELECT * ";
            sql += "FROM TINHNANGDIENTHOAI ";
            sql += "WHERE idDT = " + idDT;

            //Response.Write(sql);
            ds = dtct.SelectQuery(sql);

            TinhNangDienThoai.DataSource = ds;
            TinhNangDienThoai.DataBind();
        }

       
    }
}