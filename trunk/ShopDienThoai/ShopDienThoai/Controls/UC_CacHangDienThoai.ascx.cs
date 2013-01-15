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
    public partial class UC_CacHangDienThoai : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                showCacHangDT();
            }

        }

        public void showCacHangDT()
        {
            WSSDT.WSSDT hangdt = new WSSDT.WSSDT();
            DataSet ds = new DataSet();
            ds = hangdt.SelectQuery("SELECT idHSX, TenHSX FROM HANGSANXUAT WHERE AnHien = 1");

            //DataTable dt = new DataTable();
            //dt = ds.Tables[0];

            CachangDienThoai.DataSource = ds;
            CachangDienThoai.DataBind();
        }
    }
}