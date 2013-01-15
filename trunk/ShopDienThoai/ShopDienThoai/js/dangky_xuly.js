var DANGKY, flag1=false, flag2=false, flag3=false, flag4=false, flag5=false, flag6=false;
$(document).ready(function(){

	capcha_reload=function(ops){
	var r=parseInt(Math.random()*10000);
	$('.'+ops.capcha_show).attr({src:ops.link+'?id='+r});
	$('.'+ops.capcha_val).attr({value:r});
	return false;
	}

	DANGKY={
		xulyhoten:function(ops){
			//alert(ops.hoten);
			if(ops.hoten==""){
				$('.xulyhoten').html("<span class='not_accept'>Họ tên không được để trống</span>");
				flag1=false;
				}
			else{
				$('.xulyhoten').html("<img src='images/accept.png' height='16' />");
				flag1=true;
				}
		},
		
		xulyemail:function(ops){
		var filter = /^[a-zA-Z0-9._-]+@[a-zA-Z0-9.-]+.[a-zA-Z]{2,4}$/;
		if(ops.email=="")
			{$('.xulyemail').html("<span class='not_accept'>Email không được để trống</span>");flag2=false;}
		else{
			if(!filter.test(ops.email))
				{$('.xulyemail').html("<span class='not_accept'>Email không hợp lệ</span>");flag2=false;}
			else{
				$.ajax({
				url:'login/dangky_xuly_ajax.php',
				type:'post',
				dataType:'json',
				data:{email:ops.email,act:'xulyemail'},
				success:function(data){
					//$('.xulyemail').html(data);
					if(data.kiemtra==true)
					{$('.xulyemail').html("<img src='images/accept.png' height='16' />");flag2=true;}
					else
					{$('.xulyemail').html("<span class='not_accept'>Email nay da co nguoi su dung</span>");flag2=false;}
				}
				});
			}
		}
		},
		
		xulynhaplaiemail:function(ops){
		var email=ops.email;
		var nhaplaiemail=ops.nhaplaiemail;
		if(nhaplaiemail=="")
			{$('.xulynhaplaiemail').html("<span class='not_accept'>Email không được để trống</span>");flag3=false;}
		else{
			if(email != nhaplaiemail)
				{$('.xulynhaplaiemail').html("<span class='not_accept'>Email và email nhập lại không giống nhau</span>");flag3=false;}
			else
				{$('.xulynhaplaiemail').html("<img src='images/accept.png' height='16' />");flag3=true;}
			}
		
		},
		
		xulynhapmatkhau:function(ops){
		
		if(ops.matkhau=="")
			{$('.xulynhapmatkhau').html("<span class='not_accept'>Mật khẩu không được để trống</span>");flag4=false;}
		else{
			if((ops.matkhau).length<6)
				{$('.xulynhapmatkhau').html("<span class='not_accept'>Mật khẩu phải có độ dài tối thiểu 6 ký tự</span>");flag4=false;}
			else
				{$('.xulynhapmatkhau').html("<img src='images/accept.png' height='16' />");flag4=true;}
			}
		},
		
		xulynhaplaimatkhau:function(ops){
		var matkhau=ops.matkhau;
		var nhaplaimatkhau=ops.nhaplaimatkhau;
			if(nhaplaimatkhau=="")
				{$('.xulynhaplaimatkhau').html("<span class='not_accept'>Mật khẩu nhập lại không được để trống</span>");flag5=false;}
			else{
				if((nhaplaimatkhau).length<6)
				{$('.xulynhaplaimatkhau').html("<span class='not_accept'>Mật khẩu phải có độ dài tối thiểu 6 ký tự</span>");flag5=false;}
					else{
						if(matkhau != nhaplaimatkhau)
							{$('.xulynhaplaimatkhau').html("<span class='not_accept'>Mật khẩu nhập lại không giống nhau</span>");flag5=false;}
						else
							{$('.xulynhaplaimatkhau').html("<img src='images/accept.png' height='16' />");flag5=true;}
					}
				}
		},
		
		xulycapcha:function(ops){
			var capcha1 = ops.capcha1;
			var capcha2 = ops.capcha2;
			if(capcha2=="")
				{$('.xulycapcha').html("<span class='not_accept'>Mã xác nhận không được để trống</span>");flag6=false;}
			else{
				if(capcha2 != capcha1)
					{$('.xulycapcha').html("<span class='not_accept'>Mã xác nhận không giống nhau</span>");flag6=false;}
				if(capcha1==capcha2)
					{$('.xulycapcha').html("<img src='images/accept.png' height='16' />");flag6=true;}
				}
		},
		
		xulydangky:function(ops){
		if(flag1==false || flag2==false || flag3==false || flag4==false || flag5==false || flag6==false)
			alert('Bạn chưa nhập đầy đủ thông tin\nHoặc thông tin bạn nhập chưa chính xác');
		else{
				$.ajax({
					url:'login/dangky_xuly_ajax.php',
					type:'post',
					dataType:'json',
					data:$('form').serialize()+"&act=xulydangky",
					success:function(data){
						if(data.dangky==true){
							alert('Bạn đã đăng ký thành công');
							window.location="dangnhap.php";}
						else
							alert('Bạn chưa đăng ký thành công');
					}
					
				});
				
			}
		}
	}
	
});
