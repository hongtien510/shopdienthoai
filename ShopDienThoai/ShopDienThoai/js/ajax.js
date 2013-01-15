// JavaScript Document
function getHttpRequest()
{
	if (window.XMLHttpRequest) {
		return new XMLHttpRequest(); //Mozilla, Safari ...
	} else if (window.ActiveXObject) {
		return new ActiveXObject("Microsoft.XMLHTTP"); //IE
	} else {
		alert("Lỗi không tạo được object");
	}
}
var httpRequest=null;
var response="response.php";
var urlback = new Array();
var div='folders';//Neu ko truyen id_div thi lay mac dinh la folders
function request(id_div,str)//id_div la id cua div se duoc dua noi dung vao, str la tham so dang ti=5&teo=6&abc=123...
{
	httpRequest=null;
	div=id_div;
	httpRequest=getHttpRequest();
	//urlback.push(div+"|"+str);
	document.getElementById(div).innerHTML='<p>&nbsp;</p><p align="center"><img src="images/lightbox-ico-loading.gif" alt="loading..." width="16" height="16" /></p>';
	var url=response+"?"+str+"&ran="+Math.random();
	httpRequest.onreadystatechange=stateChanged;
	httpRequest.open("GET",url,true);
	httpRequest.setRequestHeader("Connection", "close");
	httpRequest.send(null);
}

function stateChanged() 
{
	var str="";
	if (httpRequest.readyState==4 || httpRequest.readyState=="complete")
	{ 
		str=str + httpRequest.responseText;
		//alert(str);
		document.getElementById(div).innerHTML= str;
		/*pos=str.indexOf("<script>");		
		pos2=str.indexOf("</script>");
		if(pos>-1){
			script=str.substring(pos+8,pos2-1);			
			eval(script);
		}*/
	}
}
function go_back(time)
{	
	if(time=="")time=1;
	for(i=0;i<time;i++)
	str=urlback.pop();
	if(urlback.length>0)
	{
		str=urlback.pop();
		pos=str.indexOf("|");
		div = str.substring(0,pos);
		str=str.substring(pos+1);
		showHint(div,str);
	}
	//Khong con url de back thi lay default
	else showHint('folders','act=listFolder&id_folder=0');

}