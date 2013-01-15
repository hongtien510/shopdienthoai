<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage1.Master" AutoEventWireup="true" CodeBehind="dienthoaichitiet.aspx.cs" Inherits="ShopDienThoai.dienthoaichitietForm" %>
<asp:Content ID="dienthoaichitietContent" ContentPlaceHolderID="MainContaint" runat="server">

    <asp:Repeater runat="server" ID="DienThoaiChiTiet">
    <ItemTemplate>
     
		<div class="ctn_dienthoaichitiet">
			<div class="content_title_large left">
				<h3 class="text_title"><%# Eval("TenDT") %></h3>
			</div>
			<div class="dienthoaichitiet bg_middle">
				<table border="0" width="590">
					<tr>
						<td width="182" rowspan="2" align="center" class="bd-right"><img src='<%# "images/" + Eval("TenHSX") + "/" + Eval("HinhAnh") %>' height="200" /></td>
						<td width="396">
							<p><span class="tendt"><%# Eval("TenDT") %></span></p><br />
							<p><span style="font-weight:bold">Giá:</span> <span class="giadt"><%# Eval("Gia") %> VNĐ</span></p><br />
							<p style="line-height:15px"><span class="col_text">Bộ bán hàng tiêu chuẩn: </span><br /><%# Eval("PhuKien") %></p>
							<p style="line-height:22px"><span class="col_text">Thời gian bảo hành: </span><%# Eval("baoHanh") %> tháng </p>
							<p style="line-height:22px"><span class="col_text">Thông Tin Khuyến Mãi: </span></p><%# Eval("KhuyenMai") %>
						</td>
					</tr>
					<tr>
						<td height="64" align="left" valign="middle">
							<a href=""><img src="images/dathang_but.gif" alt="DatMua" width="125" height="27" border="0" /></a>&nbsp;
							<a href=""><img style="position:relative; top:-2px" class="abc" src="images/SoSanh.gif" width="68" height="21" border="0"/></a>
						</td>
					</tr>
				</table>
			</div><!--End.dienthoaichitiet-->
			<div class="end_large"></div>
		</div><!--End .ctn_dienthoaichitiet-->
	</ItemTemplate>
    </asp:Repeater>
    
		<div class="ctn_dienthoaidonggia">
			<fieldset>
				<legend><span class="col_text weight_text">Điện thoại đồng giá</span></legend>
					<div class="dienthoaidonggia">
						<table width="589" border="0">
							<tr>
                                <asp:Repeater runat="server" ID="DienThoaiDongGia">
                                <ItemTemplate>
								    <td align="center">
									    <a class="tendt" href=""><span><%# Eval("TenDT") %></span></a><br/>
									    <span class="giadt"><%# Eval("Gia") %> VNĐ</span>
								    </td>
                                </ItemTemplate>
                                </asp:Repeater>
							</tr>
						</table>
					</div>
			</fieldset>
		</div><!--End.ctn_dienthoaidonggia-->   

		<div class="ctn_tab">
			<div class="tabs">
				<div class="tab action"><a href="#">Thông tin chi tiết</a></div>
				<div class="tab"><a href="#">Tính năng điện thoại</a></div>
				<div class="tab"><a href="#">Nhận xét</a></div>
			</div><!--End .tabs-->
			
    <asp:Repeater runat="server" ID="ThongTinChiTiet">
    <ItemTemplate>
			<div class="listtab_ct" >
				<div class="top_large"></div>
				<div style="display:inline-block;padding:10px">
					<%# Eval("BaiViet") %>
				</div>
			<div class="end_large clear"></div> 
			</div><!--End .listtab_ct-->
    </ItemTemplate>
	</asp:Repeater>

			<div class="listtab_ct hidden">
				<div class="top_large"></div>
				<div style="display:inline-block;padding:10px">

    <asp:Repeater runat="server" ID="TinhNangDienThoai">
    <ItemTemplate>
					<table width="590" border="1" cellpadding="0" cellspacing="0">
						<tr>
							<td width="122" rowspan="3">THÔNG TIN CHUNG</td>
							<td width="165" align="left">Mạng 2G</td>
							<td width="295" align="left"><%#Eval("Mang2G") %></td>
						</tr>
						<tr>
							<td>Mạng 3G</td>
							<td><%#Eval("Mang3G") %></td>
						</tr>
						<tr>
							<td>SIM</td>
							<td><%#Eval("Sim") %></td>
						</tr>
						<tr>
							<td colspan="3">&nbsp;</td>
							</tr>
						<tr>
							<td rowspan="3">KÍCH THƯỚC</td>
							<td align="left">Kích Thước</td>
							<td align="left"><%#Eval("KichThuoc") %></td>
						</tr>
						<tr>
							<td>Trọng Lượng</td>
							<td><%#Eval("TrongLuong") %></td>
						</tr>
						<tr>
							<td>Màu Sắc</td>
							<td><%#Eval("MauSac") %></td>
						</tr>
						<tr>
							<td colspan="3">&nbsp;</td>
							</tr>
						<tr>
							<td rowspan="2">HIỂN THỊ</td>
							<td align="left">Loại Màn Hình</td>
							<td align="left"><%#Eval("LoaiManHinh") %></td>
						</tr>
						<tr>
							<td>Kích Thước</td>
							<td><%#Eval("KichThuocManHinh") %></td>
						</tr>
						<tr>
							<td colspan="3">&nbsp;</td>
							</tr>
						<tr>
							<td rowspan="5">ÂM THANH</td>
							<td align="left">Audio</td>
							<td align="left"><%#Eval("Audio") %></td>
						</tr>
						<tr>
							<td>Video</td>
							<td><%#Eval("Video") %></td>
						</tr>
						<tr>
							<td>Radio</td>
							<td><%#Eval("Radio") %></td>
						</tr>
						<tr>
							<td>Kiểu Chuông</td>
							<td><%#Eval("KieuChuong") %></td>
						</tr>
						<tr>
							<td>Loa Ngoài</td>
							<td><%#Eval("LoaNgoai") %></td>
							</tr>
						<tr>
							<td colspan="3">&nbsp;</td>
							</tr>
						<tr>
							<td rowspan="2">BỘ NHỚ</td>
							<td align="left">Bộ Nhớ Trong</td>
							<td align="left"><%#Eval("BoNhoTrong") %></td>
						</tr>
						<tr>
							<td>Khe Cắm Thẻ Nhớ</td>
							<td><%#Eval("TheNho") %></td>
						</tr>
                        <tr>
							<td colspan="3">&nbsp;</td>
							</tr>
                        <tr>
							<td rowspan="7">KẾT NỐI</td>
							<td align="left">WLAN</td>
							<td align="left"><%#Eval("Wlan") %></td>
						</tr>
						<tr>
							<td>GPRS</td>
							<td><%#Eval("GPRS") %></td>
						</tr>
						<tr>
							<td>Tốc Độ 3G</td>
							<td><%#Eval("HSPDA") %></td>
						</tr>
						<tr>
							<td>Bluetooth</td>
							<td><%#Eval("Bluetooth") %></td>
						</tr>
						<tr>
							<td>USB</td>
							<td><%#Eval("USB") %></td>
						</tr>
                        <tr>
							<td>GPS (A-GPS)</td>
							<td><%#Eval("GPS") %></td>
						</tr>
                        <tr>
							<td>3.5mm jack</td>
							<td><%#Eval("Jack35") %></td>
						</tr>
						<tr>
							<td colspan="3">&nbsp;</td>
							</tr>
                        <tr>
							<td rowspan="4">CAMERA</td>
							<td align="left">Camera Chính</td>
							<td align="left"><%#Eval("CameraChinh") %></td>
						</tr>
						<tr>
							<td>Chức Năng</td>
							<td><%#Eval("ChucNang") %></td>
						</tr>
						<tr>
							<td>Camera Phụ</td>
							<td><%#Eval("CameraPhu") %></td>
						</tr>
						<tr>
							<td>Quay Phim</td>
							<td><%#Eval("QuayPhim") %></td>
						</tr>
						<tr>
							<td colspan="3">&nbsp;</td>
							</tr>
                        <tr>
							<td rowspan="8">ĐẶC ĐIỂM</td>
							<td align="left">Tin Nhắn</td>
							<td align="left"><%#Eval("TinNhan") %></td>
						</tr>
						<tr>
							<td>Trình Duyệt</td>
							<td><%#Eval("TrinhDuyet") %></td>
						</tr>
						<tr>
							<td>Hệ Điều Hành</td>
							<td><%#Eval("HeDieuHanh") %></td>
						</tr>
						<tr>
							<td>CPU</td>
							<td><%#Eval("CPU") %></td>
						</tr>
						<tr>
							<td>Chipset</td>
							<td><%#Eval("Chipset") %></td>
						</tr>
                        <tr>
							<td>GPU</td>
							<td><%#Eval("GPU") %></td>
						</tr>
                        <tr>
							<td>JAVA</td>
							<td><%#Eval("JAVA") %></td>
						</tr>
                        <tr>
							<td>Trò Chơi</td>
							<td><%#Eval("TroChoi") %></td>
						</tr>
                        <tr>
							<td colspan="3">&nbsp;</td>
							</tr>
                        <tr>
							<td rowspan="3">PIN</td>
							<td align="left">Loại Pin</td>
							<td align="left"><%#Eval("LoaiPin") %></td>
						</tr>
                        <tr>
							<td>Thời Gian Chờ</td>
							<td><%#Eval("ThoiGianCho") %></td>
						</tr>
                        <tr>
							<td>Thời Gian Hoạt Động</td>
							<td><%#Eval("ThoiGianHoatDong") %></td>
						</tr>
						<tr>
							<td colspan="3">&nbsp;</td>
							</tr>
                        <tr>
							<td rowspan="1">KHÁC</td>
							<td align="left">Khác</td>
							<td align="left"><%#Eval("Khac") %></td>
						</tr>
						
						<tr>
							<td colspan="3">&nbsp;</td>
							</tr>
					</table>
    </ItemTemplate>
    </asp:Repeater>
				</div>
				<div class="end_large clear"></div> 
			</div><!--End.listtab_ct-->
			
			<div class="listtab_ct hidden">
				<div class="top_large"></div>
				<div style="display:inline-block;padding:10px">
					Hiện tại chưa có nhân xét về sản phẩm này
				</div>
				<div class="end_large clear"></div> 
			</div><!--End .listtab_ct-->
		</div><!--End .ctn_tab-->

    
</asp:Content>
