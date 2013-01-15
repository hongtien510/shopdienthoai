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
    public partial class UC_SoSanhDienThoai : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ShowHSXSoSanh();
            }
        }

        public void ShowHSXSoSanh()
        {
            WSSDT.WSSDT hsxss = new WSSDT.WSSDT();

            DataSet ds = new DataSet();
            ds = hsxss.SelectQuery("SELECT idHSX, TenHSX FROM HANGSANXUAT WHERE ANHIEN=1");

            DataTable dt = new DataTable();
            dt = ds.Tables[0];

            ListItem item;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                item = new ListItem();
                item.Value = dt.Rows[i]["idHSX"].ToString();
                item.Text = dt.Rows[i]["TenHSX"].ToString();
                ddl_hsxss.Items.Add(item);
            }
        }

        protected void ddl_hsxss_SelectedIndexChanged(object sender, EventArgs e)
        {
            WSSDT.WSSDT dthoai = new WSSDT.WSSDT();
            DataSet ds = new DataSet();
            string idHSX = ddl_hsxss.SelectedValue.ToString();
            string sql = "SELECT idDT, TenDT FROM DIENTHOAI WHERE ANHIEN=1 AND idHSX=" + idHSX;
            //string sql = "SELECT idDT, TenDT FROM DIENTHOAI";
            ds = dthoai.SelectQuery(sql);

            DataTable dt = new DataTable();
            dt = ds.Tables[0];

            ListItem item;
            ddl_dtss.Items.Clear();
            item = new ListItem();
            item.Value = "0";
            item.Text = "-----Chọn Model-----";
            ddl_dtss.Items.Add(item);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                item = new ListItem();
                item.Value = dt.Rows[i]["idDT"].ToString();
                item.Text = dt.Rows[i]["TenDT"].ToString();
                ddl_dtss.Items.Add(item);
            }
        }

        protected void bt_sosanh_Click(object sender, EventArgs e)
        {
            string idDT = ddl_dtss.SelectedValue.ToString();
            Response.Write(idDT);
            Session["idDTSS"] = idDT;
            Response.Redirect("sosanhdienthoai.aspx");
        }
    }
}