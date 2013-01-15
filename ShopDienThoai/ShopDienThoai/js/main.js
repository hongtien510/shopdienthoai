
	$(document).ready(function(){							  
		$('.tab').click(function(){
			$('.tab').removeClass('action');
			$(this).addClass('action');

			$('.listtab').hide();
			$('.listtab').eq($('.tab').index(this)).show();return false;
	});	
	
	$('.tab').click(function(){
			$('.tab').removeClass('action');
			//alert('asd');	
			$(this).addClass('action');

			
			$('.listtab_ct').hide();
			$('.listtab_ct').eq($('.tab').index(this)).show();return false;
	});	
		
///////////////////////////////////////////////////////////////////////////////////////////////////////////		
	$('.select_hsx').change(function(){									   
	$.ajax({
		   url:'Modules/ajax_TenDT.php',
		   data:{id:$(this).val()},
		   dataType:'html',
		   type:'post',
		   success:function(data){//alert(data);
			   $('#idDT').html(data);
			    //$('#select_name_dt').attr({disabled:'enable'});
			   }
		   });								
	});

	$('.idHSX0 option').click(function(){									   
	$.ajax({
		   url:'Modules/ajax_TenDT.php',
		   data:{id:$(this).val()},
		   dataType:'html',
		   type:'post',
		   success:function(data){//alert(data);
			   $('#idDT0').html(data);
			    //$('#select_name_dt').attr({disabled:'enable'});
			   }
		   });								
	});	
	
	$('.idHSX1 option').click(function(){									   
	$.ajax({
		   url:'Modules/ajax_TenDT.php',
		   data:{id:$(this).val()},
		   dataType:'html',
		   type:'post',
		   success:function(data){//alert(data);
			   $('#idDT1').html(data);
			    //$('#select_name_dt').attr({disabled:'enable'});
			   }
		   });								
	});
	
	
	
	$('.idHSX2 option').click(function(){									   
	$.ajax({
		   url:'Modules/ajax_TenDT.php',
		   data:{id:$(this).val()},
		   dataType:'html',
		   type:'post',
		   success:function(data){//alert(data);
			   $('#idDT2').html(data);
			    //$('#select_name_dt').attr({disabled:'enable'});
			   }
		   });								
	});
	
	$('.idHSX3 option').click(function(){									   
	$.ajax({
		   url:'Modules/ajax_TenDT.php',
		   data:{id:$(this).val()},
		   dataType:'html',
		   type:'post',
		   success:function(data){//alert(data);
			   $('#idDT3').html(data);
			    //$('#select_name_dt').attr({disabled:'enable'});
			   }
		   });								
	});
	
	
	
	
	
	
	
	$('.show_tooltip').mouseover(function(e){
		$.ajax({
			url:'Modules/ajax_tooltip.php',
			type:'post',
			dataType:'html',
			data:{idDT:$(this).attr('tool')},
			success:function(data){
			//alert(data)
			$('#tooltip').html(data);
			}
		});								  
										  
	});	
	
	$('.show_tooltip').mousemove(function(e){
		$('#tooltip').css({
						   'left':e.pageX+10,
						   'top':e.pageY+10,
						   'display':'block',
						   
						   });
	});
	$('.show_tooltip').mouseout(function(e){
		$('#tooltip').fadeOut();
	});
	
	

	
	
});



