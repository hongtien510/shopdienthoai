<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage1.Master" AutoEventWireup="true" CodeBehind="search.aspx.cs" Inherits="ShopDienThoai.search" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContaint" runat="server">
<div class="ctn_dienthoai">
        	<div class="content_title_large left">

                <h3 class="text_title">Tìm Kiếm Điện Thoại</h3>

            </div>
            <div class="dienthoai bg_middle" style="width:100%;">
            
				<form action="" method="post">
					<table>
                    <asp:Repeater runat="server" ID="TimKiemDienThoai">
                    <ItemTemplate>
                    
						<tr align="center">
							<td width="26" valign="top"><input type="checkbox" name="sosanh[]" id="sosanh" value="" /></td>
							<td width="89"><a class="show_tooltip" tool="1" href='<%# "dienthoaichitiet.aspx?idDT=" + Eval("idDT") %>'><img src='<%# "images/" + Eval("TenHSX") + "/" + Eval("HinhAnh") %>' height="120" border="0" /></a></td>
							<td  valign="top" width="308" class="left">
							<p style="margin-top:20px"><a class="tendt" href='<%# "dienthoaichitiet.aspx?idDT=" + Eval("idDT") %>'><%# Eval("TenDT") %></a></p><br />
							
                            <%# Eval("MoTa") %>

							</td>
							<td width="149">
								<span class="giadt"><%# Eval("Gia") %> VND</span><br/>
								<a href='<%# "dienthoaichitiet.aspx?idDT=" + Eval("idDT") %>'><img src="images/xemchitiet_but.gif" width="85" height="21" border="0" /></a><br />
								<a href=""><img src="images/dathang_but.gif" width="125" height="27" border="0" /></a><br />
							</td>
						</tr>

                    </ItemTemplate>
                    </asp:Repeater>
					</table>
				</form>
			</div><!--End.dienthoai-->
			<div class="end_large"></div>
        </div><!--End .ctn_dienthoai-->
</asp:Content>
