<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="UC_TimTheoTinhNang.ascx.cs" Inherits="ShopDienThoai.Controls.UC_TimTheoTinhNang" %>
<div class="title_div_1">
				<h4 class="text_title">Tìm theo tính năng</h4>
			</div>
			<div class="timtheotinhnang middle_div_1">
					<table width="200" border="0">
						<tr>
							<td width="20%"><img src="images/Tim Theo Tinh Nang/1_camera_icon.gif" width="20" height="16" /></td>
							<td width="65%">Chụp ảnh</td>
							<td width="15%"><input name="tinhnang[]" type="checkbox" id="chupanh" value="chupanh" /></td>
						</tr>
						<tr>
							<td><img src="images/Tim Theo Tinh Nang/2_FM_icon.gif" width="18" height="20" /></td>
							<td>FM Radio</td>
							<td><input name="tinhnang[]" type="checkbox" id="fmradio" value="fmradio" /></td>
						</tr>
						<tr>
							<td><img src="images/Tim Theo Tinh Nang/3_memoryCard_icon.gif" width="13" height="18" /></td>
							<td>Thẻ nhớ ngoài</td>
							<td><input name="tinhnang[]" type="checkbox" id="thenho" value="thenho" /></td>
						</tr>
						<tr>
							<td><img src="images/Tim Theo Tinh Nang/4_GPRS_icon.gif" width="17" height="16" /></td>
							<td>GPRS</td>
							<td><input name="tinhnang[]" type="checkbox" id="gprs" value="gprs" /></td>
						</tr>
						<tr>
							<td><img src="images/Tim Theo Tinh Nang/5_videoCamera_icon.gif" width="24" height="16" /></td>
							<td>Quay phim</td>
							<td><input name="tinhnang[]" type="checkbox" id="quayphim" value="quayphim" /></td>
						</tr>
						<tr>
							<td><img src="images/Tim Theo Tinh Nang/6_ringtone_icon.gif" width="19" height="18" /></td>
							<td>Tải hình, chuông</td>
							<td><input name="tinhnang[]" type="checkbox" id="taihinh" value="taihinh" /></td>
						</tr>
						<tr>
							<td><img src="images/Tim Theo Tinh Nang/7_sound1_icon.gif" width="16" height="15" /></td>
							<td>Hỗ trợ loa ngoài</td>
							<td><input name="tinhnang[]" type="checkbox" id="loangoai" value="loangoai" /></td>
						</tr>
						<tr>
							<td><img src="images/Tim Theo Tinh Nang/8_3G_icon.gif" width="23" height="17" /></td>
							<td>Công nghệ 3G</td>
							<td><input name="tinhnang[]" type="checkbox" id="3g" value="3g" /></td>
						</tr>
						<tr>
							<td><img src="images/Tim Theo Tinh Nang/9_record_icon.gif" width="18" height="18" /></td>
							<td>Ghi âm cuộc gọi</td>
							<td><input name="tinhnang[]" type="checkbox" id="ghiam" value="ghiam" /></td>
						</tr>
						<tr>
							<td><img src="images/Tim Theo Tinh Nang/10_vibration_icon.gif" width="22" height="16" /></td>
							<td>Báo rung</td>
							<td><input name="tinhnang[]" type="checkbox" id="baorung" value="baorung" /></td>
						</tr>
						<tr>
							<td><img src="images/Tim Theo Tinh Nang/11_officeApp_icon.gif" width="19" height="18" /></td>
							<td>Ứng dụng văn phòng</td>
							<td><input name="tinhnang[]" type="checkbox" id="udvanphong" value="udvanphong" /></td>
						</tr>
						<tr>
							<td><img src="images/Tim Theo Tinh Nang/12_CDMA_icon.gif" width="23" height="10" /></td>
							<td>Công nghệ CDMA</td>
							<td><input name="tinhnang[]" type="checkbox" id="cdma" value="cdma" /></td>
						</tr>
						<tr>
							<td><img src="images/Tim Theo Tinh Nang/13_clock_icon.gif" width="18" height="18" /></td>
							<td>Đồng hồ báo thức</td>
							<td><input name="tinhnang[]" type="checkbox" id="baothuc" value="baothuc" /></td>
						</tr>
						<tr>
							<td><img src="images/Tim Theo Tinh Nang/14_WIFi_icon.gif" width="20" height="19" /></td>
							<td width="60">WIFI</td>
							<td><input name="tinhnang[]" type="checkbox" id="wifi" value="wifi" /></td>
						</tr>
						<tr>
							<td><img src="images/Tim Theo Tinh Nang/15_infrared_icon.gif" width="22" height="9" /></td>
							<td>Hồng ngoại</td>
							<td><input name="tinhnang[]" type="checkbox" id="hongngoai" value="hongngoai" /></td>
						</tr>
						<tr>
							<td><img src="images/Tim Theo Tinh Nang/16_mp3_icon.gif" width="20" height="21" /></td>
							<td>Nghe nhac MP3</td>
							<td><input name="tinhnang[]" type="checkbox" id="nghenhacmp3" value="nghenhacmp3" /></td>
						</tr>
						<tr>
							<td><img src="images/Tim Theo Tinh Nang/17_java_icon.gif" width="20" height="25" /></td>
							<td>Hỗ trợ Java</td>
							<td><input name="tinhnang[]" type="checkbox" id="java" value="java" /></td>
						</tr>
						<tr>
							<td><img src="images/Tim Theo Tinh Nang/18_bluetooth_icon.gif" width="14" height="18" /></td>
							<td>Bluetooth</td>
							<td><input name="tinhnang[]" type="checkbox" id="bluetooth" value="bluetooth" /></td>
						</tr>
						<tr>
							<td><img src="images/Tim Theo Tinh Nang/19_TwoSim_icon.gif" width="24" height="18" /></td>
							<td>2 Sim</td>
							<td><input name="tinhnang[]" type="checkbox" id="2sim" value="2sim" /></td>
						</tr>
						<tr align="center">
							<td colspan="3"><input type="submit" name="timtinhnang" value="Tìm kiếm"/></td>
						</tr>
					</table>
			</div><!--End.timtheotinhnang-->
			<div class="bottom_div_1"></div>