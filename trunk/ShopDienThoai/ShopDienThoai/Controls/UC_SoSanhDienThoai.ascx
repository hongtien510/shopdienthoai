<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="UC_SoSanhDienThoai.ascx.cs" Inherits="ShopDienThoai.Controls.UC_SoSanhDienThoai" %>

<div class="title_div_1 mg">
	<h4 class="text_title">So sánh điện thoại</h4> 
</div>
			
<div class="sosanhdienthoai middle_div_1">

    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
    <ContentTemplate>

        <asp:DropDownList CssClass="select_style" ID="ddl_hsxss" runat="server" 
                AutoPostBack="True" onselectedindexchanged="ddl_hsxss_SelectedIndexChanged">
                <asp:ListItem Value="0" Selected="True">-----Chọn Hãng------</asp:ListItem>
        </asp:DropDownList>
         <br />
        <asp:DropDownList CssClass="select_style" ID="ddl_dtss" runat="server">
              <asp:ListItem Value="0" Selected="True">-----Chọn Model------</asp:ListItem>
        </asp:DropDownList>

    </ContentTemplate>
    </asp:UpdatePanel>
    <asp:Button ID="bt_sosanh" runat="server" Text="So Sánh" 
        onclick="bt_sosanh_Click" />
</div><!--End .sosanhdienthoai-->
<div class="bottom_div_1"></div>
