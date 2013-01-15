<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="UC_TimKiemDienThoai.ascx.cs" Inherits="ShopDienThoai.Controls.UC_TimKiemDienThoai" %>

<div class="title_div_1">
	<h4 class="text_title">Tìm kiếm điện thoại</h4>
</div>
<div class="timkiemdienthoai middle_div_1">
		<input runat="server" id="keyword" class="a" type="text" name="keyword" value="" />
        <br />
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>

            <asp:DropDownList CssClass="select_hsx select_style" ID="ddl_hsx" 
                runat="server" AutoPostBack="True" 
                onselectedindexchanged="ddl_hsx_SelectedIndexChanged">
                <asp:ListItem Value="0" Selected="True">-----Chọn Hãng------</asp:ListItem>
            </asp:DropDownList>
		    <br />
		    <asp:DropDownList CssClass="select_style" ID="ddl_dt" runat="server" 
                AutoPostBack="True" onselectedindexchanged="ddl_dt_SelectedIndexChanged">
                <asp:ListItem Value="0" Selected="True">-----Chọn Model------</asp:ListItem>
            </asp:DropDownList>	
    
        </ContentTemplate>
        </asp:UpdatePanel>

		
        <asp:DropDownList CssClass="select_style" ID="ddl_GiaTu" runat="server">
            <asp:ListItem Selected="True" Value="-1">-----Giá Từ-----</asp:ListItem>
            <asp:ListItem Value="0">0</asp:ListItem>
            <asp:ListItem Value="1000000">1 Triệu</asp:ListItem>
            <asp:ListItem Value="2000000">2 Triệu</asp:ListItem>
            <asp:ListItem Value="3000000">3 Triệu</asp:ListItem>
            <asp:ListItem Value="4000000">4 Triệu</asp:ListItem>
            <asp:ListItem Value="5000000">5 Triệu</asp:ListItem>
            <asp:ListItem Value="6000000">6 Triệu</asp:ListItem>
            <asp:ListItem Value="7000000">7 Triệu</asp:ListItem>
            <asp:ListItem Value="8000000">8 Triệu</asp:ListItem>
            <asp:ListItem Value="9000000">9 Triệu</asp:ListItem>
        </asp:DropDownList>
        <br />
        <asp:DropDownList CssClass="select_style" ID="ddl_GiaDen" runat="server">
            <asp:ListItem Selected="True" Value="-1">-----Giá Đến-----</asp:ListItem>
            <asp:ListItem Value="1000000">1 Triệu</asp:ListItem>
            <asp:ListItem Value="2000000">2 Triệu</asp:ListItem>
            <asp:ListItem Value="3000000">3 Triệu</asp:ListItem>
            <asp:ListItem Value="4000000">4 Triệu</asp:ListItem>
            <asp:ListItem Value="5000000">5 Triệu</asp:ListItem>
            <asp:ListItem Value="6000000">6 Triệu</asp:ListItem>
            <asp:ListItem Value="7000000">7 Triệu</asp:ListItem>
            <asp:ListItem Value="8000000">8 Triệu</asp:ListItem>
            <asp:ListItem Value="9000000">9 Triệu</asp:ListItem>
            <asp:ListItem Value="10000000">>10 Triệu</asp:ListItem>
        </asp:DropDownList>
        <br />
        <asp:Button ID="bt_TimKiem" runat="server" Text="Tìm Kiếm" 
            onclick="bt_TimKiem_Click" />
        <br />
		
        <br />
	</div><!--End .timkiemdienthoai-->
<div class="bottom_div_1"></div>

