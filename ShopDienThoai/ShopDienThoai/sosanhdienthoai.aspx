<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage3.Master" AutoEventWireup="true" CodeBehind="sosanhdienthoai.aspx.cs" Inherits="ShopDienThoai.sosanhdienthoaiForm" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Detail2Content" runat="server">
<div class="ctn_sosanhdienthoai">
			<div class="title_largest left">
				<h3 class="text_title">So sánh điện thoại</h3>
			</div>
			<div class="sosanhdienthoai bg_middle_largest" style="width:100%">
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>

				<table width="99%" border="0">
					<tr>
						<td width="143">Hãng</td>
						<td width="210" align="center">
                            <asp:DropDownList ID="ddl_hsx1" runat="server" AutoPostBack="True" 
                                onselectedindexchanged="ddl_hsx1_SelectedIndexChanged">
                            <asp:ListItem Value="0" Selected="True">-----Chọn Hãng------</asp:ListItem>
                            </asp:DropDownList>
						</td>
						
						<td width="210" align="center">
							<asp:DropDownList ID="ddl_hsx2" runat="server" AutoPostBack="True" 
                                onselectedindexchanged="ddl_hsx2_SelectedIndexChanged">
                            <asp:ListItem Value="0" Selected="True">-----Chọn Hãng------</asp:ListItem>
                            </asp:DropDownList>
						</td>
						
						<td width="210" align="center">
							<asp:DropDownList ID="ddl_hsx3" runat="server" AutoPostBack="True" 
                                onselectedindexchanged="ddl_hsx3_SelectedIndexChanged">
                            <asp:ListItem Value="0" Selected="True">-----Chọn Hãng------</asp:ListItem>
                            </asp:DropDownList>
						</td>
					</tr>
					<tr>
						<td>Model</td>
						<td align="center">
							<asp:DropDownList ID="ddl_dt1" runat="server" AutoPostBack="True" 
                                onselectedindexchanged="ddl_dt1_SelectedIndexChanged">
                            <asp:ListItem Value="0" Selected="True">-----Chọn Model------</asp:ListItem>
                            </asp:DropDownList>
						</td>
						<td align="center">
							<asp:DropDownList ID="ddl_dt2" runat="server" AutoPostBack="True" 
                                onselectedindexchanged="ddl_dt2_SelectedIndexChanged">
                            <asp:ListItem Value="0" Selected="True">-----Chọn Model------</asp:ListItem>
                            </asp:DropDownList>
						</td>
						<td align="center">
							<asp:DropDownList ID="ddl_dt3" runat="server" AutoPostBack="True" 
                                onselectedindexchanged="ddl_dt3_SelectedIndexChanged">
                            <asp:ListItem Value="0" Selected="True">-----Chọn Model------</asp:ListItem>
                            </asp:DropDownList>
						</td>
					</tr> 
                        
					<tr>
						<td height="196">Hình ảnh</td>
						<td align="center">&nbsp;
							<span ><asp:Literal ID="ltr_TenDT1" runat="server"></asp:Literal></span><br/><br/>
                            <asp:Image ID="img_HinhAnh1" runat="server" height="160" /><br/><br/>
							<span class="giadt"><asp:Literal ID="ltr_Gia1" runat="server"></asp:Literal></span>
						</td>
                        <td align="center">&nbsp;
							<span class="tendt"><asp:Literal ID="ltr_TenDT2" runat="server"></asp:Literal></span><br/><br/>
                            <asp:Image ID="img_HinhAnh2" runat="server" height="160" /><br/><br/>
							<span class="giadt"><asp:Literal ID="ltr_Gia2" runat="server"></asp:Literal></span>
						</td>
                        <td align="center">&nbsp;
							<span class="tendt"><asp:Literal ID="ltr_TenDT3" runat="server"></asp:Literal></span><br/><br/>
                            <asp:Image ID="img_HinhAnh3" runat="server" height="160" /><br/><br/>
							<span class="giadt"><asp:Literal ID="ltr_Gia3" runat="server"></asp:Literal></span>
						</td>
					</tr>
					<tr>
						<td colspan="4" class="col_tr col_text">THÔNG TIN CHUNG</td>
					</tr>
					<tr>
						<td>Mạng 2G</td>
						<td><asp:Literal ID="ltr_Mang2G1" runat="server"></asp:Literal></td>
						<td><asp:Literal ID="ltr_Mang2G2" runat="server"></asp:Literal></td>
                        <td><asp:Literal ID="ltr_Mang2G3" runat="server"></asp:Literal></td>
					</tr>
					<tr>
						<td>Mạng 3G</td>
						<td><asp:Literal ID="ltr_Mang3G1" runat="server"></asp:Literal></td>
						<td><asp:Literal ID="ltr_Mang3G2" runat="server"></asp:Literal></td>
                        <td><asp:Literal ID="ltr_Mang3G3" runat="server"></asp:Literal></td>
					</tr>
                    <tr>
						<td>SIM</td>
						<td><asp:Literal ID="ltr_Sim1" runat="server"></asp:Literal></td>
						<td><asp:Literal ID="ltr_Sim2" runat="server"></asp:Literal></td>
                        <td><asp:Literal ID="ltr_Sim3" runat="server"></asp:Literal></td>
					</tr>
					<tr>
						<td colspan="4" class="col_tr col_text">KÍCH THƯỚC</td>
					</tr>
					<tr>
						<td>Kích Thước</td>
						<td><asp:Literal ID="ltr_KichThuoc1" runat="server"></asp:Literal></td>
						<td><asp:Literal ID="ltr_KichThuoc2" runat="server"></asp:Literal></td>
                        <td><asp:Literal ID="ltr_KichThuoc3" runat="server"></asp:Literal></td>
					</tr>
					<tr>
						<td>Trọng Lượng</td>
						<td><asp:Literal ID="ltr_TrongLuong1" runat="server"></asp:Literal></td>
						<td><asp:Literal ID="ltr_TrongLuong2" runat="server"></asp:Literal></td>
                        <td><asp:Literal ID="ltr_TrongLuong3" runat="server"></asp:Literal></td>
					</tr>
					<tr>
						<td>Màu Sắc</td>
						<td><asp:Literal ID="ltr_MauSac1" runat="server"></asp:Literal></td>
						<td><asp:Literal ID="ltr_MauSac2" runat="server"></asp:Literal></td>
                        <td><asp:Literal ID="ltr_MauSac3" runat="server"></asp:Literal></td>
					</tr>
					<tr>
						<td colspan="4" class="col_tr col_text">HIỂN THỊ</td>
					</tr>
					<tr>
						<td>Loại Màn Hình</td>
						<td><asp:Literal ID="ltr_LoaiManHinh1" runat="server"></asp:Literal></td>
						<td><asp:Literal ID="ltr_LoaiManHinh2" runat="server"></asp:Literal></td>
                        <td><asp:Literal ID="ltr_LoaiManHinh3" runat="server"></asp:Literal></td>
					</tr>
					<tr>
						<td>Kích Thước</td>
						<td><asp:Literal ID="ltr_KichThuocManHinh1" runat="server"></asp:Literal></td>
						<td><asp:Literal ID="ltr_KichThuocManHinh2" runat="server"></asp:Literal></td>
                        <td><asp:Literal ID="ltr_KichThuocManHinh3" runat="server"></asp:Literal></td>
					</tr>
					
					<tr>
						<td colspan="4" class="col_tr col_text">ÂM THANH</td>
					</tr>
					<tr>
						<td>Audio</td>
						<td><asp:Literal ID="ltr_Audio1" runat="server"></asp:Literal></td>
						<td><asp:Literal ID="ltr_Audio2" runat="server"></asp:Literal></td>
                        <td><asp:Literal ID="ltr_Audio3" runat="server"></asp:Literal></td>
					</tr>
					<tr>
						<td>Video</td>
						<td><asp:Literal ID="ltr_Video1" runat="server"></asp:Literal></td>
						<td><asp:Literal ID="ltr_Video2" runat="server"></asp:Literal></td>
                        <td><asp:Literal ID="ltr_Video3" runat="server"></asp:Literal></td>
					</tr>
					<tr>
						<td>Radio</td>
						<td><asp:Literal ID="ltr_Radio1" runat="server"></asp:Literal></td>
						<td><asp:Literal ID="ltr_Radio2" runat="server"></asp:Literal></td>
                        <td><asp:Literal ID="ltr_Radio3" runat="server"></asp:Literal></td>
					</tr>
					<tr>
						<td>Kiểu Chuông</td>
						<td><asp:Literal ID="ltr_KieuChuong1" runat="server"></asp:Literal></td>
						<td><asp:Literal ID="ltr_KieuChuong2" runat="server"></asp:Literal></td>
                        <td><asp:Literal ID="ltr_KieuChuong3" runat="server"></asp:Literal></td>
					</tr>
					<tr>
						<td>Loa Ngoài</td>
						<td><asp:Literal ID="ltr_LoaNgoai1" runat="server"></asp:Literal></td>
						<td><asp:Literal ID="ltr_LoaNgoai2" runat="server"></asp:Literal></td>
                        <td><asp:Literal ID="ltr_LoaNgoai3" runat="server"></asp:Literal></td>
					</tr>
					<tr>
						<td colspan="4" class="col_tr col_text">BỘ NHỚ</td>
					</tr>
					<tr>
						<td>Bộ Nhớ Trong</td>
						<td><asp:Literal ID="ltr_BoNhoTrong1" runat="server"></asp:Literal></td>
						<td><asp:Literal ID="ltr_BoNhoTrong2" runat="server"></asp:Literal></td>
                        <td><asp:Literal ID="ltr_BoNhoTrong3" runat="server"></asp:Literal></td>
					</tr>
					<tr>
						<td>Khe Cắm Thẻ Nhớ</td>
						<td><asp:Literal ID="ltr_TheNho1" runat="server"></asp:Literal></td>
						<td><asp:Literal ID="ltr_TheNho2" runat="server"></asp:Literal></td>
                        <td><asp:Literal ID="ltr_TheNho3" runat="server"></asp:Literal></td>
					</tr>
                    <tr>
						<td colspan="4" class="col_tr col_text">KẾT NỐI</td>
					</tr>
					<tr>
						<td>WLAN</td>
						<td><asp:Literal ID="ltr_Wlan1" runat="server"></asp:Literal></td>
						<td><asp:Literal ID="ltr_Wlan2" runat="server"></asp:Literal></td>
                        <td><asp:Literal ID="ltr_Wlan3" runat="server"></asp:Literal></td>
					</tr>
					<tr>
						<td>GPRS</td>
						<td><asp:Literal ID="ltr_GPRS1" runat="server"></asp:Literal></td>
						<td><asp:Literal ID="ltr_GPRS2" runat="server"></asp:Literal></td>
                        <td><asp:Literal ID="ltr_GPRS3" runat="server"></asp:Literal></td>
					</tr>
                    <tr>
						<td>Tốc Độ 3G</td>
						<td><asp:Literal ID="ltr_HSPDA1" runat="server"></asp:Literal></td>
						<td><asp:Literal ID="ltr_HSPDA2" runat="server"></asp:Literal></td>
                        <td><asp:Literal ID="ltr_HSPDA3" runat="server"></asp:Literal></td>
					</tr>
					<tr>
						<td>Bluetooth</td>
						<td><asp:Literal ID="ltr_Bluetooth1" runat="server"></asp:Literal></td>
						<td><asp:Literal ID="ltr_Bluetooth2" runat="server"></asp:Literal></td>
                        <td><asp:Literal ID="ltr_Bluetooth3" runat="server"></asp:Literal></td>
					</tr>
                    <tr>
						<td>USB</td>
						<td><asp:Literal ID="ltr_USB1" runat="server"></asp:Literal></td>
						<td><asp:Literal ID="ltr_USB2" runat="server"></asp:Literal></td>
                        <td><asp:Literal ID="ltr_USB3" runat="server"></asp:Literal></td>
					</tr>
					<tr>
						<td>GPS (A-GPS)</td>
						<td><asp:Literal ID="ltr_GPS1" runat="server"></asp:Literal></td>
						<td><asp:Literal ID="ltr_GPS2" runat="server"></asp:Literal></td>
                        <td><asp:Literal ID="ltr_GPS3" runat="server"></asp:Literal></td>
					</tr>
                    <tr>
						<td>3.5mm jack</td>
						<td><asp:Literal ID="ltr_Jack351" runat="server"></asp:Literal></td>
						<td><asp:Literal ID="ltr_Jack352" runat="server"></asp:Literal></td>
                        <td><asp:Literal ID="ltr_Jack353" runat="server"></asp:Literal></td>
					</tr>
					<tr>
						<td colspan="4" class="col_tr col_text">CAMERA</td>
						</tr>
					<tr>
						<td>Camera Chính</td>
						<td><asp:Literal ID="ltr_CameraChinh1" runat="server"></asp:Literal></td>
						<td><asp:Literal ID="ltr_CameraChinh2" runat="server"></asp:Literal></td>
                        <td><asp:Literal ID="ltr_CameraChinh3" runat="server"></asp:Literal></td>
					</tr>
					<tr>
						<td>Chức Năng</td>
						<td><asp:Literal ID="ltr_ChucNang1" runat="server"></asp:Literal></td>
						<td><asp:Literal ID="ltr_ChucNang2" runat="server"></asp:Literal></td>
                        <td><asp:Literal ID="ltr_ChucNang3" runat="server"></asp:Literal></td>
					</tr>
                    <tr>
						<td>Camera Phụ</td>
						<td><asp:Literal ID="ltr_CameraPhu1" runat="server"></asp:Literal></td>
						<td><asp:Literal ID="ltr_CameraPhu2" runat="server"></asp:Literal></td>
                        <td><asp:Literal ID="ltr_CameraPhu3" runat="server"></asp:Literal></td>
					</tr>
					<tr>
						<td>Quay Phim</td>
						<td><asp:Literal ID="ltr_QuayPhim1" runat="server"></asp:Literal></td>
						<td><asp:Literal ID="ltr_QuayPhim2" runat="server"></asp:Literal></td>
                        <td><asp:Literal ID="ltr_QuayPhim3" runat="server"></asp:Literal></td>
					</tr>
                    <tr>
						<td colspan="4" class="col_tr col_text">ĐẶC ĐIỂM</td>
				    </tr>
					<tr>
						<td>Tin Nhắn</td>
						<td><asp:Literal ID="ltr_TinNhan1" runat="server"></asp:Literal></td>
						<td><asp:Literal ID="ltr_TinNhan2" runat="server"></asp:Literal></td>
                        <td><asp:Literal ID="ltr_TinNhan3" runat="server"></asp:Literal></td>
					</tr>
					<tr>
						<td>Trình Duyệt</td>
						<td><asp:Literal ID="ltr_TrinhDuyet1" runat="server"></asp:Literal></td>
						<td><asp:Literal ID="ltr_TrinhDuyet2" runat="server"></asp:Literal></td>
                        <td><asp:Literal ID="ltr_TrinhDuyet3" runat="server"></asp:Literal></td>
					</tr>
                    <tr>
						<td>Hệ Điều Hành</td>
						<td><asp:Literal ID="ltr_HeDieuHanh1" runat="server"></asp:Literal></td>
						<td><asp:Literal ID="ltr_HeDieuHanh2" runat="server"></asp:Literal></td>
                        <td><asp:Literal ID="ltr_HeDieuHanh3" runat="server"></asp:Literal></td>
					</tr>
					<tr>
						<td>CPU</td>
						<td><asp:Literal ID="ltr_CPU1" runat="server"></asp:Literal></td>
						<td><asp:Literal ID="ltr_CPU2" runat="server"></asp:Literal></td>
                        <td><asp:Literal ID="ltr_CPU3" runat="server"></asp:Literal></td>
					</tr>
                    <tr>
						<td>Chipset</td>
						<td><asp:Literal ID="ltr_Chipset1" runat="server"></asp:Literal></td>
						<td><asp:Literal ID="ltr_Chipset2" runat="server"></asp:Literal></td>
                        <td><asp:Literal ID="ltr_Chipset3" runat="server"></asp:Literal></td>
					</tr>
					<tr>
						<td>GPU</td>
						<td><asp:Literal ID="ltr_GPU1" runat="server"></asp:Literal></td>
						<td><asp:Literal ID="ltr_GPU2" runat="server"></asp:Literal></td>
                        <td><asp:Literal ID="ltr_GPU3" runat="server"></asp:Literal></td>
					</tr>
                    <tr>
						<td>JAVA</td>
						<td><asp:Literal ID="ltr_JAVA1" runat="server"></asp:Literal></td>
						<td><asp:Literal ID="ltr_JAVA2" runat="server"></asp:Literal></td>
                        <td><asp:Literal ID="ltr_JAVA3" runat="server"></asp:Literal></td>
					</tr>
                    <tr>
						<td>Trò Chơi</td>
						<td><asp:Literal ID="ltr_TroChoi1" runat="server"></asp:Literal></td>
						<td><asp:Literal ID="ltr_TroChoi2" runat="server"></asp:Literal></td>
                        <td><asp:Literal ID="ltr_TroChoi3" runat="server"></asp:Literal></td>
					</tr>
                    <tr>
						<td colspan="4" class="col_tr col_text">PIN</td>
						</tr>
					<tr>
						<td>Loại Pin</td>
						<td><asp:Literal ID="ltr_LoaiPin1" runat="server"></asp:Literal></td>
						<td><asp:Literal ID="ltr_LoaiPin2" runat="server"></asp:Literal></td>
                        <td><asp:Literal ID="ltr_LoaiPin3" runat="server"></asp:Literal></td>
					</tr>
                    <tr>
						<td>Thời Gian Chờ</td>
						<td><asp:Literal ID="ltr_ThoiGianCho1" runat="server"></asp:Literal></td>
						<td><asp:Literal ID="ltr_ThoiGianCho2" runat="server"></asp:Literal></td>
                        <td><asp:Literal ID="ltr_ThoiGianCho3" runat="server"></asp:Literal></td>
					</tr>
                    <tr>
						<td>Thời Gian Đàm Thoại</td>
						<td><asp:Literal ID="ltr_ThoiGianHoatDong1" runat="server"></asp:Literal></td>
						<td><asp:Literal ID="ltr_ThoiGianHoatDong2" runat="server"></asp:Literal></td>
                        <td><asp:Literal ID="ltr_ThoiGianHoatDong3" runat="server"></asp:Literal></td>
					</tr>
                    <tr>
						<td colspan="4" class="col_tr col_text">KHÁC</td>
						</tr>
                    <tr>
						<td>Khác</td>
						<td><asp:Literal ID="ltr_Khac1" runat="server"></asp:Literal></td>
						<td><asp:Literal ID="ltr_Khac2" runat="server"></asp:Literal></td>
                        <td><asp:Literal ID="ltr_Khac3" runat="server"></asp:Literal></td>
					</tr>
				</table>
        </ContentTemplate>
        </asp:UpdatePanel>
			</div><!--End#sosanhdienthoai-->
			<div class="bg_end_largest"></div>
</div><!--End .ctn_sosanhdienthoai-->
</asp:Content>
