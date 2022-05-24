<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DoiMatKhau.aspx.cs" Inherits="BaiGiangTrucTuyen.DoiMatKhau" %>
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <title>Login</title>
   <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">
    <meta name="description" content="">
    <meta name="author" content="">
    <link href="https://fonts.googleapis.com/css?family=Roboto:100,300,400,500,700" rel="stylesheet">

    <title>Pixie - Ecommerce HTML5 Template</title>

    <!-- Bootstrap core CSS -->
    <link href="vendor/bootstrap/css/bootstrap.min.css" rel="stylesheet">
    <!-- Additional CSS Files -->
    <link rel="stylesheet" href="assets/css/fontawesome.css">
    <link rel="stylesheet" href="assets/css/tooplate-main.css">
    <link rel="stylesheet" href="assets/css/owl.css">
    <link rel="stylesheet" href="assets/css/ChangePass.css"  />
</head>
<body>
    <form  runat="server">
        <body>
            <!-- Page Content -->
            <!-- Banner Starts Here -->
            <div class="banner-login">
                <div class="container">
                    <div class="row">
                        <div class="col-md-12">
                            <div class="caption">
                                <form action="/" id="form1" method="post">
                                    <h2>Đổi mật khẩu</h2>
                                    <div>
                                        <div>
                                             <a class="navbar-brand" href="#"><img id="logo2" src="assets/images/logo2.png" alt=""></a>
                                        </div>
                                        <span>Nhập mật khẩu cũ</span><asp:TextBox ID="txtOldPass" runat="server" CssClass="textbox" TextMode="Password"></asp:TextBox>
                             <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="The password does not allow null" Display="Dynamic" ControlToValidate="txtOldPass" ForeColor="Red" SetFocusOnError="true"></asp:RequiredFieldValidator>
                                    </div>
                                    <div>
                                        <span>Nhập mật khẩu mới</span><asp:TextBox ID="txtNewPassWord" runat="server" CssClass="textbox" TextMode="Password"></asp:TextBox>
                           <asp:RequiredFieldValidator ID="NewPassWord" runat="server" ErrorMessage="Mật khẩu không được để trống" Display="Dynamic" ControlToValidate="txtNewPassWord" ForeColor="Red" SetFocusOnError="true"></asp:RequiredFieldValidator>
                                    </div>
                                     <div>
                                        <span>Xác nhận mật khẩu mới</span><asp:TextBox ID="txtComfirmPass" runat="server" CssClass="textbox" TextMode="Password"></asp:TextBox>
                                     <asp:RequiredFieldValidator ID="ComfirmPass" runat="server" ErrorMessage="Mật khẩu không được để trống" Display="Dynamic" ControlToValidate="txtComfirmPass" ForeColor="Red" SetFocusOnError="true"></asp:RequiredFieldValidator>
                                           <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="txtNewPassWord" ControlToValidate="txtComfirmPass" ForeColor="Red" Operator="Equal"  ErrorMessage="Mật khẩu xác nhận không chính xác"></asp:CompareValidator>
                                    </div>
                                      <asp:ValidationSummary ID="ValidationSummary2" runat="server" ShowMessageBox="true" ShowSummary="false" />
                                    <asp:Button ID="btnChangepass" runat="server" Text="Đổi mật khẩu " CssClass="btn btn-success" OnClick="btnChangepass_Click"  />
                                    <asp:Label Text="ABCKJJKJ" id="lbThongBao" runat="server" />
                                </form>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            </div>
    <!-- Banner Ends Here -->

            <!-- Bootstrap core JavaScript -->
            <script src="vendor/jquery/jquery.min.js"></script>
            <script src="vendor/bootstrap/js/bootstrap.bundle.min.js"></script>


            <!-- Additional Scripts -->
            <script src="assets/js/custom.js"></script>
            <script src="assets/js/owl.js"></script>


            <script language="text/Javascript"> 
      cleared[0] = cleared[1] = cleared[2] = 0; //set a cleared flag for each field
      function clearField(t){                   //declaring the array outside of the
      if(! cleared[t.id]){                      // function makes it static and global
          cleared[t.id] = 1;  // you could use true and false, but that's more typing
          t.value='';         // with more chance of typos
          t.style.color='#fff';
          }
      }
            </script>


        </body>

    </form>
</body>
</html>
