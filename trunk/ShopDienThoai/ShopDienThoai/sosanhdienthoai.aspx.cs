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
    public partial class sosanhdienthoaiForm: System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ShowHSX();
                if (Session["idDTSS"] != null)
                {
                    string idDTSS = Session["idDTSS"].ToString();
                    //Response.Write(idDTSS);
                    ShowSoSanhDienThoai1(idDTSS);
                    Session["idDTSS"] = 0;
                }
            }
        }

        

        public void ShowHSX()
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
                ddl_hsx1.Items.Add(item);
                ddl_hsx2.Items.Add(item);
                ddl_hsx3.Items.Add(item);
            }
        }

        protected void ddl_hsx1_SelectedIndexChanged(object sender, EventArgs e)
        {
            WSSDT.WSSDT dthoai = new WSSDT.WSSDT();
            DataSet ds = new DataSet();
            string idHSX = ddl_hsx1.SelectedValue.ToString();
            string sql = "SELECT idDT, TenDT FROM DIENTHOAI WHERE ANHIEN=1 AND idHSX=" + idHSX;
            //string sql = "SELECT idDT, TenDT FROM DIENTHOAI";
            ds = dthoai.SelectQuery(sql);

            DataTable dt = new DataTable();
            dt = ds.Tables[0];

            ListItem item;
            ddl_dt1.Items.Clear();
            item = new ListItem();
            item.Value = "0";
            item.Value = "-----Chọn Model-----";
            ddl_dt1.Items.Add(item);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                item = new ListItem();
                item.Value = dt.Rows[i]["idDT"].ToString();
                item.Text = dt.Rows[i]["TenDT"].ToString();
                ddl_dt1.Items.Add(item);
            }
        }

        protected void ddl_hsx2_SelectedIndexChanged(object sender, EventArgs e)
        {
            WSSDT.WSSDT dthoai = new WSSDT.WSSDT();
            DataSet ds = new DataSet();
            string idHSX = ddl_hsx2.SelectedValue.ToString();
            string sql = "SELECT idDT, TenDT FROM DIENTHOAI WHERE ANHIEN=1 AND idHSX=" + idHSX;
            //string sql = "SELECT idDT, TenDT FROM DIENTHOAI";
            ds = dthoai.SelectQuery(sql);

            DataTable dt = new DataTable();
            dt = ds.Tables[0];

            ListItem item;
            ddl_dt2.Items.Clear();
            item = new ListItem();
            item.Value = "0";
            item.Value = "-----Chọn Model-----";
            ddl_dt2.Items.Add(item);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                item = new ListItem();
                item.Value = dt.Rows[i]["idDT"].ToString();
                item.Text = dt.Rows[i]["TenDT"].ToString();
                ddl_dt2.Items.Add(item);
            }
        }

        protected void ddl_hsx3_SelectedIndexChanged(object sender, EventArgs e)
        {
            WSSDT.WSSDT dthoai = new WSSDT.WSSDT();
            DataSet ds = new DataSet();
            string idHSX = ddl_hsx3.SelectedValue.ToString();
            string sql = "SELECT idDT, TenDT FROM DIENTHOAI WHERE ANHIEN=1 AND idHSX=" + idHSX;
            //string sql = "SELECT idDT, TenDT FROM DIENTHOAI";
            ds = dthoai.SelectQuery(sql);

            DataTable dt = new DataTable();
            dt = ds.Tables[0];

            ListItem item;
            ddl_dt3.Items.Clear();
            item = new ListItem();
            item.Value = "0";
            item.Value = "-----Chọn Model-----";
            ddl_dt3.Items.Add(item);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                item = new ListItem();
                item.Value = dt.Rows[i]["idDT"].ToString();
                item.Text = dt.Rows[i]["TenDT"].ToString();
                ddl_dt3.Items.Add(item);
            }
        }


        public void ShowSoSanhDienThoai1(string idDT1)
        {
            if (idDT1 == "0")
            {
                return;
            }

            WSSDT.WSSDT ssdt = new WSSDT.WSSDT();
            DataSet ds = new DataSet();

            string sql = "";
            sql = "SELECT DT.idDT, TenHSX, TenDT, Gia, HinhAnh, Mang2G, Mang3G, Sim, KichThuoc, TrongLuong, ";
            sql += "MauSac, LoaimanHinh, KichThuocManHinh, Audio, Video, Radio, KieuChuong, ";
            sql += "LoaNgoai, BoNhoTrong, TheNho, Wlan, GPRS, HSPDA, Bluetooth, USB, GPS, Jack35, ";
            sql += "CameraChinh, ChucNang, CameraPhu, QuayPhim, TinNhan, TrinhDuyet, HeDieuHanh, ";
            sql += "CPU, Chipset, GPU, JAVA, TroChoi, LoaiPin, ThoiGianCho, ThoiGianHoatDong, Khac ";
            sql += "FROM DIENTHOAI dt, HANGSANXUAT hsx, TINHNANGDIENTHOAI tndt ";
            sql += "WHERE dt.idHSX = hsx.idHSX AND dt.idDT = tndt.idDT AND DT.idDT = " + idDT1;

            //Response.Write(sql);
            ds = ssdt.SelectQuery(sql);

            DataTable dt = new DataTable();
            dt = ds.Tables[0];

            ltr_TenDT1.Text = dt.Rows[0]["TenDT"].ToString();
            img_HinhAnh1.ImageUrl = "images/" + dt.Rows[0]["TenHSX"] + "/" + dt.Rows[0]["HinhAnh"];
            ltr_Gia1.Text = dt.Rows[0]["Gia"].ToString() + "VNĐ";
            ltr_Mang2G1.Text = dt.Rows[0]["Mang2G"].ToString();
            ltr_Mang3G1.Text = dt.Rows[0]["Mang3G"].ToString();
            ltr_Sim1.Text = dt.Rows[0]["Sim"].ToString();
            ltr_KichThuoc1.Text = dt.Rows[0]["KichThuoc"].ToString();
            ltr_TrongLuong1.Text = dt.Rows[0]["TrongLuong"].ToString();
            ltr_MauSac1.Text = dt.Rows[0]["MauSac"].ToString();
            ltr_LoaiManHinh1.Text = dt.Rows[0]["LoaiManHinh"].ToString();
            ltr_KichThuocManHinh1.Text = dt.Rows[0]["KichThuocManHinh"].ToString();
            ltr_Audio1.Text = dt.Rows[0]["Audio"].ToString();
            ltr_Video1.Text = dt.Rows[0]["Video"].ToString();
            ltr_Radio1.Text = dt.Rows[0]["Radio"].ToString();
            ltr_KieuChuong1.Text = dt.Rows[0]["KieuChuong"].ToString();
            ltr_LoaNgoai1.Text = dt.Rows[0]["LoaNgoai"].ToString();
            ltr_BoNhoTrong1.Text = dt.Rows[0]["BoNhoTrong"].ToString();
            ltr_TheNho1.Text = dt.Rows[0]["TheNho"].ToString();
            ltr_Wlan1.Text = dt.Rows[0]["Wlan"].ToString();
            ltr_GPRS1.Text = dt.Rows[0]["GPRS"].ToString();
            ltr_HSPDA1.Text = dt.Rows[0]["HSPDA"].ToString();
            ltr_Bluetooth1.Text = dt.Rows[0]["Bluetooth"].ToString();
            ltr_USB1.Text = dt.Rows[0]["USB"].ToString();
            ltr_GPS1.Text = dt.Rows[0]["GPS"].ToString();
            ltr_Jack351.Text = dt.Rows[0]["Jack35"].ToString();
            ltr_CameraChinh1.Text = dt.Rows[0]["CameraChinh"].ToString();
            ltr_ChucNang1.Text = dt.Rows[0]["ChucNang"].ToString();
            ltr_CameraPhu1.Text = dt.Rows[0]["CameraPhu"].ToString();
            ltr_QuayPhim1.Text = dt.Rows[0]["QuayPhim"].ToString();
            ltr_TinNhan1.Text = dt.Rows[0]["TinNhan"].ToString();
            ltr_TrinhDuyet1.Text = dt.Rows[0]["TrinhDuyet"].ToString();
            ltr_HeDieuHanh1.Text = dt.Rows[0]["HeDieuHanh"].ToString();
            ltr_CPU1.Text = dt.Rows[0]["CPU"].ToString();
            ltr_Chipset1.Text = dt.Rows[0]["Chipset"].ToString();
            ltr_GPU1.Text = dt.Rows[0]["GPU"].ToString();
            ltr_JAVA1.Text = dt.Rows[0]["JAVA"].ToString();
            ltr_TroChoi1.Text = dt.Rows[0]["TroChoi"].ToString();
            ltr_LoaiPin1.Text = dt.Rows[0]["LoaiPin"].ToString();
            ltr_ThoiGianCho1.Text = dt.Rows[0]["ThoiGianCho"].ToString();
            ltr_ThoiGianHoatDong1.Text = dt.Rows[0]["ThoiGianHoatDong"].ToString();
            ltr_Khac1.Text = dt.Rows[0]["Khac"].ToString();

        }

        public void ShowSoSanhDienThoai1()
        {
            string idDT1 = ddl_dt1.SelectedValue.ToString();

            WSSDT.WSSDT ssdt = new WSSDT.WSSDT();
            DataSet ds = new DataSet();

            string sql = "";
            sql = "SELECT DT.idDT, TenHSX, TenDT, Gia, HinhAnh, Mang2G, Mang3G, Sim, KichThuoc, TrongLuong, ";
            sql += "MauSac, LoaimanHinh, KichThuocManHinh, Audio, Video, Radio, KieuChuong, ";
            sql += "LoaNgoai, BoNhoTrong, TheNho, Wlan, GPRS, HSPDA, Bluetooth, USB, GPS, Jack35, ";
            sql += "CameraChinh, ChucNang, CameraPhu, QuayPhim, TinNhan, TrinhDuyet, HeDieuHanh, ";
            sql += "CPU, Chipset, GPU, JAVA, TroChoi, LoaiPin, ThoiGianCho, ThoiGianHoatDong, Khac ";
            sql += "FROM DIENTHOAI dt, HANGSANXUAT hsx, TINHNANGDIENTHOAI tndt ";
            sql += "WHERE dt.idHSX = hsx.idHSX AND dt.idDT = tndt.idDT AND DT.idDT = " + idDT1;

            //Response.Write(sql);
            ds = ssdt.SelectQuery(sql);

            DataTable dt = new DataTable();
            dt = ds.Tables[0];

            ltr_TenDT1.Text = dt.Rows[0]["TenDT"].ToString();
            img_HinhAnh1.ImageUrl = "images/" + dt.Rows[0]["TenHSX"] + "/" + dt.Rows[0]["HinhAnh"];
            ltr_Gia1.Text = dt.Rows[0]["Gia"].ToString() + "VNĐ";
            ltr_Mang2G1.Text = dt.Rows[0]["Mang2G"].ToString();
            ltr_Mang3G1.Text = dt.Rows[0]["Mang3G"].ToString();
            ltr_Sim1.Text = dt.Rows[0]["Sim"].ToString();
            ltr_KichThuoc1.Text = dt.Rows[0]["KichThuoc"].ToString();
            ltr_TrongLuong1.Text = dt.Rows[0]["TrongLuong"].ToString();
            ltr_MauSac1.Text = dt.Rows[0]["MauSac"].ToString();
            ltr_LoaiManHinh1.Text = dt.Rows[0]["LoaiManHinh"].ToString();
            ltr_KichThuocManHinh1.Text = dt.Rows[0]["KichThuocManHinh"].ToString();
            ltr_Audio1.Text = dt.Rows[0]["Audio"].ToString();
            ltr_Video1.Text = dt.Rows[0]["Video"].ToString();
            ltr_Radio1.Text = dt.Rows[0]["Radio"].ToString();
            ltr_KieuChuong1.Text = dt.Rows[0]["KieuChuong"].ToString();
            ltr_LoaNgoai1.Text = dt.Rows[0]["LoaNgoai"].ToString();
            ltr_BoNhoTrong1.Text = dt.Rows[0]["BoNhoTrong"].ToString();
            ltr_TheNho1.Text = dt.Rows[0]["TheNho"].ToString();
            ltr_Wlan1.Text = dt.Rows[0]["Wlan"].ToString();
            ltr_GPRS1.Text = dt.Rows[0]["GPRS"].ToString();
            ltr_HSPDA1.Text = dt.Rows[0]["HSPDA"].ToString();
            ltr_Bluetooth1.Text = dt.Rows[0]["Bluetooth"].ToString();
            ltr_USB1.Text = dt.Rows[0]["USB"].ToString();
            ltr_GPS1.Text = dt.Rows[0]["GPS"].ToString();
            ltr_Jack351.Text = dt.Rows[0]["Jack35"].ToString();
            ltr_CameraChinh1.Text = dt.Rows[0]["CameraChinh"].ToString();
            ltr_ChucNang1.Text = dt.Rows[0]["ChucNang"].ToString();
            ltr_CameraPhu1.Text = dt.Rows[0]["CameraPhu"].ToString();
            ltr_QuayPhim1.Text = dt.Rows[0]["QuayPhim"].ToString();
            ltr_TinNhan1.Text = dt.Rows[0]["TinNhan"].ToString();
            ltr_TrinhDuyet1.Text = dt.Rows[0]["TrinhDuyet"].ToString();
            ltr_HeDieuHanh1.Text = dt.Rows[0]["HeDieuHanh"].ToString();
            ltr_CPU1.Text = dt.Rows[0]["CPU"].ToString();
            ltr_Chipset1.Text = dt.Rows[0]["Chipset"].ToString();
            ltr_GPU1.Text = dt.Rows[0]["GPU"].ToString();
            ltr_JAVA1.Text = dt.Rows[0]["JAVA"].ToString();
            ltr_TroChoi1.Text = dt.Rows[0]["TroChoi"].ToString();
            ltr_LoaiPin1.Text = dt.Rows[0]["LoaiPin"].ToString();
            ltr_ThoiGianCho1.Text = dt.Rows[0]["ThoiGianCho"].ToString();
            ltr_ThoiGianHoatDong1.Text = dt.Rows[0]["ThoiGianHoatDong"].ToString();
            ltr_Khac1.Text = dt.Rows[0]["Khac"].ToString();

        }

        public void ShowSoSanhDienThoai2()
        {
            string idDT2 = ddl_dt2.SelectedValue.ToString();

            WSSDT.WSSDT ssdt = new WSSDT.WSSDT();
            DataSet ds = new DataSet();

            string sql = "";
            sql = "SELECT DT.idDT, TenHSX, TenDT, Gia, HinhAnh, Mang2G, Mang3G, Sim, KichThuoc, TrongLuong, ";
            sql += "MauSac, LoaimanHinh, KichThuocManHinh, Audio, Video, Radio, KieuChuong, ";
            sql += "LoaNgoai, BoNhoTrong, TheNho, Wlan, GPRS, HSPDA, Bluetooth, USB, GPS, Jack35, ";
            sql += "CameraChinh, ChucNang, CameraPhu, QuayPhim, TinNhan, TrinhDuyet, HeDieuHanh, ";
            sql += "CPU, Chipset, GPU, JAVA, TroChoi, LoaiPin, ThoiGianCho, ThoiGianHoatDong, Khac ";
            sql += "FROM DIENTHOAI dt, HANGSANXUAT hsx, TINHNANGDIENTHOAI tndt ";
            sql += "WHERE dt.idHSX = hsx.idHSX AND dt.idDT = tndt.idDT AND DT.idDT = " + idDT2;

            //Response.Write(sql);
            ds = ssdt.SelectQuery(sql);

            DataTable dt = new DataTable();
            dt = ds.Tables[0];

            ltr_TenDT2.Text = dt.Rows[0]["TenDT"].ToString();
            img_HinhAnh2.ImageUrl = "images/" + dt.Rows[0]["TenHSX"] + "/" + dt.Rows[0]["HinhAnh"];
            ltr_Gia2.Text = dt.Rows[0]["Gia"].ToString() + "VNĐ";
            ltr_Mang2G2.Text = dt.Rows[0]["Mang2G"].ToString();
            ltr_Mang3G2.Text = dt.Rows[0]["Mang3G"].ToString();
            ltr_Sim2.Text = dt.Rows[0]["Sim"].ToString();
            ltr_KichThuoc2.Text = dt.Rows[0]["KichThuoc"].ToString();
            ltr_TrongLuong2.Text = dt.Rows[0]["TrongLuong"].ToString();
            ltr_MauSac2.Text = dt.Rows[0]["MauSac"].ToString();
            ltr_LoaiManHinh2.Text = dt.Rows[0]["LoaiManHinh"].ToString();
            ltr_KichThuocManHinh2.Text = dt.Rows[0]["KichThuocManHinh"].ToString();
            ltr_Audio2.Text = dt.Rows[0]["Audio"].ToString();
            ltr_Video2.Text = dt.Rows[0]["Video"].ToString();
            ltr_Radio2.Text = dt.Rows[0]["Radio"].ToString();
            ltr_KieuChuong2.Text = dt.Rows[0]["KieuChuong"].ToString();
            ltr_LoaNgoai2.Text = dt.Rows[0]["LoaNgoai"].ToString();
            ltr_BoNhoTrong2.Text = dt.Rows[0]["BoNhoTrong"].ToString();
            ltr_TheNho2.Text = dt.Rows[0]["TheNho"].ToString();
            ltr_Wlan2.Text = dt.Rows[0]["Wlan"].ToString();
            ltr_GPRS2.Text = dt.Rows[0]["GPRS"].ToString();
            ltr_HSPDA2.Text = dt.Rows[0]["HSPDA"].ToString();
            ltr_Bluetooth2.Text = dt.Rows[0]["Bluetooth"].ToString();
            ltr_USB2.Text = dt.Rows[0]["USB"].ToString();
            ltr_GPS2.Text = dt.Rows[0]["GPS"].ToString();
            ltr_Jack352.Text = dt.Rows[0]["Jack35"].ToString();
            ltr_CameraChinh2.Text = dt.Rows[0]["CameraChinh"].ToString();
            ltr_ChucNang2.Text = dt.Rows[0]["ChucNang"].ToString();
            ltr_CameraPhu2.Text = dt.Rows[0]["CameraPhu"].ToString();
            ltr_QuayPhim2.Text = dt.Rows[0]["QuayPhim"].ToString();
            ltr_TinNhan2.Text = dt.Rows[0]["TinNhan"].ToString();
            ltr_TrinhDuyet2.Text = dt.Rows[0]["TrinhDuyet"].ToString();
            ltr_HeDieuHanh2.Text = dt.Rows[0]["HeDieuHanh"].ToString();
            ltr_CPU2.Text = dt.Rows[0]["CPU"].ToString();
            ltr_Chipset2.Text = dt.Rows[0]["Chipset"].ToString();
            ltr_GPU2.Text = dt.Rows[0]["GPU"].ToString();
            ltr_JAVA2.Text = dt.Rows[0]["JAVA"].ToString();
            ltr_TroChoi2.Text = dt.Rows[0]["TroChoi"].ToString();
            ltr_LoaiPin2.Text = dt.Rows[0]["LoaiPin"].ToString();
            ltr_ThoiGianCho2.Text = dt.Rows[0]["ThoiGianCho"].ToString();
            ltr_ThoiGianHoatDong2.Text = dt.Rows[0]["ThoiGianHoatDong"].ToString();
            ltr_Khac2.Text = dt.Rows[0]["Khac"].ToString();

        }

        public void ShowSoSanhDienThoai3()
        {
            string idDT3 = ddl_dt3.SelectedValue.ToString();

            WSSDT.WSSDT ssdt = new WSSDT.WSSDT();
            DataSet ds = new DataSet();

            string sql = "";
            sql = "SELECT DT.idDT, TenHSX, TenDT, Gia, HinhAnh, Mang2G, Mang3G, Sim, KichThuoc, TrongLuong, ";
            sql += "MauSac, LoaimanHinh, KichThuocManHinh, Audio, Video, Radio, KieuChuong, ";
            sql += "LoaNgoai, BoNhoTrong, TheNho, Wlan, GPRS, HSPDA, Bluetooth, USB, GPS, Jack35, ";
            sql += "CameraChinh, ChucNang, CameraPhu, QuayPhim, TinNhan, TrinhDuyet, HeDieuHanh, ";
            sql += "CPU, Chipset, GPU, JAVA, TroChoi, LoaiPin, ThoiGianCho, ThoiGianHoatDong, Khac ";
            sql += "FROM DIENTHOAI dt, HANGSANXUAT hsx, TINHNANGDIENTHOAI tndt ";
            sql += "WHERE dt.idHSX = hsx.idHSX AND dt.idDT = tndt.idDT AND DT.idDT = " + idDT3;

            //Response.Write(sql);
            ds = ssdt.SelectQuery(sql);

            DataTable dt = new DataTable();
            dt = ds.Tables[0];

            ltr_TenDT3.Text = dt.Rows[0]["TenDT"].ToString();
            img_HinhAnh3.ImageUrl = "images/" + dt.Rows[0]["TenHSX"] + "/" + dt.Rows[0]["HinhAnh"];
            ltr_Gia3.Text = dt.Rows[0]["Gia"].ToString() + "VNĐ";
            ltr_Mang2G3.Text = dt.Rows[0]["Mang2G"].ToString();
            ltr_Mang3G3.Text = dt.Rows[0]["Mang3G"].ToString();
            ltr_Sim3.Text = dt.Rows[0]["Sim"].ToString();
            ltr_KichThuoc3.Text = dt.Rows[0]["KichThuoc"].ToString();
            ltr_TrongLuong3.Text = dt.Rows[0]["TrongLuong"].ToString();
            ltr_MauSac3.Text = dt.Rows[0]["MauSac"].ToString();
            ltr_LoaiManHinh3.Text = dt.Rows[0]["LoaiManHinh"].ToString();
            ltr_KichThuocManHinh3.Text = dt.Rows[0]["KichThuocManHinh"].ToString();
            ltr_Audio3.Text = dt.Rows[0]["Audio"].ToString();
            ltr_Video3.Text = dt.Rows[0]["Video"].ToString();
            ltr_Radio3.Text = dt.Rows[0]["Radio"].ToString();
            ltr_KieuChuong3.Text = dt.Rows[0]["KieuChuong"].ToString();
            ltr_LoaNgoai3.Text = dt.Rows[0]["LoaNgoai"].ToString();
            ltr_BoNhoTrong3.Text = dt.Rows[0]["BoNhoTrong"].ToString();
            ltr_TheNho3.Text = dt.Rows[0]["TheNho"].ToString();
            ltr_Wlan3.Text = dt.Rows[0]["Wlan"].ToString();
            ltr_GPRS3.Text = dt.Rows[0]["GPRS"].ToString();
            ltr_HSPDA3.Text = dt.Rows[0]["HSPDA"].ToString();
            ltr_Bluetooth3.Text = dt.Rows[0]["Bluetooth"].ToString();
            ltr_USB3.Text = dt.Rows[0]["USB"].ToString();
            ltr_GPS3.Text = dt.Rows[0]["GPS"].ToString();
            ltr_Jack353.Text = dt.Rows[0]["Jack35"].ToString();
            ltr_CameraChinh3.Text = dt.Rows[0]["CameraChinh"].ToString();
            ltr_ChucNang3.Text = dt.Rows[0]["ChucNang"].ToString();
            ltr_CameraPhu3.Text = dt.Rows[0]["CameraPhu"].ToString();
            ltr_QuayPhim3.Text = dt.Rows[0]["QuayPhim"].ToString();
            ltr_TinNhan3.Text = dt.Rows[0]["TinNhan"].ToString();
            ltr_TrinhDuyet3.Text = dt.Rows[0]["TrinhDuyet"].ToString();
            ltr_HeDieuHanh3.Text = dt.Rows[0]["HeDieuHanh"].ToString();
            ltr_CPU3.Text = dt.Rows[0]["CPU"].ToString();
            ltr_Chipset3.Text = dt.Rows[0]["Chipset"].ToString();
            ltr_GPU3.Text = dt.Rows[0]["GPU"].ToString();
            ltr_JAVA3.Text = dt.Rows[0]["JAVA"].ToString();
            ltr_TroChoi3.Text = dt.Rows[0]["TroChoi"].ToString();
            ltr_LoaiPin3.Text = dt.Rows[0]["LoaiPin"].ToString();
            ltr_ThoiGianCho3.Text = dt.Rows[0]["ThoiGianCho"].ToString();
            ltr_ThoiGianHoatDong3.Text = dt.Rows[0]["ThoiGianHoatDong"].ToString();
            ltr_Khac3.Text = dt.Rows[0]["Khac"].ToString();

        }

        protected void ddl_dt1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowSoSanhDienThoai1();
        }

        protected void ddl_dt2_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowSoSanhDienThoai2();
        }

        protected void ddl_dt3_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowSoSanhDienThoai3();
        }


    }
}