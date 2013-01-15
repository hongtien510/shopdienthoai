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
    public partial class indexForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ShowDienThoaiMoi();
                ShowDienThoaiSieuCap();
                ShowDienThoaiCaoCap();
                ShowDienThoaiTrungCap();
                ShowDienThoaiThongDung();
            }
        }

        public void ShowDienThoaiMoi()
        {
            WSSDT.WSSDT dtm = new WSSDT.WSSDT();
            DataSet ds = new DataSet();
            ds = dtm.SelectQuery("SELECT TOP 8 idDT, TenDT, TenHSX, Gia, HinhAnh FROM DIENTHOAI dt, HANGSANXUAT hsx WHERE dt.idHSX = hsx.idHSX AND dt.AnHien = 1");

            DienThoaiMoiXuatHien.DataSource = ds;
            DienThoaiMoiXuatHien.DataBind();
            
        }

        public void ShowDienThoaiSieuCap()
        {
            WSSDT.WSSDT dtsc = new WSSDT.WSSDT();
            DataSet ds = new DataSet();
            ds = dtsc.SelectQuery("SELECT TOP 8 idDT, TenDT, TenHSX, Gia, HinhAnh FROM DIENTHOAI dt, HANGSANXUAT hsx WHERE dt.idHSX = hsx.idHSX AND dt.AnHien = 1 AND Gia >= 10000000");

            DienThoaiSieuCap.DataSource = ds;
            DienThoaiSieuCap.DataBind();

        }

        public void ShowDienThoaiCaoCap()
        {
            WSSDT.WSSDT dtsc = new WSSDT.WSSDT();
            DataSet ds = new DataSet();
            ds = dtsc.SelectQuery("SELECT TOP 8 idDT, TenDT, TenHSX, Gia, HinhAnh FROM DIENTHOAI dt, HANGSANXUAT hsx WHERE dt.idHSX = hsx.idHSX AND dt.AnHien = 1 AND Gia < 10000000 AND Gia >= 7000000");

            DienThoaiCaoCap.DataSource = ds;
            DienThoaiCaoCap.DataBind();

        }

        public void ShowDienThoaiTrungCap()
        {
            WSSDT.WSSDT dtsc = new WSSDT.WSSDT();
            DataSet ds = new DataSet();
            ds = dtsc.SelectQuery("SELECT TOP 8 idDT, TenDT, TenHSX, Gia, HinhAnh FROM DIENTHOAI dt, HANGSANXUAT hsx WHERE dt.idHSX = hsx.idHSX AND dt.AnHien = 1 AND Gia < 7000000 AND Gia >= 4000000");

            DienThoaiTrungCap.DataSource = ds;
            DienThoaiTrungCap.DataBind();

        }

        public void ShowDienThoaiThongDung()
        {
            WSSDT.WSSDT dtsc = new WSSDT.WSSDT();
            DataSet ds = new DataSet();
            ds = dtsc.SelectQuery("SELECT TOP 8 idDT, TenDT, TenHSX, Gia, HinhAnh FROM DIENTHOAI dt, HANGSANXUAT hsx WHERE dt.idHSX = hsx.idHSX AND dt.AnHien = 1 AND Gia < 4000000");

            DienThoaiThongDung.DataSource = ds;
            DienThoaiThongDung.DataBind();

        }
    }
}