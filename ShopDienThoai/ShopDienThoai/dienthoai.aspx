<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage1.Master" AutoEventWireup="true" CodeBehind="dienthoai.aspx.cs" Inherits="ShopDienThoai.dienthoaiForm" %>
<asp:Content ID="dienthoaiContent" ContentPlaceHolderID="MainContaint" runat="server">
<div class="ctn_dienthoai">
        	<div class="content_title_large left">
            <asp:Repeater runat="server" ID="TitleTenHSX">
            <ItemTemplate>
                <h3 class="text_title"><%# Eval("TenHSX")%></h3>
            </ItemTemplate>
            </asp:Repeater>
            </div>
            <div class="dienthoai bg_middle" style="width:100%;">
            
				<form action="" method="post">
					<table>
                    <asp:Repeater runat="server" ID="DienThoaiTheoHSX">
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
