<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="UC_CacHangDienThoai.ascx.cs" Inherits="ShopDienThoai.Controls.UC_CacHangDienThoai" %>
<div class="title_div_1 mg">
	<h4 class="text_title">Các hãng điện thoại</h4>
</div>			
<div class="cachangdienthoai middle_div_1">
<table>
<asp:Repeater runat="server" ID="CachangDienThoai">
<ItemTemplate>
	<tr>
		<td><a href='<%# "dienthoai.aspx?idHSX=" + Eval("idHSX") %>'><%# Eval("TenHSX") %></a></td>
	</tr>
</ItemTemplate>
</asp:Repeater>
</table>
</div><!--End .cachangdienthoai-->
<div class="bottom_div_1"></div>