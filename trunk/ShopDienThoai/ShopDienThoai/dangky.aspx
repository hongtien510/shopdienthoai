<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage2.Master" AutoEventWireup="true" CodeBehind="dangky.aspx.cs" Inherits="ShopDienThoai.dangkyForm" %>
<asp:Content ID="Content1" ContentPlaceHolderID="DetailContent" runat="server">
<div class="ctn_dangky">
   		<div class="title_largest left">
       <h3 class="text_title">Đăng ký</h3>
        </div>
        <div class="dangky bg_middle_largest" style="width:100%">
        <form action="" method="post" name="dangky">
        <table width="793" border="0">
          <tr>
            <td colspan="2" align="center"><p class="col_text">Vui lòng nhập đầy đủ thông tin dưới đây</p></td>
            </tr>
          <tr>
            <td width="298" align="right">Họ tên <span style="color:#F00;">(*)</span> : </td>
            <td width="442" align="left"><label>
              <input type="text" name="hoten" id="hoten" onBlur="DANGKY.xulyhoten({hoten:this.value})" />
			  <span class="xulyhoten"></span>
            </label></td>
          </tr>
          <tr>
            <td align="right">Email <span style="color:#F00;">(*)</span> :</td>
            <td align="left">
			<input type="text" name="email" id="email" onBlur="DANGKY.xulyemail({email:this.value})"/>
			<span class="xulyemail"></span>
			</td>
          </tr>
          <tr>
            <td align="right">Nhập lại Email <span style="color:#F00;">(*)</span> : </td>
            <td align="left"><input type="text" name="nhaplaiemail" id="nhaplaiemail" onBlur="DANGKY.xulynhaplaiemail({email:document.getElementById('email').value,nhaplaiemail:this.value})" />
			<span class="xulynhaplaiemail"></span>
			</td>
          </tr>
          <tr>
            <td align="right">Mật khẩu <span style="color:#F00;">(*)</span> :</td>
            <td align="left">
			<input type="password" name="matkhau" id="matkhau" onBlur="DANGKY.xulynhapmatkhau({matkhau:this.value})" />
			<span class="xulynhapmatkhau"></span>
			</td>
          </tr>
          <tr>
            <td align="right">Nhập lại mật khẩu <span style="color:#F00;">(*)</span> :</td>
            <td align="left">
			<input type="password" name="nhaplaimatkhau" id="nhaplaimatkhau" onBlur="DANGKY.xulynhaplaimatkhau({nhaplaimatkhau:this.value, matkhau:document.getElementById('matkhau').value})" />
			<span class="xulynhaplaimatkhau"></span>
			</td>
          </tr>
          <tr>
            <td align="right">Ngày Sinh : </td>
            <td align="left">
			<select name="ngaysinh">
            <option value="0" selected="selected">Ngày</option>


            </select>&nbsp;
            <select name="thangsinh">
            <option value="0" selected="selected">Tháng</option>

            
            </select>&nbsp;
            <select name="namsinh">
            <option value="0" selected="selected">Năm</option>

            </select>
			</td>
          </tr>
          <tr>
            <td align="right">Giới tính : </td>
            <td align="left">
			 <select name="gioitinh">
            <option value="0" selected="selected">Chọn</option>
			<option value="1">Nam</option>
			<option value="2">Nữ</option>
			<option value="3">Khác</option>
            </select>
			</td>
          </tr>
          <tr>
            <td align="right">Số điện thoại :</td>
            <td align="left"><input type="text" name="phone" id="phone" /></td>
          </tr>
          <tr>
            <td align="right">Địa chỉ : </td>
            <td align="left"><textarea name="diachi" rows="5" id="diachi"></textarea></td>
          </tr>
		  <tr>
            <td align="right">Mã xác nhận : </td>
			<?php $capcha=rand(); ?>
            <td align="left">
			<input type="hidden" class="capcha_val xacnhan_reg" id="capcha1" name="<?php echo md5('xacnhan_reg');?>" value="<?php echo $capcha;?>"/>
			<img src="login/image.php?id=<?php echo $capcha;?>" class="capcha capcha_show" style="padding:0px;width:auto;height:auto">
			<a href="#" onclick="return capcha_reload({capcha_show:'capcha_show',capcha_val:'capcha_val',link:'login/image.php'});"><img src="images/reload.gif" class="mr_left_5 capcha_reload"></a>

			</td>
          </tr>
		  <tr>
            <td align="right">&nbsp;</td>
            <td align="left">
			<span style="font-size:13px">Nhập mã xác nhận vào ô bên dưới hoặc click <a  href="#" onclick="return capcha_reload({capcha_show:'capcha_show',capcha_val:'capcha_val',link:'login/image.php'});">refresh</a> để chọn hình khác.</span>
			</td>
          </tr>
		  <tr>
            <td align="right">Nhập mã xác nhận <span style="color:#F00;">(*)</span> : </td>
            <td align="left">
			<input type="text" name="capcha" id="phone" onBlur="DANGKY.xulycapcha({capcha1:document.getElementById('capcha1').value,capcha2:this.value})" />
			<span class="xulycapcha"></span>
			</td>
          </tr>
          <tr>
            <td align="right">&nbsp;</td>
            <td align="left"><a href="#" onClick="DANGKY.xulydangky()"><img src="images/DangKy.jpg" width="100" height="30" border="0" /></a>
            </td>
          </tr>
        </table>
		</form>
        </div><!--End .dangky-->
        <div class="bg_end_largest"></div>
</div><!--End.ctn_dangky-->
</asp:Content>
