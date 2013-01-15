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
    public partial class FormThem : Form
    {
        int idDT;
        string mang2g, mang3g, sim, kichthuoc, trongluong, mausac, loaimanhinh, kichthuocmanhinh, audio, video, radio, kieuchuong, loangoai, bonhotrong, thenho, wlan, gprs, hspda, bluetooth, usb, gps, jack35, camerachinh, chucnang, cameraphu, quayphim, tinnhan, trinhduyet, hedieuhanh, cpu, chipset, gpu, java, trochoi, loaipin, thoigiancho, thoigianhoatdong, khac;



        ConsumerWinform.WSSDT.WSSDT dtct; 
        /// <summary>
        DataSet dts;
        DataSet ds;
        DataTable table;
        DataTable table2;

        /// </summary>
        ///
        //int rs;
        string ttct = "";
        string dt = "";
        string tndt = "";
        string sql = "";
        /// <summary>
        /// //////////////////
        /// </summary>
        int id;
        string ten;
        int gia;
        string img;
        string mota;
        string phukien;
        int baohanh;
        string khuyenmai;
        string date;
        int ah;
       // FormHSX fHSX = new FormHSX();
        DialogResult rsl;
        public FormThem()
        {
            InitializeComponent();


        }
        private void FormThem_Load(object sender, EventArgs e)
        {
            Frmload();

        }


        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }
        public void showformTND()
        {
            FormTNDT ftn = new FormTNDT();
            ftn.Show();
        }
        private void buttonExit_Click(object sender, EventArgs e)
        {
            //Application.Exit();
            this.Dispose();
        }

        private void buttonThem_Click(object sender, EventArgs e)
        {


            //--------------------------
            add();
            rsl = MessageBox.Show(this, "Nhấn Yes Để Thêm Tính Năng ĐT?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rsl == DialogResult.Yes)
            {
                showformTND();
            }
            else { XOA(); }
            
        }

        private void buttonHuy_Click(object sender, EventArgs e)
        {
            XOA();
               
        }
        

        private void groupBox6_Enter(object sender, EventArgs e)
        {

        }

        private void buttonHSX_Click(object sender, EventArgs e)
        {
            FormHSX fHSX = new FormHSX();
            fHSX.Show();
        }

        

        private void buttonTTChiTiet_Click(object sender, EventArgs e)
        {
            FormTTChiTiet fTT = new FormTTChiTiet();
            fTT.Show();
        }




      
        private void buttonXoa_Click(object sender, EventArgs e)
        {
            Xoa();
            Frmload();
        }

        public void Xoa()
        {
            id = int.Parse(comboBoxDT.SelectedValue.ToString());
            int rs;
            ConsumerWinform.WSSDT.WSSDT dtct = new ConsumerWinform.WSSDT.WSSDT();

            ttct = "DELETE FROM THONGTINCHITIET WHERE idDT='" + id + "'";
            dt = "DELETE FROM DIENTHOAI WHERE idDT='" + id + "'";
            tndt = "DELETE FROM TINHNANGDIENTHOAI WHERE idDT='" + id + "'";

            //MessageBox.Show(sql);
            rsl = MessageBox.Show(this, "Bạn Có Muốn Xóa Không...?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rsl == DialogResult.Yes)
            {
                rs = dtct.InsertDeleteQuery(ttct);
                rs = dtct.InsertDeleteQuery(dt);
                rs = dtct.InsertDeleteQuery(tndt);


            }
            else { }
        }
        //---------------------------------------------------------

        private void comboBoxDT_SelectedIndexChanged(object sender, EventArgs e)
        {
            panelDienThoai.Enabled = true;
            panelTNDT.Enabled = true;
            ReadData();
        }
        //doc du lieu
        public void ReadData()
        {
            id = int.Parse(comboBoxDT.SelectedValue.ToString());
            ConsumerWinform.WSSDT.WSSDT dtct = new ConsumerWinform.WSSDT.WSSDT();
            //IDataReader reader = new IDataReader();
            dts = new DataSet();
            table = new DataTable();
            // table dien thoai
            string dt = "";
            dt = "SELECT TenDT, Gia, HinhAnh, MoTa, PhuKien, BaoHanh, KhuyenMai, NgayCapNhat, AnHien, idHSX  FROM DIENTHOAI  WHERE idDT ='" + id + "'";
            dts = dtct.SelectQuery(dt);
            table = dts.Tables[0];
            txtidHSX.Text = table.Rows[0][9].ToString();
            txtTenDT.Text = table.Rows[0][0].ToString();
            txtGia.Text = table.Rows[0][1].ToString();
            txtHinhAnh.Text = table.Rows[0][2].ToString();
            txtMoTa.Text = table.Rows[0][3].ToString();
            txtPhuKien.Text = table.Rows[0][4].ToString();
            txtBaoHanh.Text = table.Rows[0][5].ToString();
            txtKhuyenMai.Text = table.Rows[0][6].ToString();
            txtNgayCapNhat.Text = table.Rows[0][7].ToString();
            txtDTAnHien.Text = table.Rows[0][8].ToString();
            // table tinh nang dien thoai
           
            string tn;
            tn = "Select Mang2g, Mang3G , Sim, KichThuoc, TrongLuong, MauSac, LoaiManHinh, KichThuocManHinh, Audio, Video, Radio, KieuChuong, LoaNgoai, BoNhoTrong, TheNho, Wlan, GPRS, HSPDA, Bluetooth, USB, GPS, Jack35, CameraChinh, ChucNang, CameraPhu, QuayPhim, TinNhan, TrinhDuyet, HeDieuHanh, CPU, ChipSet, GPU, JAVA, TroChoi, LoaiPin, ThoiGianCho, ThoiGianHoatDong, Khac From TinhNangDienThoai where idDT='" + id + "'";
            ds = new DataSet();
            table2 = new DataTable();
            ds = dtct.SelectQuery(tn);
            table2 = ds.Tables[0];

            txtMang2G.Text = table2.Rows[0][0].ToString();
            txtMang3G.Text = table2.Rows[0][1].ToString();
            txtSim.Text = table2.Rows[0][2].ToString();
            txtKichThuoc.Text = table2.Rows[0][3].ToString();
            txtTrongLuong.Text = table2.Rows[0][4].ToString();
            txtMauSac.Text = table2.Rows[0][5].ToString();
            txtLoaiManHinh.Text = table2.Rows[0][6].ToString();
            txtKTManHinh.Text=table2.Rows[0][7].ToString();
            txtAudio.Text = table2.Rows[0][8].ToString();
            txtVideo.Text = table2.Rows[0][9].ToString();
            txtRadio.Text = table2.Rows[0][10].ToString();
            txtKieuChuong.Text = table2.Rows[0][11].ToString();
            txtLoaNgoai.Text = table2.Rows[0][12].ToString();
            txtBoNhoTrong.Text = table2.Rows[0][13].ToString();
            txtTheNho.Text = table2.Rows[0][14].ToString();
            txtWLan.Text = table2.Rows[0][15].ToString();
            txtGPRS.Text = table2.Rows[0][16].ToString();
            txtHSPDA.Text = table2.Rows[0][17].ToString();
            txtBlueTooth.Text = table2.Rows[0][18].ToString();
            txtUSB.Text = table2.Rows[0][19].ToString();
            txtGPS.Text = table2.Rows[0][20].ToString();
            txtJack.Text = table2.Rows[0][21].ToString();
            txtCameraChinh.Text = table2.Rows[0][21].ToString();
            txtChucNang.Text = table2.Rows[0][23].ToString();
            txtCameraPhu.Text = table2.Rows[0][24].ToString();
            txtQuayPhim.Text = table2.Rows[0][25].ToString();
            txtTinNhan.Text = table2.Rows[0][26].ToString();
            txtTrinhDuyet.Text = table2.Rows[0][27].ToString();
            txtHDH.Text = table2.Rows[0][28].ToString();
            txtCPU.Text = table2.Rows[0][29].ToString();
            txtChipSet.Text = table2.Rows[0][30].ToString();
            txtGPU.Text = table2.Rows[0][31].ToString();
            txtJava.Text = table2.Rows[0][32].ToString();
            txtTroChoi.Text = table2.Rows[0][33].ToString();
            txtLoaiPin.Text = table2.Rows[0][34].ToString();
            txtThoiGianCho.Text = table2.Rows[0][35].ToString();
            txtThoiGianHoatDong.Text = table2.Rows[0][36].ToString();
            txtKhac.Text = table2.Rows[0][37].ToString();
            
        }

        //------------------------------------------------------------------
        /*public void Them()
        {
            id = int.Parse(txtidHSX.Text);
            ten = txtTenDT.Text;
            gia = int.Parse(txtGia.Text);
            img = txtHinhAnh.Text;
            mota = txtMoTa.Text;
            phukien = txtPhuKien.Text;
            baohanh = int.Parse(txtBaoHanh.Text);
            khuyenmai = txtKhuyenMai.Text;
            date = txtNgayCapNhat.Text;
            ah = int.Parse(txtDTAnHien.Text);
            int rs;
            dtct = new ComsumerWinform.WSSDT.WSSDT();
            
            sql = "INSER INTO DIENTHOAI (idHSX, TenDT, Gia, HinhAnh, MoTa, PhuKien, BaoHanh, KhuyenMai, NgayCapNhat, AnHien) VALUES ('" + id + "','" + ten + "','" + gia + "','" + img + "','" + mota + "','" + phukien + "','" + baohanh + "','" + khuyenmai + "','" + date + "','" + ah + "')";
            //MessageBox.Show(sql);
            rs = dtct.InsertDeleteQuery(sql);
        }*/

        private void buttonSua_Click(object sender, EventArgs e)
        {
            edit();
            XOA();
        }
        //----------
   
        private void buttonThemTNDT_Click(object sender, EventArgs e)
        {
            showformTND();
        }

        private void buttonreload_Click(object sender, EventArgs e)
        {
            Frmload();
            
        }
        //================
        public bool IsNumber(string testvalue)
        {
            foreach (char c in testvalue)
            {
                if (!Char.IsDigit(c))
                    return false;
            }
            return true;
        }


        //=======================================================================
        string imgname;          
        public void LoadAnh()
        {
            
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.InitialDirectory = "documents";
            openFile.Filter = "JPG|*.jpg";
            openFile.ShowDialog();
            imgname = System.IO.Path.GetFileName(openFile.FileName);
            if (DialogResult != System.Windows.Forms.DialogResult.Cancel)
            {
                openFile.CheckFileExists = true;
                for (int fheight = Height; fheight < 440; fheight += 5)
                    Height = fheight;
                pictureBoxDT.Show();
                pictureBoxDT.ImageLocation = openFile.FileName;
                pictureBoxDT.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            txtHinhAnh.Text = (string)imgname;
        }

        private void buttonload_Click(object sender, EventArgs e)
        {
            LoadAnh();
        }       

        public void SaveAnh()
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "JPG|*.jpg";
            saveFile.InitialDirectory = "documents";
            saveFile.OverwritePrompt = true;
            saveFile.Title = "Lưu hình";
            saveFile.FileName = pictureBoxDT.ImageLocation;
            saveFile.ShowDialog();
            if (DialogResult == System.Windows.Forms.DialogResult.OK)
            {
                pictureBoxDT.Image.Save(saveFile.FileName);
                MessageBox.Show(string.Format("Đã lưu hình vào {0}", saveFile.FileName), "Xác nhận", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            pictureBoxDT.Image = null;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            SaveAnh();
        }
        public void XOA()
        {
            txtidHSX.Text = "";
            txtAudio.Text = "";
            txtBaoHanh.Text = "";
            txtBaoHanh.Text = "";
            txtBlueTooth.Text = "";
            txtBoNhoTrong.Text = "";
            txtCameraChinh.Text = "";
            txtCameraPhu.Text = "";
            txtChipSet.Text = "";
            txtChucNang.Text = "";
            txtCPU.Text = "";
            txtDTAnHien.Text = "";
            txtGia.Text = "";
            txtGPRS.Text = "";
            txtGPS.Text = "";
            txtGPU.Text = "";
            txtHDH.Text = "";
            txtHinhAnh.Text = "";
            txtHSPDA.Text = "";
            txtIDDT.Text = "";
            txtIDTN.Text = "";
            txtJack.Text = "";
            txtJava.Text = "";
            txtKhac.Text = "";
            txtKhuyenMai.Text = "";
            txtKichThuoc.Text = "";
            txtKieuChuong.Text = "";
            txtKTManHinh.Text = "";
            txtLoaiManHinh.Text = "";
            txtLoaiPin.Text = "";
            txtLoaNgoai.Text = "";
            txtMang2G.Text = "";
            txtMang3G.Text = "";
            txtMauSac.Text = "";
            txtMoTa.Text = "";
            txtNgayCapNhat.Text = "";
            txtPhuKien.Text = "";
            txtQuayPhim.Text = "";
            txtRadio.Text = "";
            txtSim.Text = "";
            txtTenDT.Text = "";
            txtTheNho.Text = "";
            txtThoiGianCho.Text = "";
            txtThoiGianHoatDong.Text = "";
            txtTinNhan.Text = "";
            txtTrinhDuyet.Text = "";
            txtTroChoi.Text = "";
            txtTrongLuong.Text = "";
            txtUSB.Text = "";
            txtVideo.Text = "";
            txtWLan.Text = "";
        }
        //=================================
        public void add()
        {
            dtct = new ConsumerWinform.WSSDT.WSSDT();
            int rs;
            id = int.Parse(txtidHSX.Text);
            ten = txtTenDT.Text;
            gia = int.Parse(txtGia.Text);
            img = txtHinhAnh.Text;
            mota = txtMoTa.Text;
            phukien = txtPhuKien.Text;
            baohanh = int.Parse(txtBaoHanh.Text);
            khuyenmai = txtKhuyenMai.Text;
            date = txtNgayCapNhat.Text;
            ah = int.Parse(txtDTAnHien.Text);
            sql = "INSERT INTO dienthoai (idHSX, TenDT, Gia, HinhAnh, mota, phukien, baohanh, khuyenmai, ngaycapnhat, anhien) VALUES ('" + id + "','" + ten + "','" + gia + "','" + img + "','" + mota + "','" + phukien + "','" + baohanh + "', '" + khuyenmai + "','" + date + "', '" + ah + "')";
            MessageBox.Show(sql);
            rs = dtct.InsertDeleteQuery(sql);

        }

        public void edit()
        {
            dtct = new ConsumerWinform.WSSDT.WSSDT();
            int rs;
            ten = txtTenDT.Text;
            gia = int.Parse(txtGia.Text);
            img = txtHinhAnh.Text;
            mota = txtMoTa.Text;
            phukien = txtPhuKien.Text;
            baohanh = int.Parse(txtBaoHanh.Text);

            khuyenmai = txtKhuyenMai.Text;
            date = txtNgayCapNhat.Text;
            ah = int.Parse(txtDTAnHien.Text);
            dt = "update dienthoai set TenDT='" + ten + "', Gia='" + gia + "', HinhAnh='" + img + "',MoTa=N'" + mota + "', PhuKien=N'" + phukien + "',BaoHanh='" + baohanh + "', KhuyenMai=N'" + khuyenmai + "', NgayCapNhat='" + date + "', AnHien='" + ah + "' where idDT='" + id + "'";
            // MessageBox.Show(sql);           

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
            tndt = "UPDATE TinhNangDienThoai SET  Mang2G='" + mang2g + "', Mang3G='" + mang3g + "', Sim='" + sim + "', KichThuoc='" + kichthuoc + "', TrongLuong='" + trongluong + "', MauSac='" + mausac + "', LoaiManHinh='" + loaimanhinh + "', KichThuocManHinh='" + kichthuocmanhinh + "', Audio='" + audio + "', Video='" + video + "', Radio='" + radio + "', KieuChuong='" + kieuchuong + "', LoaNgoai='" + loangoai + "', BoNhoTrong='" + bonhotrong + "', TheNho='" + thenho + "', Wlan='" + wlan + "', GPRS='" + gprs + "', HSPDA='" + hspda + "', Bluetooth='" + bluetooth + "', USB='" + usb + "', GPS='" + gps + "', Jack35='" + jack35 + "', CameraChinh='" + camerachinh + "', ChucNang='" + chucnang + "', CameraPhu='" + cameraphu + "', QuayPhim='" + quayphim + "', TinNhan='" + tinnhan + "', TrinhDuyet='" + trinhduyet + "', HeDieuHanh='" + hedieuhanh + "', CPU='" + cpu + "', Chipset='" + chipset + "', GPU='" + gpu + "', JAVA='" + java + "', TroChoi='" + trochoi + "', LoaiPin='" + loaipin + "', ThoiGianCho='" + thoigiancho + "', ThoiGianHoatDong='" + thoigianhoatdong + "', Khac='" + khac + "' where idDT='" + id + "'";
            //MessageBox.Show(tndt);
            rs = dtct.InsertDeleteQuery(tndt);
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

        private void buttonload_Click_1(object sender, EventArgs e)
        {
            LoadAnh();
        }

        private void buttonSave_Click_1(object sender, EventArgs e)
        {
            SaveAnh();
        }

        private void buttonClear_Click_1(object sender, EventArgs e)
        {
            pictureBoxDT.Image = null;
        }

    }
}
