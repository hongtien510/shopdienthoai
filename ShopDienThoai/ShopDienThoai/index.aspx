<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage1.Master" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="ShopDienThoai.indexForm" %>
<asp:Content ID="indexContent" ContentPlaceHolderID="MainContaint" runat="server">
 		<div class="ctn_slider">
        	<div id="slider4" class="nivoSlider">
				<a href="#"><img src="images/slider/slider1.gif" alt="" width="590" height="240"/></a>
				<a href="#"><img src="images/slider/slider2.gif" alt="" width="590" height="240"/></a>
				<a href="#"><img src="images/slider/slider3.gif" alt="" width="590" height="240"/></a>
				<a href="#"><img src="images/slider/slider4.gif" alt="" width="590" height="240"/></a>
            </div>
            <script type="text/javascript" src="js/jquery.nivo.slider.pack.js"></script>
            <script type="text/javascript" src="js/nivo.js"></script>
		</div><!--End .ctn_slider-->


		<div class="ctn_dienthoaimoi">
			<div class="content_title_large">
				<h3 class="text_title">Điện thoại mới xuất hiện</h3>
			</div>
			<div class="dienthoaimoi bg_middle" style="padding-top:10px">
				<ul style="margin-left:12px">
                <asp:Repeater runat="server" ID="DienThoaiMoiXuatHien">
                <ItemTemplate>
					<li>
						<p style="padding-top:10px"><a class="tendt" href='<%# "dienthoaichitiet.aspx?idDT=" + Eval("idDT") %>'><%# Eval("TenDT") %></a></p>
						<p style="padding-top:20px">
							<a class="show_tooltip" href='<%# "dienthoaichitiet.aspx?idDT=" + Eval("idDT") %>' tool="1">
							<img src='<%# "images/" + Eval("TenHSX") + "/" + Eval("HinhAnh") %>' height="100" alt="dienthoai" border="0" /></a>
						</p>
						<p style="padding-top:10px"><span class="giadt"><%# Eval("Gia") %> VND</span></p>
					</li>
                </ItemTemplate>
                </asp:Repeater>
				</ul>
			</div><!--End.dienthoaimoi--> 
			<div class="end_large"></div>				
		</div><!--End .ctn_dienthoaimoi-->
    
		<div class="ctn_tab">
			<div class="tabs mgt_15">
				<div class="tab action"><a href="#">Điện thoại siêu cấp</a></div>
				<div class="tab"><a href="#">Điện thoại cao cấp</a></div>
				<div class="tab"><a href="#">Điện thoại trung cấp</a></div>
				<div class="tab"><a href="#">Điện thoại thông dụng</a></div>
			</div><!--End .tabs-->
			
			
			<div class="listtab ">
				<div class="top_large"></div>
				<div style="display:inline-block; margin-bottom:10px; margin:10px 0px">
					<ul style="margin-left:13px">
                    <asp:Repeater runat="server" ID="DienThoaiSieuCap">
                    <ItemTemplate> 
						<li>
							<p style="padding-top:10px"><a class="tendt" href=""><%# Eval("TenDT") %></a></p>
							<p style="padding-top:20px">
								<a class="show_tooltip" tool="1" href=""><img src='<%# "images/" + Eval("TenHSX") + "/" + Eval("HinhAnh") %>' height="100" alt="dienthoai" border="0" /></a>
							</p>
							<p style="padding-top:10px"><span class="giadt"><%# Eval("Gia") %> VND</span></p>
						</li>
                    </ItemTemplate>
                    </asp:Repeater>
					</ul> 
				</div>
				<div class="end_large clear"></div> 
			</div><!--End.listtabs-->
			
<!--DIEN THOAI CAO CAP-->			
			<div class="listtab hidden ">
				<div class="top_large"></div>
				<div style="display:inline-block; margin-bottom:10px; margin:10px 0px">
					<ul style="margin-left:13px">
                    <asp:Repeater runat="server" ID="DienThoaiCaoCap">
                    <ItemTemplate>
						<li>
							<p style="padding-top:10px"><a class="tendt" href=""><%# Eval("TenDT") %></a></p>
							<p style="padding-top:20px">
								<a class="show_tooltip" tool="1" href=""><img src='<%# "images/" + Eval("TenHSX") + "/" + Eval("HinhAnh") %>' height="100" alt="dienthoai" border="0" /></a>
							</p>
							<p style="padding-top:10px"><span class="giadt"><%# Eval("Gia") %> VND</span></p>
						</li>
                    </ItemTemplate>
                    </asp:Repeater>
					</ul>
				</div>
				<div class="end_large clear"></div>
			</div><!--End.listtabs-->
			
<!--DIEN THOAI TRUNG CAP-->				
			<div class="listtab hidden">
				<div class="top_large"></div>
				<div style="display:inline-block; margin-bottom:10px; margin:10px 0px">
					<ul style="margin-left:13px">
                    <asp:Repeater runat="server" ID="DienThoaiTrungCap">
                    <ItemTemplate>
                    
						<li>
							<p style="padding-top:10px"><a class="tendt" href=""><%# Eval("TenDT") %></a></a></p>
							<p style="padding-top:20px">
								<a class="show_tooltip" tool="1" href=""><img src='<%# "images/" + Eval("TenHSX") + "/" + Eval("HinhAnh") %>' height="100" alt="dienthoai" border="0" /></a>
							</p>
							<p style="padding-top:10px"><span class="giadt"><%# Eval("Gia") %> VND</span></p>
						</li>

                    </ItemTemplate>
                    </asp:Repeater>
					</ul>
				</div>
				<div class="end_large clear"></div>
			</div><!--End.listtabs-->
			
			
			<div class="listtab hidden">
				<div class="top_large"></div>
				<div style="display:inline-block; margin-bottom:10px; margin:10px 0px">
					<ul style="margin-left:13px">
                    <asp:Repeater runat="server" ID="DienThoaiThongDung">
                    <ItemTemplate>
                    
						<li>
							<p style="padding-top:10px"><a class="tendt" href=""><%# Eval("TenDT") %></a></p>
							<p style="padding-top:20px">
								<a class="show_tooltip" tool="1" href=""><img src='<%# "images/" + Eval("TenHSX") + "/" + Eval("HinhAnh") %>' height="100" alt="dienthoai" border="0" /></a>
							</p>
							<p style="padding-top:10px"><span class="giadt"><%# Eval("Gia") %> VND</span></p>
						</li>

                    </ItemTemplate>
                    </asp:Repeater>
					</ul>	
				</div>
				<div class="end_large clear"></div>
			</div><!--End.listtabs--> 
		</div><!--End.ctn_tab-->
</asp:Content>
