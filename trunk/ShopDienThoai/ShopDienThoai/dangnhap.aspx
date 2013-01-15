<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage2.Master" AutoEventWireup="true" CodeBehind="dangnhap.aspx.cs" Inherits="ShopDienThoai.dangnhapForm" %>
<asp:Content ID="Content1" ContentPlaceHolderID="DetailContent" runat="server">
<div class="ctn_dangnhap">
   		<div class="title_largest left">
        <h3 class="text_title">Đăng nhập</h3>
        </div>
        <div class="dangnhap bg_middle_largest" style="width:100%">
<form action="login/dangnhap_xuly.php" method="post" name="dangnhap"/>      
        <table width="300" border="0">
        <tr>
        <td colspan="2"><p class="col_text">Để tiếp tục đặt mua hàng Online, vui lòng <a href="dangky.php">Đăng ký</a> (nếu chưa có tài khoản) hoặc đăng nhập theo thông tin bên dưới.</p></td>
        </tr>
          <tr>
            <td width="308" align="right" >Email<span style="color:#F00;">(*)</span></td>
            <td width="432" align="left"><input class="styleinput" type="text" name="email" placeholder="Nhập Email" value="" /><br /></td>
          </tr>
          <tr>
            <td align="right">Mật khẩu<span style="color:#F00;">(*)</span></td>
            <td align="left"><input class="styleinput" type="password" name="matkhau" placeholder="Nhập mật khẩu"  /></td>
          </tr>
		  <tr>
            <td align="right">&nbsp;</td>
            <td align="left"><label><input type="checkbox" name="ghinho" value="1"/>&nbsp;Ghi nhớ </label></td>
          </tr>
          <tr>
            <td align="right">&nbsp;</td>
            <td align="left">
			<a href="#" onClick="document.forms['dangnhap'].submit()">
			<img src="images/DangNhap.jpg" width="100" height="30" border="0" /></a><a href="#">&nbsp;<img src="images/DangKy.jpg" width="100" height="30" border="0" /></a>
			</td>
          </tr>
        </table>
</form>

        </div><!--End .dangnhap-->
        <div class="bg_end_largest"></div>
    </div><!--End.ctn_dangnhap--> 
</asp:Content>
