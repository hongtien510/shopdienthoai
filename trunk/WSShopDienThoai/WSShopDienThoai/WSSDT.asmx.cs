using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data;
using System.Data.SqlClient;
using System.Web.Configuration;


namespace WSShopDienThoai
{
    /// <summary>
    /// Summary description for WSSDT
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WSSDT : System.Web.Services.WebService
    {
        static string strcon = WebConfigurationManager.ConnectionStrings["connection"].ConnectionString;
        //Insert
        [WebMethod]
        public int InsertDeleteQuery(string sql)
        {
            //INSERT INTO HangSanXuat (TenHSX, ThuTu, AnHien) VALUES ('Pham Hong Tien', '10', '1')
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                SqlDataAdapter da = new SqlDataAdapter(sql, con);
                DataSet ds = new DataSet();
                da.Fill(ds);
                return 1;
            }
            catch
            {
                return 0;
            }
        }

        //Select
        [WebMethod]
        public DataSet SelectQuery(string sql)
        {
            SqlConnection con = new SqlConnection(strcon);
            //string sql = "SELECT * FROM HANGSANXUAT";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }
    }
}
