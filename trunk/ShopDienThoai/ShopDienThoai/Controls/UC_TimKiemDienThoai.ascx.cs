using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace ShopDienThoai.Controls
{
    public partial class UC_TimKiemDienThoai : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                showHSX();
            }
        }

        public void showHSX()
        {
            WSSDT.WSSDT hsx = new WSSDT.WSSDT();
            DataSet ds = new DataSet();
            ds = hsx.SelectQuery("SELECT idHSX, TenHSX FROM HANGSANXUAT WHERE ANHIEN=1");

            DataTable dt = new DataTable();
            dt = ds.Tables[0];

            ListItem item;

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                item = new ListItem();
                item.Value = dt.Rows[i]["idHSX"].ToString();
                item.Text = dt.Rows[i]["TenHSX"].ToString();
                ddl_hsx.Items.Add(item);
            }
           


        }
        protected void ddl_hsx_SelectedIndexChanged(object sender, EventArgs e)
        {
            WSSDT.WSSDT dthoai = new WSSDT.WSSDT();
            DataSet ds = new DataSet();
            string idHSX = ddl_hsx.SelectedValue.ToString();
            string sql = "SELECT idDT, TenDT FROM DIENTHOAI WHERE ANHIEN=1 AND idHSX="+idHSX;
            //string sql = "SELECT idDT, TenDT FROM DIENTHOAI";
            ds = dthoai.SelectQuery(sql);

            DataTable dt = new DataTable();
            dt = ds.Tables[0];

            ListItem item;
            ddl_dt.Items.Clear();
            item = new ListItem();
            item.Value="0";
            item.Value="-----Chọn Model-----";
            ddl_dt.Items.Add(item);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                item = new ListItem();
                item.Value = dt.Rows[i]["idDT"].ToString();
                item.Text = dt.Rows[i]["TenDT"].ToString();
                ddl_dt.Items.Add(item);
            }

        }

        protected void ddl_dt_SelectedIndexChanged(object sender, EventArgs e)
        {
            string idDT = ddl_dt.SelectedValue.ToString();
            string url = "dienthoaichitiet.aspx?idDT=" + idDT;
            Response.Redirect(url);
        }

        protected void bt_TimKiem_Click(object sender, EventArgs e)
        {
            string key = keyword.Value.ToString();
            string price1 = ddl_GiaTu.SelectedValue.ToString();
            string price2 = ddl_GiaDen.SelectedValue.ToString();
            string idhsx = ddl_hsx.SelectedValue.ToString();
            string url = "search.aspx?keyword=" + key + "&idhsx=" + idhsx + "&price1=" + price1 + "&price2=" + price2;
            Response.Redirect(url);
        }
    }
}