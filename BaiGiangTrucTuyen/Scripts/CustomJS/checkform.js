function checksearch() {
	var chuoi = document.getElementsByName("keysearch")[0].value;
	if (chuoi == '') {
		alert("Bạn hãy nhập trước trước khi thực hiện");
		document.getElementsByName("keysearch")[0].focus();
		return false;
	}
	else
		return true;

}
function checkdodai() {
	var chuoi = document.getElementsByName("keysearch")[0].value;
	if (chuoi == '') {
		alert("Bạn hãy nhập trước trước khi thực hiện");
		document.getElementsByName("keysearch")[0].focus();
		return false;
	}
	if (chuoi.length < 5) {
		alert("Bạn hãy nhập dài hơn 5 kí tự");
		document.getElementsByName("keysearch")[0].focus();
		return false;
	}
	else
		return true;
}

//} viết ở đâyy thì mới là js chứ. k đấy là c# r @@
//qu
//document.getElementById("btnbuton").click(function () {
//	if (document.getElementById("keysearch") == "") {
//		alert("Bạn phải nhập trước khi tìm kiếm");
//    }
//})
function checkformlogin() {
	var tk = document.getElementsByName("txtuser")[0].value;
	var mk = document.getElementsByName("txtpassword")[0].value;//ngu quá
	if (tk == '' || mk == '')
		alert("Bạn hãy điền tên tài khoản mật khẩu trước khi đăng nhập");
	if (mk.length < 5)
		alert("Bạn hãy nhập mật khẩu đủ 8 kí tự");
	var regex = /(?=.*[A-Z])/;
	if (regex.test(mk) == false) {
		debugger
		alert("Bạn hãy nhập mật khẩu có ít nhất 1 chữ hoa ");
		return false;
	}

}
function checkformresgiter() {
	var fullname = document.getElementsByName("txtfullname")[0].value;
	var bd = document.getElementsByName("txtbirthday")[0].value;
	var bd = document.getElementsByName("txtbirthday")[0].value;
	var bd = document.getElementsByName("user")[0].value;
}

function checklogin() {
	var tk = document.getElementsByName("txtUsername")[0].value;
	var mk = document.getElementsByName("txtPassWord")[0].value;
	if (tk == '' || mk == '') {
		alert("Bạn hãy điền tên tài khoản mật khẩu trước khi đăng nhập");
		return false;
	}
	if (mk.length < 5) {
		alert("Bạn hãy nhập mật khẩu đủ 5 kí tự");
		return false;
	}
	var regex = /(?=.*[A-Z])/;// ít nhất 1 chữ hoa
	if (regex.test(mk) == false) {
		alert("Bạn hãy nhập mật khẩu có ít nhất 1 chữ hoa ");
		return false
	}
	return true;
}

