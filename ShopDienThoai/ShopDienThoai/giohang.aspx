<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage2.Master" AutoEventWireup="true" CodeBehind="giohang.aspx.cs" Inherits="ShopDienThoai.giohangForm" %>
<asp:Content ID="giohangContent" ContentPlaceHolderID="DetailContent" runat="server">
<div class="ctn_giohang">
   		<div class="title_largest left">
			<h3 class="text_title">Giỏ hàng</h3>
        </div>
		
        <div class="giohang bg_middle_largest" style="width:100%">
			<form action="Modules/giohang_xuly.php" method="post" name="giohang">
				<table width="793" border="0">
					<tr bgcolor="#CCFFFF">
						<td width="30" align="center">STT</td>
						<td width="30" align="center">Xóa</td>
						<td colspan="2" align="center">Sản phẩm</td>
						<td width="60" align="center">Số lượng</td>
						<td width="135" align="center">Giá</td>
						<td width="135" align="center">Thành tiền</td>
					</tr>

					<tr align="center">
						<td align="center">1</td>
						<td align="center">
							<a href="" onclick="return confirm('Bạn có chắc chắn muốn xóa sản phẩm này\nra khỏi giỏ hàng hay không')"><img src="images/b_drop.png" width="16" height="16" border="0" /></a>
						</td>
						<td width="96" align="center">
							<a href=""><img src="images/NOKIA/Nokia N9 64 GB.jpg" height="80" /></a>
						</td>
						<td width="277" class="left" ><a class="tendt" href="">Nokia N9 64 GB</a></td>
						<td align="center"><input name="soluong" type="text" id="soluong" size="4" value="1"/></td>
						<td align="center"><span class="giadt">10.000.000 VND</span></td>
						<td align="center"><span class="giadt">10.000.000 VND</span></td>
					</tr>
					<tr align="center" class="col_tr">
						<td align="center">1</td>
						<td align="center">
							<a href="" onclick="return confirm('Bạn có chắc chắn muốn xóa sản phẩm này\nra khỏi giỏ hàng hay không')"><img src="images/b_drop.png" width="16" height="16" border="0" /></a>
						</td>
						<td width="96" align="center">
							<a href=""><img src="images/NOKIA/Nokia N9 64 GB.jpg" height="80" /></a>
						</td>
						<td width="277" class="left" ><a class="tendt" href="">Nokia N9 64 GB</a></td>
						<td align="center"><input name="soluong" type="text" id="soluong" size="4" value="1"/></td>
						<td align="center"><span class="giadt">10.000.000 VND</span></td>
						<td align="center"><span class="giadt">10.000.000 VND</span></td>
					</tr>

					<tr align="center">
						<td colspan="5" align="left">
							<a href="index.php"><img src="images/TiepTucMuaHang.jpg" width="160" height="30" border="0" /></a>&nbsp;
							<a href="#" onclick="document.forms['giohang'].submit()"><img src="images/CapNhat.jpg" width="100" height="30" border="0" /></a>&nbsp;
							<a href=""><img src="images/DatMuaNgay.jpg" width="160" height="30" border="0" /></a>
						</td>
					
						<td colspan="2" align="center">
							<span style="color:#292929; font-weight:bold; font-size:19px">Tổng cộng : </span><br />
							<span style="color:#00F; font-weight:bold; font-size:19px">10.000.000 VNĐ</span>
						</td>
					</tr>
				</table>
			</form>
        </div><!--End .giohang-->
        <div class="bg_end_largest"></div>
    </div><!--End .ctn_giohang-->     
</asp:Content>
