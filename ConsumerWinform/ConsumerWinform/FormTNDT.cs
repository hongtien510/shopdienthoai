using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ComsumerWinform
{
    public partial class FormTNDT : Form
    {
        ConsumerWinform.WSSDT.WSSDT dtct;
        DataTable table;
        string sql;
        DataSet dts;
        public FormTNDT()
        {
            InitializeComponent();
        }

        private void FormTNDT_Load(object sender, EventArgs e)
        {
            Frmload();
        }
        public void Frmload()
        {

            dtct = new ConsumerWinform.WSSDT.WSSDT();
            dts = new DataSet();
            table = new DataTable();
            string sql = "";

            sql = "SELECT idDT, TenDT FROM DIENTHOAI";// WHERE idHSX =" +"'"+txtIDHSX+"'";
            dts = dtct.SelectQuery(sql);
            table = dts.Tables[0];
            //ds = dtct.SelectQuery(sql);

            comboBoxDT.DisplayMember = "TenDT";
            comboBoxDT.ValueMember = "idDT";
            comboBoxDT.DataSource = table;

        }

        private void buttonThoat_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
            add();

        }
        int idDT;
        string  mang2g, mang3g, sim, kichthuoc, trongluong, mausac, loaimanhinh, kichthuocmanhinh, audio, video, radio, kieuchuong, loangoai, bonhotrong, thenho, wlan, gprs, hspda, bluetooth, usb, gps, jack35, camerachinh, chucnang, cameraphu, quayphim, tinnhan, trinhduyet, hedieuhanh, cpu, chipset, gpu, java, trochoi, loaipin, thoigiancho, thoigianhoatdong, khac;
        // them data
        public void add()
        {
            idDT = int.Parse(comboBoxDT.SelectedValue.ToString());
            mang2g = txtMang2G.Text; mang3g = txtMang3G.Text; sim = txtSim.Text; khac = txtKhac.Text;
            loangoai = txtLoaNgoai.Text; thenho = txtTheNho.Text; bluetooth = txtBlueTooth.Text;
            camerachinh = txtCameraChinh.Text; tinnhan = txtTinNhan.Text; hedieuhanh = txtHDH.Text;
            java = txtJava.Text; thoigiancho = txtThoiGianCho.Text; kichthuoc = txtKichThuoc.Text; 
            trongluong = txtTrongLuong.Text; mausac = txtMauSac.Text; loaimanhinh = txtLoaiManHinh.Text; 
            bonhotrong = txtBoNhoTrong.Text; gprs = txtGPRS.Text; usb = txtUSB.Text; jack35 = txtJack.Text; 
            cameraphu = txtCameraPhu.Text; trinhduyet = txtTrinhDuyet.Text; gpu = txtGPU.Text; 
            trochoi = txtTroChoi.Text; thoigianhoatdong = txtThoiGianHoatDong.Text; kichthuocmanhinh = txtKTManHinh.Text; 
            audio = txtAudio.Text; video = txtVideo.Text; radio = txtRadio.Text; kieuchuong = txtKieuChuong.Text; 
            wlan = txtWLan.Text; hspda = txtHSPDA.Text; gps = txtGPS.Text; chucnang = txtChucNang.Text; 
            quayphim = txtQuayPhim.Text; cpu = txtCPU.Text; chipset = txtChipSet.Text; loaipin = txtLoaiPin.Text;
            dtct = new ConsumerWinform.WSSDT.WSSDT();
            int rs;

            //sql = "INSERT INTO TinhNangDienThoai ( idDT, Mang2G, Mang3G, Sim, KichThuoc, TrongLuong, MauSac, LoaiManHinh, KichThuocManHinh, Audio, Video, Radio, KieuChuong, LoaNgoai, BoNhoTrong, TheNho, Wlan, GPRS, HSPDA, Bluetooth, USB, GPS, Jack35, CameraChinh, ChucNang, CameraPhu, QuayPhim, TinNhan, TrinhDuyet, HeDieuHanh, CPU, Chipset, GPU, JAVA, TroChoi, LoaiPin, ThoiGianCho, ThoiGianHoatDong, Khac) VALUES ('"+idDT+"', '"+mang2g+"', '"+mang3g+ "','"+sim+"', '"+kichthuoc+"', '"+trongluong+"', '"+mausac+"', '"+loaimanhinh+"', '"+kichthuocmanhinh+"','"+audio+"', '" + video+"', '"+radio+"', '"+kieuchuong+"', '"+loangoai+"', '"+bonhotrong+"', '"+thenho+"', '"+wlan+"', '"+gprs+"', '"+hspda+"', '"+bluetooth+"', '"+usb+"', '"+gps+"', '"+jack35+"', '"+camerachinh+"', '"+chucnang+"', '"+cameraphu+"', '"+quayphim+"', '"+tinnhan+"', '"+trinhduyet+"', '"+hedieuhanh+"', '"+cpu+"', '"+chipset+"', '"+gpu+ "', '"+java+ "', '"+trochoi+"', '"+loaipin+"', '"+thoigiancho+"', '"+thoigianhoatdong+"', '"+khac+"')";
            sql = "INSERT INTO TinhNangDienThoai ( idDT, Mang2G, Mang3G, Sim, KichThuoc, TrongLuong, MauSac, LoaiManHinh, KichThuocManHinh, Audio, Video, Radio, KieuChuong, LoaNgoai, BoNhoTrong, TheNho, Wlan, GPRS, HSPDA, Bluetooth, USB, GPS, Jack35, CameraChinh, ChucNang, CameraPhu, QuayPhim, TinNhan, TrinhDuyet, HeDieuHanh, CPU, Chipset, GPU, JAVA, TroChoi, LoaiPin, ThoiGianCho, ThoiGianHoatDong, Khac) VALUES ('"+idDT+"','"+mang2g+"', '"+mang3g+"', '"+sim+"', '"+kichthuoc+"','"+trongluong+"', '"+mausac+"',' "+loaimanhinh+"', '"+kichthuocmanhinh+"', '"+audio+"', '"+video+"', '"+radio+"', '"+kieuchuong+"', '"+loangoai+"', '"+bonhotrong+"', '"+thenho+"', '"+wlan+"', '"+gprs+"', '"+hspda+"', '"+bluetooth+"', '"+usb+"', '"+gps+"', '"+jack35+"', '"+camerachinh+"', '"+chucnang+"', '"+cameraphu+"', '"+quayphim+"', '"+tinnhan+"', '"+trinhduyet+"', '"+hedieuhanh+"', '"+cpu+"', '"+chipset+"', '"+gpu+"', '"+java+"', '"+trochoi+"',' "+loaipin+"', '"+thoigiancho+"', '"+thoigianhoatdong+"', '"+khac+"')";
            MessageBox.Show(sql);
            rs = dtct.InsertDeleteQuery(sql);

        }
    }
}
