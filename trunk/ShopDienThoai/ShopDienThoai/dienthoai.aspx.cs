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
    public partial class dienthoaiForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                ShowDienThoaiTheoHSX();
                ShowTitleTenHSX();
            }
        }

        public void ShowDienThoaiTheoHSX()
        {
            string idHSX = Request.QueryString["idHSX"].ToString() ;
            if (idHSX == "")
            {
                idHSX = "4";
            }

            
            WSSDT.WSSDT dthsx = new WSSDT.WSSDT();
            DataSet ds = new DataSet();

            string sql = "SELECT TOP 10 idDT, TenDT, TenHSX, Gia, HinhAnh, MoTa FROM DIENTHOAI DT, HANGSANXUAT HSX WHERE DT.idHSX = HSX.idHSX AND DT.idHSX = " + idHSX + " AND DT.AnHien = 1";
            ds = dthsx.SelectQuery(sql);

            DienThoaiTheoHSX.DataSource = ds;
            DienThoaiTheoHSX.DataBind();


        }

        public void ShowTitleTenHSX()
        {
            string idHSX = Request.QueryString["idHSX"].ToString();

            WSSDT.WSSDT dthsx = new WSSDT.WSSDT();
            DataSet ds = new DataSet();

            string sql = "SELECT TenHSX FROM HANGSANXUAT WHERE idHSX = " + idHSX ;
            ds = dthsx.SelectQuery(sql);

            TitleTenHSX.DataSource = ds;
            TitleTenHSX.DataBind();   
        }
    }
}