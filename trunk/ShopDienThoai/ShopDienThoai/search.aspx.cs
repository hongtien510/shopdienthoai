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
    public partial class search : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ShowTimKiemDienThoai();
            }
        }

        public void ShowTimKiemDienThoai()
        {
            string idhsx = Request.QueryString["idhsx"].ToString();
            string keyword = Request.QueryString["keyword"].ToString();
            string price1 = Request.QueryString["price1"].ToString();
            string price2 = Request.QueryString["price2"].ToString();
            string sql = "";
            if (idhsx == "0")
            {
                if (keyword != "" && price1 == "-1" && price2 == "-1")
                {
                    sql = "SELECT idDT, TenDT, TenHSX, HinhAnh, Gia, MoTa ";
                    sql += "FROM DIENTHOAI DT, HANGSANXUAT HSX ";
                    sql += "WHERE DT.idHSX = HSX.idHSX AND TenDT LIKE '%" + keyword + "%' ";
                    sql += "ORDER BY Gia";
                }
                if (keyword != "" && price1 != "-1" && price2 != "-1")
                {
                    sql = "SELECT idDT, TenDT, TenHSX, HinhAnh, Gia, MoTa ";
                    sql += "FROM DIENTHOAI DT, HANGSANXUAT HSX ";
                    sql += "WHERE DT.idHSX = HSX.idHSX AND TenDT LIKE '%" + keyword + "%' ";
                    sql += "AND Gia >= '" + price1 + "' AND Gia <= '" + price2 + "' ";
                    sql += "ORDER BY Gia";
                }
                if (keyword != "" && price1 != "-1" && price2 == "-1")
                {
                    sql = "SELECT idDT, TenDT, TenHSX, HinhAnh, Gia, MoTa ";
                    sql += "FROM DIENTHOAI DT, HANGSANXUAT HSX ";
                    sql += "WHERE DT.idHSX = HSX.idHSX ";
                    sql += "AND TenDT LIKE '%" + keyword + "%' ";
                    sql += "AND Gia >= '" + price1 + "' ";
                    sql += "ORDER BY Gia";
                }
                if (keyword != "" && price1 == "-1" && price2 != "-1")
                {
                    sql = "SELECT idDT, TenDT, TenHSX, HinhAnh, Gia, MoTa ";
                    sql += "FROM DIENTHOAI DT, HANGSANXUAT HSX ";
                    sql += "WHERE DT.idHSX = HSX.idHSX ";
                    sql += "AND TenDT LIKE '%" + keyword + "%' ";
                    sql += "AND Gia <= '" + price2 + "' ";
                    sql += "ORDER BY Gia";
                }
                if (keyword == "" && price1 != "-1" && price2 != "-1")
                {
                    sql = "SELECT idDT, TenDT, TenHSX, HinhAnh, Gia, MoTa ";
                    sql += "FROM DIENTHOAI DT, HANGSANXUAT HSX ";
                    sql += "WHERE DT.idHSX = HSX.idHSX ";
                    sql += "AND Gia >= '" + price1 + "' AND Gia <= '" + price2 + "' ";
                    sql += "ORDER BY Gia";
                }
                if (keyword == "" && price1 != "-1" && price2 == "-1")
                {
                    sql = "SELECT idDT, TenDT, TenHSX, HinhAnh, Gia, MoTa ";
                    sql += "FROM DIENTHOAI DT, HANGSANXUAT HSX ";
                    sql += "WHERE DT.idHSX = HSX.idHSX ";
                    sql += "AND Gia >= '" + price1 + "' ";
                    sql += "ORDER BY Gia";
                }
                if (keyword == "" && price1 == "-1" && price2 != "-1")
                {
                    sql = "SELECT idDT, TenDT, TenHSX, HinhAnh, Gia, MoTa ";
                    sql += "FROM DIENTHOAI DT, HANGSANXUAT HSX ";
                    sql += "WHERE DT.idHSX = HSX.idHSX ";
                    sql += "AND Gia <= '" + price2 + "' ";
                    sql += "ORDER BY Gia";
                }
            }
            else
            {
                if (keyword != "" && price1 == "-1" && price2 == "-1")
                {
                    sql = "SELECT idDT, TenDT, TenHSX, HinhAnh, Gia, MoTa ";
                    sql += "FROM DIENTHOAI DT, HANGSANXUAT HSX ";
                    sql += "WHERE DT.idHSX = HSX.idHSX AND TenDT LIKE '%" + keyword + "%' ";
                    sql += "AND DT.idHSX = '" + idhsx + "' ";
                    sql += "ORDER BY Gia";
                }
                if (keyword != "" && price1 != "-1" && price2 != "-1")
                {
                    sql = "SELECT idDT, TenDT, TenHSX, HinhAnh, Gia, MoTa ";
                    sql += "FROM DIENTHOAI DT, HANGSANXUAT HSX ";
                    sql += "WHERE DT.idHSX = HSX.idHSX AND TenDT LIKE '%" + keyword + "%' ";
                    sql += "AND Gia >= '" + price1 + "' AND Gia <= '" + price2 + "' ";
                    sql += "AND DT.idHSX = '" + idhsx + "' ";
                    sql += "ORDER BY Gia";
                }
                if (keyword != "" && price1 != "-1" && price2 == "-1")
                {
                    sql = "SELECT idDT, TenDT, TenHSX, HinhAnh, Gia, MoTa ";
                    sql += "FROM DIENTHOAI DT, HANGSANXUAT HSX ";
                    sql += "WHERE DT.idHSX = HSX.idHSX ";
                    sql += "AND TenDT LIKE '%" + keyword + "%' ";
                    sql += "AND Gia >= '" + price1 + "' ";
                    sql += "AND DT.idHSX = '" + idhsx + "' ";
                    sql += "ORDER BY Gia";
                }
                if (keyword != "" && price1 == "-1" && price2 != "-1")
                {
                    sql = "SELECT idDT, TenDT, TenHSX, HinhAnh, Gia, MoTa ";
                    sql += "FROM DIENTHOAI DT, HANGSANXUAT HSX ";
                    sql += "WHERE DT.idHSX = HSX.idHSX ";
                    sql += "AND TenDT LIKE '%" + keyword + "%' ";
                    sql += "AND Gia <= '" + price2 + "' ";
                    sql += "AND DT.idHSX = '" + idhsx + "' ";
                    sql += "ORDER BY Gia";
                }
                if (keyword == "" && price1 != "-1" && price2 != "-1")
                {
                    sql = "SELECT idDT, TenDT, TenHSX, HinhAnh, Gia, MoTa ";
                    sql += "FROM DIENTHOAI DT, HANGSANXUAT HSX ";
                    sql += "WHERE DT.idHSX = HSX.idHSX ";
                    sql += "AND Gia >= '" + price1 + "' AND Gia <= '" + price2 + "' ";
                    sql += "AND DT.idHSX = '" + idhsx + "' ";
                    sql += "ORDER BY Gia";
                }
                if (keyword == "" && price1 != "-1" && price2 == "-1")
                {
                    sql = "SELECT idDT, TenDT, TenHSX, HinhAnh, Gia, MoTa ";
                    sql += "FROM DIENTHOAI DT, HANGSANXUAT HSX ";
                    sql += "WHERE DT.idHSX = HSX.idHSX ";
                    sql += "AND Gia >= '" + price1 + "' ";
                    sql += "AND DT.idHSX = '" + idhsx + "' ";
                    sql += "ORDER BY Gia";
                }
                if (keyword == "" && price1 == "-1" && price2 != "-1")
                {
                    sql = "SELECT idDT, TenDT, TenHSX, HinhAnh, Gia, MoTa ";
                    sql += "FROM DIENTHOAI DT, HANGSANXUAT HSX ";
                    sql += "WHERE DT.idHSX = HSX.idHSX ";
                    sql += "AND Gia <= '" + price2 + "' ";
                    sql += "AND DT.idHSX = '" + idhsx + "' ";
                    sql += "ORDER BY Gia";
                }
                if (keyword == "" && price1 == "-1" && price2 == "-1")
                {
                    sql = "SELECT idDT, TenDT, TenHSX, HinhAnh, Gia, MoTa ";
                    sql += "FROM DIENTHOAI DT, HANGSANXUAT HSX ";
                    sql += "WHERE DT.idHSX = HSX.idHSX ";
                    sql += "AND DT.idHSX = '" + idhsx + "' ";
                    sql += "ORDER BY Gia";
                }
            }

            WSSDT.WSSDT search = new WSSDT.WSSDT();
            DataSet ds = new DataSet();

            
            //Response.Write(sql);

            ds = search.SelectQuery(sql);

            TimKiemDienThoai.DataSource = ds;
            TimKiemDienThoai.DataBind();
        }
    }
}